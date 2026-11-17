using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormMenu : Form
    {
        private readonly MenuController _controller = new MenuController();
        private List<AptoMenuDto> _seleccionadosActuales = new List<AptoMenuDto>();
        private bool _esEdicion = false;

        // 👉 Propiedad pública para que el formulario padre (Presupuesto) recupere el ítem creado con su cantidad
        public ItemMenu? ItemMenuSeleccionado { get; private set; }

        public FormMenu()
        {
            InitializeComponent();
            ConfigurarFormularioInicial();
            CargarGrillaMenus();
        }

        private void ConfigurarFormularioInicial()
        {
            DesactivarDatosMenu();
            LimpiarCampos();

            if (chkBoxAdulto != null) chkBoxAdulto.Checked = true;
            if (chkBoxNino != null) chkBoxNino.Checked = true;
        }

        private void ActivarDatosMenu()
        {
            txtMenuNombre.Enabled = true;
            txtMenuDetalle.Enabled = true;
            textMenuPrecio.Enabled = true;
            textBoxMenuListaApto.Enabled = true;
            btnMenuAgregarAptoMenu.Enabled = true;
            radioBtnMenuAdulto.Enabled = true;
            radioBtnMenuNino.Enabled = true;
            txtBoxMenuPrecioMaximo.Enabled = false;
            chkBoxAdulto.Enabled = false;
            chkBoxNino.Enabled = false;

            btnMenuConfirmar.Enabled = true;
            btnMenuCancelar.Enabled = true;

            btnMenuNuevo.Enabled = false;
            btnMenuEditar.Enabled = false;
            btnMenuEliminar.Enabled = false;

            if (txtBoxBusquedaMenu != null) txtBoxBusquedaMenu.Enabled = false;

            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.BloquearPanelPrincipal();
            }
        }

        private void DesactivarDatosMenu()
        {
            txtMenuNombre.Enabled = false;
            txtMenuDetalle.Enabled = false;
            textMenuPrecio.Enabled = false;
            textBoxMenuListaApto.Enabled = false;
            btnMenuAgregarAptoMenu.Enabled = false;
            radioBtnMenuAdulto.Enabled = false;
            radioBtnMenuNino.Enabled = false;
            chkBoxAdulto.Enabled = true;
            chkBoxNino.Enabled = true;

            btnMenuConfirmar.Enabled = false;
            btnMenuCancelar.Enabled = false;

            btnMenuNuevo.Enabled = true;
            btnMenuEditar.Enabled = true;
            btnMenuEliminar.Enabled = true;
            txtBoxMenuPrecioMaximo.Enabled = true;


            if (txtBoxBusquedaMenu != null) txtBoxBusquedaMenu.Enabled = true;

            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.ActivarPanelPrincipal();
            }
        }

        private void CargarGrillaMenus()
        {
            try
            {
                if (dataGridViewMenu.Columns.Count == 0)
                {
                    ConfigurarGrillaMenus();
                }

                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los menús: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrillaMenus()
        {
            dataGridViewMenu.ColumnHeadersVisible = true;
            dataGridViewMenu.AutoGenerateColumns = false;
            dataGridViewMenu.Columns.Clear();

            dataGridViewMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenu.MultiSelect = false;
            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.AllowUserToDeleteRows = false;
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                FillWeight = 8
            };

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 15
            };

            DataGridViewTextBoxColumn colDetalle = new DataGridViewTextBoxColumn
            {
                Name = "Detalle",
                HeaderText = "Detalle",
                DataPropertyName = "Detalle",
                FillWeight = 40
            };

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                FillWeight = 12
            };

            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn
            {
                Name = "EsAdulto",
                HeaderText = "Tipo",
                DataPropertyName = "EsAdulto",
                FillWeight = 10
            };

            DataGridViewTextBoxColumn colAptos = new DataGridViewTextBoxColumn
            {
                Name = "AptosMenuTexto",
                HeaderText = "Aptos para:",
                DataPropertyName = "AptosMenuTexto",
                FillWeight = 15
            };

            dataGridViewMenu.Columns.Add(colId);
            dataGridViewMenu.Columns.Add(colNombre);
            dataGridViewMenu.Columns.Add(colDetalle);
            dataGridViewMenu.Columns.Add(colPrecio);
            dataGridViewMenu.Columns.Add(colTipo);
            dataGridViewMenu.Columns.Add(colAptos);
        }

        private void LimpiarCampos()
        {
            txtMenuId.Clear();
            txtMenuNombre.Clear();
            txtMenuDetalle.Clear();
            textMenuPrecio.Clear();
            textBoxMenuListaApto.Clear();
            radioBtnMenuAdulto.Checked = true; // Por defecto adulto
            _seleccionadosActuales.Clear();
        }

        private void btnMenuAgregarAptoMenu_Click(object sender, EventArgs e)
        {
            using (FormSelectorMenuApto popup = new FormSelectorMenuApto(_seleccionadosActuales))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    _seleccionadosActuales = popup.Seleccionados;
                    textBoxMenuListaApto.Text = string.Join(", ", _seleccionadosActuales.Select(s => s.Detalle));
                }
            }
        }

        private void btnMenuNuevo_Click(object sender, EventArgs e)
        {
            _esEdicion = false;
            LimpiarCampos();
            ActivarDatosMenu();
            txtMenuNombre.Focus();
        }

        private void btnMenuEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.CurrentRow == null || dataGridViewMenu.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione un menú de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _esEdicion = true;
            ActivarDatosMenu();

            if (dataGridViewMenu.CurrentRow.DataBoundItem is MenuDto menuSeleccionado)
            {
                txtMenuId.Text = menuSeleccionado.Id.ToString();
                txtMenuNombre.Text = menuSeleccionado.Nombre;
                txtMenuDetalle.Text = menuSeleccionado.Detalle;
                textMenuPrecio.Text = menuSeleccionado.Precio.ToString();

                if (menuSeleccionado.EsAdulto)
                    radioBtnMenuAdulto.Checked = true;
                else
                    radioBtnMenuNino.Checked = true;

                if (menuSeleccionado.AptosMenu != null)
                {
                    _seleccionadosActuales = menuSeleccionado.AptosMenu.Select(a => new AptoMenuDto { Id = a.Id, Detalle = a.Detalle }).ToList();
                    textBoxMenuListaApto.Text = string.Join(", ", _seleccionadosActuales.Select(s => s.Detalle));
                }

                txtMenuNombre.Focus();
            }
        }

        private void btnMenuEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.CurrentRow == null || dataGridViewMenu.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione un menú de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewMenu.CurrentRow.DataBoundItem is MenuDto menuSeleccionado)
            {
                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el menú '{menuSeleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string mensaje = _controller.EliminarMenu(menuSeleccionado.Id);
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaMenus();
                    LimpiarCampos();
                }
            }
        }

        private void btnMenuConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMenuNombre.Text))
                {
                    MessageBox.Show("El nombre del menú es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMenuNombre.Focus();
                    return;
                }

                if (!decimal.TryParse(textMenuPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textMenuPrecio.Focus();
                    return;
                }

                bool esAdulto = radioBtnMenuAdulto.Checked;
                string detalle = txtMenuDetalle.Text;

                List<Model.AptoMenu> listaAptos = _seleccionadosActuales.Select(s => new Model.AptoMenu
                {
                    Id = s.Id,
                    Detalle = s.Detalle
                }).ToList();

                string respuesta;

                if (!_esEdicion)
                {
                    respuesta = _controller.CrearMenu(txtMenuNombre.Text.Trim(), detalle, precio, esAdulto, listaAptos);
                }
                else
                {
                    if (!int.TryParse(txtMenuId.Text, out int id))
                    {
                        MessageBox.Show("ID de menú inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    respuesta = _controller.ActualizarMenu(id, txtMenuNombre.Text.Trim(), detalle, precio, esAdulto, listaAptos);
                }

                MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta.Contains("correctamente", StringComparison.OrdinalIgnoreCase))
                {
                    CargarGrillaMenus();
                    LimpiarCampos();
                    DesactivarDatosMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DesactivarDatosMenu();
        }

        
        private void dataGridViewMenu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewMenu.Rows[e.RowIndex].DataBoundItem is MenuDto menuSeleccionado)
            {
                using (FormDetalleMenu popupDetalle = new FormDetalleMenu(menuSeleccionado))
                {
                    if (popupDetalle.ShowDialog(this) == DialogResult.OK)
                    {
                        ItemMenuSeleccionado = popupDetalle.ItemMenuSeleccionado;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        // --- LÓGICA DE FILTRADO DINÁMICO ---
        private void AplicarFiltros()
        {
            try
            {
                IEnumerable<MenuDto> listaMenus = _controller.ListarMenus();

                if (txtBoxBusquedaMenu != null && !string.IsNullOrWhiteSpace(txtBoxBusquedaMenu.Text))
                {
                    string textoBusqueda = txtBoxBusquedaMenu.Text.Trim().ToLower();
                    listaMenus = listaMenus.Where(m =>
                        (!string.IsNullOrEmpty(m.Nombre) && m.Nombre.ToLower().Contains(textoBusqueda)) ||
                        (!string.IsNullOrEmpty(m.Detalle) && m.Detalle.ToLower().Contains(textoBusqueda)) ||
                        (!string.IsNullOrEmpty(m.AptosMenuTexto) && m.AptosMenuTexto.ToLower().Contains(textoBusqueda)) ||
                        (m.AptosMenu != null && m.AptosMenu.Any(a => a.Detalle != null && a.Detalle.ToLower().Contains(textoBusqueda)))
                    );
                }

                if (txtBoxMenuPrecioMaximo != null && !string.IsNullOrWhiteSpace(txtBoxMenuPrecioMaximo.Text))
                {
                    if (decimal.TryParse(txtBoxMenuPrecioMaximo.Text.Trim(), out decimal precioMaximo))
                    {
                        listaMenus = listaMenus.Where(m => m.Precio <= precioMaximo);
                    }
                }

                bool incluyeAdultos = chkBoxAdulto != null && chkBoxAdulto.Checked;
                bool incluyeNinos = chkBoxNino != null && chkBoxNino.Checked;

                // Filtro simplificado y limpio para los tipos de menú
                if (!incluyeAdultos && !incluyeNinos)
                {
                    listaMenus = Enumerable.Empty<MenuDto>();
                }
                else if (incluyeAdultos && !incluyeNinos)
                {
                    listaMenus = listaMenus.Where(m => m.EsAdulto);
                }
                else if (!incluyeAdultos && incluyeNinos)
                {
                    listaMenus = listaMenus.Where(m => !m.EsAdulto);
                }

                dataGridViewMenu.DataSource = listaMenus.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar los filtros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxMenuPrecioMaximo_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtBoxBusquedaMenu_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkBoxNino_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkBoxAduto_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}