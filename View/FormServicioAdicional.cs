using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormServicioAdicional : Form
    {
        private readonly ServicioAdicionalController _controller = new ServicioAdicionalController();
        private bool _esEdicion = false;

        public ServicioAdicional? ServicioSeleccionado { get; private set; }

        public FormServicioAdicional()
        {
            InitializeComponent();
            ConfigurarFormularioInicial();
            CargarGrillaServicios();

            dgvServicioAdicionalDatos.CellDoubleClick += dgvServicioAdicionalDatos_CellDoubleClick;

            // Eliminamos el evento Load automático que bloqueaba el panel al abrir la pantalla
            this.FormClosed += FormServicioAdicional_FormClosed;
        }

        private void FormServicioAdicional_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.ActivarPanelPrincipal();
            }
        }

        private void ConfigurarFormularioInicial()
        {
            DesactivarDatosServicio();
            LimpiarCampos();
        }

        private void ActivarDatosServicio()
        {
            txtServicioAdicionalNombre.Enabled = true;
            txtServicioAdicionalPrecio.Enabled = true;

            btnServicioAdicionalConfirmar.Enabled = true;
            btnServicioAdicionalCancelar.Enabled = true;

            btnServicioAdicionalNuevo.Enabled = false;
            btnServicioAdicionalEditar.Enabled = false;
            btnServicioAdicionalEliminar.Enabled = false;

            if (txtServicioAdicionalBusqueda != null) txtServicioAdicionalBusqueda.Enabled = false;
            if (txtServicioAdicionalPrecioMaximo != null) txtServicioAdicionalPrecioMaximo.Enabled = false;

            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.BloquearPanelPrincipal();
            }
        }

        private void DesactivarDatosServicio()
        {
            txtServicioAdicionalNombre.Enabled = false;
            txtServicioAdicionalPrecio.Enabled = false;

            btnServicioAdicionalConfirmar.Enabled = false;
            btnServicioAdicionalCancelar.Enabled = false;

            btnServicioAdicionalNuevo.Enabled = true;
            btnServicioAdicionalEditar.Enabled = true;
            btnServicioAdicionalEliminar.Enabled = true;

            if (txtServicioAdicionalBusqueda != null) txtServicioAdicionalBusqueda.Enabled = true;
            if (txtServicioAdicionalPrecioMaximo != null) txtServicioAdicionalPrecioMaximo.Enabled = true;

            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.ActivarPanelPrincipal();
            }
        }

        private void CargarGrillaServicios()
        {
            try
            {
                if (dgvServicioAdicionalDatos.Columns.Count == 0)
                {
                    ConfigurarGrillaServicios();
                }

                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los servicios adicionales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrillaServicios()
        {
            dgvServicioAdicionalDatos.ColumnHeadersVisible = true;
            dgvServicioAdicionalDatos.AutoGenerateColumns = false;
            dgvServicioAdicionalDatos.Columns.Clear();

            dgvServicioAdicionalDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicioAdicionalDatos.MultiSelect = false;
            dgvServicioAdicionalDatos.ReadOnly = true;
            dgvServicioAdicionalDatos.AllowUserToAddRows = false;
            dgvServicioAdicionalDatos.AllowUserToDeleteRows = false;
            dgvServicioAdicionalDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                FillWeight = 10
            };

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre del Servicio",
                DataPropertyName = "Nombre",
                FillWeight = 60
            };

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                FillWeight = 30,
                DefaultCellStyle = { Format = "C2" }
            };

            dgvServicioAdicionalDatos.Columns.Add(colId);
            dgvServicioAdicionalDatos.Columns.Add(colNombre);
            dgvServicioAdicionalDatos.Columns.Add(colPrecio);
        }

        private void LimpiarCampos()
        {
            txtServicioAdicionalId.Clear();
            txtServicioAdicionalNombre.Clear();
            txtServicioAdicionalPrecio.Clear();
        }

        private void btnServicioAdicionalNuevo_Click(object sender, EventArgs e)
        {
            _esEdicion = false;
            LimpiarCampos();
            ActivarDatosServicio();
            txtServicioAdicionalNombre.Focus();
        }

        private void btnServicioAdicionalEditar_Click(object sender, EventArgs e)
        {
            if (dgvServicioAdicionalDatos.CurrentRow == null || dgvServicioAdicionalDatos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _esEdicion = true;
            ActivarDatosServicio();

            if (dgvServicioAdicionalDatos.CurrentRow.DataBoundItem is ServicioAdicionalDto servicioSeleccionado)
            {
                txtServicioAdicionalId.Text = servicioSeleccionado.Id.ToString();
                txtServicioAdicionalNombre.Text = servicioSeleccionado.Nombre;
                txtServicioAdicionalPrecio.Text = servicioSeleccionado.Precio.ToString();

                txtServicioAdicionalNombre.Focus();
            }
        }

        private void btnServicioAdicionalEliminar_Click(object sender, EventArgs e)
        {
            if (dgvServicioAdicionalDatos.CurrentRow == null || dgvServicioAdicionalDatos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvServicioAdicionalDatos.CurrentRow.DataBoundItem is ServicioAdicionalDto servicioSeleccionado)
            {
                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el servicio adicional '{servicioSeleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string mensaje = _controller.EliminarServicioAdicional(servicioSeleccionado.Id);
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaServicios();
                    LimpiarCampos();
                }
            }
        }

        private void btnServicioAdicionalConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtServicioAdicionalNombre.Text))
                {
                    MessageBox.Show("El nombre del servicio adicional es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServicioAdicionalNombre.Focus();
                    return;
                }

                if (!decimal.TryParse(txtServicioAdicionalPrecio.Text, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServicioAdicionalPrecio.Focus();
                    return;
                }

                string respuesta;

                if (!_esEdicion)
                {
                    respuesta = _controller.CrearServicioAdicional(txtServicioAdicionalNombre.Text.Trim(), precio);
                }
                else
                {
                    if (!int.TryParse(txtServicioAdicionalId.Text, out int id))
                    {
                        MessageBox.Show("ID de servicio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    respuesta = _controller.ActualizarServicioAdicional(id, txtServicioAdicionalNombre.Text.Trim(), precio);
                }

                MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta.Contains("correctamente", StringComparison.OrdinalIgnoreCase))
                {
                    CargarGrillaServicios();
                    LimpiarCampos();
                    DesactivarDatosServicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServicioAdicionalCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DesactivarDatosServicio();
        }

        private void AplicarFiltros()
        {
            try
            {
                IEnumerable<ServicioAdicionalDto> listaServicios = _controller.ListarServiciosAdicionales();

                if (txtServicioAdicionalBusqueda != null && !string.IsNullOrWhiteSpace(txtServicioAdicionalBusqueda.Text))
                {
                    string textoBusqueda = txtServicioAdicionalBusqueda.Text.Trim().ToLower();
                    listaServicios = listaServicios.Where(s =>
                        !string.IsNullOrEmpty(s.Nombre) && s.Nombre.ToLower().Contains(textoBusqueda)
                    );
                }

                if (txtServicioAdicionalPrecioMaximo != null && !string.IsNullOrWhiteSpace(txtServicioAdicionalPrecioMaximo.Text))
                {
                    if (decimal.TryParse(txtServicioAdicionalPrecioMaximo.Text.Trim(), out decimal precioMaximo))
                    {
                        listaServicios = listaServicios.Where(s => s.Precio <= precioMaximo);
                    }
                }

                dgvServicioAdicionalDatos.DataSource = listaServicios.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar los filtros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvServicioAdicionalDatos.DataSource = new List<ServicioAdicionalDto>();
            }
        }

        private void txtServicioAdicionalBusqueda_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtServicioAdicionalPrecioMaximo_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void SeleccionarServicio(ServicioAdicionalDto servicioDto)
        {
            if (servicioDto == null) return;

            ServicioAdicional servicioModelo = new ServicioAdicional(
                servicioDto.Id,
                servicioDto.Nombre,
                servicioDto.Precio
            );

            ServicioSeleccionado = servicioModelo;

            if (this.Modal || this.Owner != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (Application.OpenForms["Principal"] is Principal formPrincipal)
                {
                    Presupuesto nuevoPresupuesto = new Presupuesto();
                    nuevoPresupuesto.ServiciosAdicionales.Add(servicioModelo);

                    FormPresupuestoGestion formGestion = new FormPresupuestoGestion(nuevoPresupuesto);
                    formPrincipal.AbrirGestionPresupuesto(formGestion);
                }
            }
        }

        private void dgvServicioAdicionalDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvServicioAdicionalDatos.Rows[e.RowIndex].DataBoundItem is ServicioAdicionalDto dto)
            {
                SeleccionarServicio(dto);
            }
        }

        private void BtServicioAgregarAlPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvServicioAdicionalDatos.CurrentRow != null && dgvServicioAdicionalDatos.CurrentRow.DataBoundItem is ServicioAdicionalDto dto)
            {
                SeleccionarServicio(dto);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}