using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormDetallePresupuesto : Form
    {
        private Presupuesto _presupuesto;

        public FormDetallePresupuesto(Presupuesto presupuesto)
        {
            InitializeComponent();
            _presupuesto = presupuesto;
            this.Load += new EventHandler(FormDetallePresupuesto_Load);
        }

        private void FormDetallePresupuesto_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtDetalle != null)
                {
                    txtDetalle.Font = new Font("Consolas", 10F, FontStyle.Regular);
                }

                if (_presupuesto != null)
                {
                    txtDetalle.Clear();
                    txtDetalle.AppendText("========================================" + Environment.NewLine);
                    txtDetalle.AppendText("     DETALLE DEL PRESUPUESTO #" + _presupuesto.Id + Environment.NewLine);
                    txtDetalle.AppendText("========================================" + Environment.NewLine);
                    txtDetalle.AppendText("Fecha Presupuesto: " + _presupuesto.FechaPresupuesto + Environment.NewLine);
                    txtDetalle.AppendText("Fecha Evento: " + _presupuesto.FechaEvento + Environment.NewLine);
                    txtDetalle.AppendText("Estado: " + _presupuesto.Estado + Environment.NewLine);
                    txtDetalle.AppendText("Duración: " + _presupuesto.Duracion + " horas" + Environment.NewLine);

                    string nombreCliente = _presupuesto.Cliente != null ? _presupuesto.Cliente.Nombre + " " + _presupuesto.Cliente.Apellido + " (DNI: " + _presupuesto.Cliente.Dni + ")" : "Sin cliente";
                    txtDetalle.AppendText("Cliente: " + nombreCliente + Environment.NewLine);

                    string nombreSalon = _presupuesto.Salon != null ? _presupuesto.Salon.Nombre + " - $" + _presupuesto.Salon.Precio : "Sin salón";
                    txtDetalle.AppendText("Salón: " + nombreSalon + Environment.NewLine);

                    txtDetalle.AppendText(Environment.NewLine + "--- ÍTEMS DE MENÚ ---" + Environment.NewLine);
                    if (_presupuesto.Menus != null)
                    {
                        foreach (ItemMenu item in _presupuesto.Menus)
                        {
                            string detalleMenu = item.Item != null ? item.Item.Detalle : "Menú sin detalle";

                            // Determinamos si es Adulto o Niño utilizando la propiedad EsAdulto del menú
                            string tipoMenu = "Desconocido";
                            if (item.Item != null)
                            {
                                tipoMenu = item.Item.EsAdulto ? "[Adulto]" : "[Niño]";
                            }

                            string parteIzquierda = "- " + item.Cantidad + "x " + detalleMenu + " " + tipoMenu;
                            string parteDerecha = "$" + item.CalcularSubtotal();
                            txtDetalle.AppendText(parteIzquierda.PadRight(38) + parteDerecha.PadLeft(12) + Environment.NewLine);
                        }
                    }

                    txtDetalle.AppendText(Environment.NewLine + "--- SERVICIOS ADICIONALES ---" + Environment.NewLine);
                    if (_presupuesto.ServiciosAdicionales != null)
                    {
                        foreach (ServicioAdicional servicio in _presupuesto.ServiciosAdicionales)
                        {
                            string parteIzquierda = "- " + servicio.Nombre;
                            string parteDerecha = "$" + servicio.Precio;
                            txtDetalle.AppendText(parteIzquierda.PadRight(38) + parteDerecha.PadLeft(12) + Environment.NewLine);
                        }
                    }

                    txtDetalle.AppendText("----------------------------------------" + Environment.NewLine);
                    string totalTexto = "TOTAL GENERAL: ";
                    string totalMonto = "$" + _presupuesto.CalcularTotal();
                    txtDetalle.AppendText(totalTexto.PadRight(38) + totalMonto.PadLeft(12) + Environment.NewLine);
                }
                else
                {
                    txtDetalle.Text = "El objeto presupuesto recibido es nulo.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarPdf_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_presupuesto == null)
                {
                    MessageBox.Show("No hay datos de presupuesto para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PdfExportService exportador = new PdfExportService();
                exportador.ExportarPresupuestoAPdf(_presupuesto);
                MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPresupuestoEliminar_Click(object sender, EventArgs e)
        {
            if (_presupuesto == null)
            {
                MessageBox.Show("No hay presupuesto seleccionado para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el presupuesto #{_presupuesto.Id}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    PresupuestoService presupuestoService = new PresupuestoService();
                    bool eliminado = presupuestoService.EliminarPresupuesto(_presupuesto.Id);

                    if (eliminado)
                    {
                        MessageBox.Show("Presupuesto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar o eliminar el presupuesto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el presupuesto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPresupuestoClonar_Click(object sender, EventArgs e)
        {
            if (_presupuesto == null)
            {
                MessageBox.Show("No hay presupuesto seleccionado para clonar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ItemMenu> menusClonados = new List<ItemMenu>();
            if (_presupuesto.Menus != null)
            {
                foreach (ItemMenu itemOriginal in _presupuesto.Menus)
                {
                    ItemMenu itemClon = new ItemMenu
                    {
                        Id = 0,
                        Cantidad = itemOriginal.Cantidad,
                        Item = itemOriginal.Item
                    };
                    menusClonados.Add(itemClon);
                }
            }

            List<ServicioAdicional> serviciosClonados = new List<ServicioAdicional>();
            if (_presupuesto.ServiciosAdicionales != null)
            {
                foreach (ServicioAdicional servicioOriginal in _presupuesto.ServiciosAdicionales)
                {
                    serviciosClonados.Add(servicioOriginal);
                }
            }

            Presupuesto presupuestoClonado = new Presupuesto
            {
                Id = 0,
                FechaPresupuesto = DateOnly.FromDateTime(DateTime.Today),
                FechaEvento = _presupuesto.FechaEvento,
                Duracion = _presupuesto.Duracion,
                Estado = Estado.PREPARACION,
                Cliente = _presupuesto.Cliente,
                Salon = _presupuesto.Salon,
                Menus = menusClonados,
                ServiciosAdicionales = serviciosClonados
            };

            Principal formPrincipal = Application.OpenForms["Principal"] as Principal;
            if (formPrincipal != null)
            {
                FormPresupuestoGestion formGestion = new FormPresupuestoGestion(presupuestoClonado);
                formPrincipal.AbrirGestionPresupuesto(formGestion);
                this.Close();
            }
        }

        private void btnPresupuestoEditar_Click(object sender, EventArgs e)
        {
            if (_presupuesto == null)
            {
                MessageBox.Show("No hay presupuesto seleccionado para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Principal formPrincipal = Application.OpenForms["Principal"] as Principal;
            if (formPrincipal != null)
            {
                FormPresupuestoGestion formGestion = new FormPresupuestoGestion(_presupuesto);
                formPrincipal.AbrirGestionPresupuesto(formGestion);
                this.Close();
            }
        }
    }
}