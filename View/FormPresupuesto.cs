using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Data;
using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormPresupuesto : Form
    {
        private MenuController _menuController;
        private ServicioAdicionalController _servicioController;
        private PresupuestoController _presupuestoController;
        private ClienteController _clienteController;
        private SalonController _salonController;

        // Generador aleatorio para evitar duplicados de DNI y nombres en cada prueba
        private static Random _rnd = new Random();

        // Variable a nivel de clase para retener el último presupuesto y exportarlo a PDF con el Botón 2
        private Presupuesto _presupuestoEjemplo;

        public FormPresupuesto()
        {
            InitializeComponent();
            _menuController = new MenuController();
            _servicioController = new ServicioAdicionalController();
            _presupuestoController = new PresupuestoController();
            _clienteController = new ClienteController();
            _salonController = new SalonController();
            _presupuestoEjemplo = null;

            // Suscribimos el evento Activated para refrescar la grilla cada vez que la ventana toma foco
            this.Activated += FormPresupuesto_Activated;
        }

        private void lblPresupuestoTest_Click(object sender, EventArgs e)
        {
        }

        // --- CONFIGURACIÓN DE LA GRILLA ---
        private void ConfigurarGrillaPresupuestos()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Definición de columnas profesionales mapeadas al PresupuestoDto
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Nº ID", DataPropertyName = "Id", FillWeight = 10 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaPresupuesto", HeaderText = "Fecha Presupuesto", DataPropertyName = "FechaPresupuesto", FillWeight = 20 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreCliente", HeaderText = "Cliente", DataPropertyName = "NombreCliente", FillWeight = 25 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreSalon", HeaderText = "Salón", DataPropertyName = "NombreSalon", FillWeight = 20 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", DataPropertyName = "Estado", FillWeight = 15 });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Total",
                    HeaderText = "Total ($)",
                    DataPropertyName = "Total",
                    FillWeight = 15,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
                });
            }
        }

        // --- MÉTODO UNIFICADO DE FILTRADO Y ACTUALIZACIÓN ---
        private void ActualizarGrillaPresupuestos()
        {
            try
            {
                ConfigurarGrillaPresupuestos();

                IEnumerable<PresupuestoDto> listaDtos = _presupuestoController.ListarPresupuestos();
                IEnumerable<PresupuestoDto> consulta = listaDtos;

                // 1. Filtro por texto (cliente, salón, estado, id, fecha)
                string textoBusqueda = txtBoxBuscarPresupuesto.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    consulta = consulta.Where(p =>
                        p.Id.ToString().Contains(textoBusqueda) ||
                        (p.NombreCliente != null && p.NombreCliente.ToLower().Contains(textoBusqueda)) ||
                        (p.NombreSalon != null && p.NombreSalon.ToLower().Contains(textoBusqueda)) ||
                        (p.Estado.ToString().ToLower().Contains(textoBusqueda)) ||
                        (p.FechaPresupuesto.ToString().Contains(textoBusqueda))
                    );
                }

                // 2. Filtro por precio máximo (si se ingresó un número válido)
                string textoPrecioMax = txtBoxPrecioMaximo.Text.Trim();
                if (!string.IsNullOrEmpty(textoPrecioMax))
                {
                    decimal precioMaximo = 0;
                    bool esValido = decimal.TryParse(textoPrecioMax, out precioMaximo);
                    if (esValido)
                    {
                        consulta = consulta.Where(p => p.Total <= precioMaximo);
                    }
                }

                List<PresupuestoDto> listaFiltrada = consulta.ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar o filtrar la grilla de presupuestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- EVENTO LOAD DEL FORMULARIO ---
        private void FormPresupuesto_Load(object sender, EventArgs e)
        {
            ActualizarGrillaPresupuestos();
        }

        // --- EVENTO ACTIVATED PARA ACTUALIZACIÓN CONSTANTE AL VOLVER AL FORMULARIO ---
        private void FormPresupuesto_Activated(object sender, EventArgs e)
        {
            ActualizarGrillaPresupuestos();
        }

        // --- MÉTODO AUXILIAR PARA ABRIR EL DETALLE DE UN PRESUPUESTO ---
        private void AbrirDetallePresupuesto(int presupuestoId)
        {
            try
            {
                Presupuesto presupuestoSeleccionado = null;

                if (_presupuestoEjemplo != null && _presupuestoEjemplo.Id == presupuestoId)
                {
                    presupuestoSeleccionado = _presupuestoEjemplo;
                }
                else
                {
                    presupuestoSeleccionado = _presupuestoController.BuscarModeloPresupuestoPorId(presupuestoId);
                }

                if (presupuestoSeleccionado != null)
                {
                    FormDetallePresupuesto popup = new FormDetallePresupuesto(presupuestoSeleccionado);
                    popup.ShowDialog();

                    // Refrescamos por si hubo cambios al cerrar el popup
                    ActualizarGrillaPresupuestos();
                }
                else
                {
                    MessageBox.Show("No se encontró el detalle del presupuesto seleccionado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que el doble clic haya sido en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                int presupuestoId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                AbrirDetallePresupuesto(presupuestoId);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormPresupuestoGestion formPresupuestoGestion = new FormPresupuestoGestion();
            formPresupuestoGestion.ShowDialog();

            // Actualizamos la grilla al volver de crear/editar un presupuesto
            ActualizarGrillaPresupuestos();
        }

        private void btnResetBaseDatos_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea restablecer la base de datos? Se borrarán todos los registros actuales de forma permanente.",
                "Advertencia de Seguridad",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SalonDbContext context = new SalonDbContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                    }

                    _presupuestoEjemplo = null;
                    ActualizarGrillaPresupuestos();

                    MessageBox.Show(
                        "La base de datos se ha restablecido correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ocurrió un error al intentar restablecer la base de datos: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void txtBoxBuscarPresupuesto_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrillaPresupuestos();
        }

        private void txtBoxPrecioMaximo_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrillaPresupuestos();
        }

        private void btnPresupuestoDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int presupuestoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                AbrirDetallePresupuesto(presupuestoId);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un presupuesto de la lista para ver sus detalles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}