using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class PantallaCliente : Form
    {
        private readonly ClienteController _controller;

        public Cliente ClienteSeleccionado { get; private set; }

        private string _ultimaColumnaOrdenada = "";
        private bool _ordenAscendente = true;

        public PantallaCliente()
        {
            InitializeComponent();
            _controller = new ClienteController();

            dataGridViewClientes.ColumnHeaderMouseClick += dataGridViewClientes_ColumnHeaderMouseClick;
            dataGridViewClientes.CellDoubleClick += dataGridViewClientes_CellDoubleClick;
        }

        private void LimpiarCamposCliente()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNotas.Clear();
        }
        private void BloquearPanelPrincipal()
        {
            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.BloquearPanelPrincipal();
            }
        }

        private void DesbloquearPanelPrincipal()
        {
            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.ActivarPanelPrincipal();
            }
        }
        private void ActivarDatosCliente()
        {
            groupBoxDetalle.Enabled = true;
            btnClienteEditar.Enabled = false;
            btnClienteNuevo.Enabled = false;
            btnClienteEliminar.Enabled = false;
            txtBoxBusquedaCliente.Enabled = false;
            BtClienteSeleccionar.Visible = false;
            dataGridViewClientes.Enabled = false;
            this.AcceptButton = btnConfirmarCliente;

            BloquearPanelPrincipal();
        }

        private void DesactivarDatosCliente()
        {
            groupBoxDetalle.Enabled = false;
            btnClienteEditar.Enabled = true;
            btnClienteNuevo.Enabled = true;
            btnClienteEliminar.Enabled = true;
            txtBoxBusquedaCliente.Enabled = true;
            BtClienteSeleccionar.Visible = true;
            dataGridViewClientes.Enabled = true;

            DesbloquearPanelPrincipal();

        }

        private void PantallaCliente_Load(object sender, EventArgs e)
        {
            RefrescarClientes();
        }

        private void ConfigurarFormatoColumnas()
        {
            if (dataGridViewClientes.Columns.Count == 0) return;

            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.EnableHeadersVisualStyles = false;

            Color colorFondoEncabezado = Color.FromArgb(240, 255, 248);

            dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = colorFondoEncabezado;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorFondoEncabezado;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            dataGridViewClientes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dataGridViewClientes.Columns["Id"] != null)
            {
                dataGridViewClientes.Columns["Id"].HeaderText = "ID";
                dataGridViewClientes.Columns["Id"].FillWeight = 8;
            }

            if (dataGridViewClientes.Columns["Nombre"] != null)
            {
                dataGridViewClientes.Columns["Nombre"].HeaderText = "Nombre";
                dataGridViewClientes.Columns["Nombre"].FillWeight = 15;
            }

            if (dataGridViewClientes.Columns["Apellido"] != null)
            {
                dataGridViewClientes.Columns["Apellido"].HeaderText = "Apellido";
                dataGridViewClientes.Columns["Apellido"].FillWeight = 15;
            }

            if (dataGridViewClientes.Columns["Dni"] != null)
            {
                dataGridViewClientes.Columns["Dni"].HeaderText = "DNI";
                dataGridViewClientes.Columns["Dni"].FillWeight = 12;
            }

            if (dataGridViewClientes.Columns["Telefono"] != null)
            {
                dataGridViewClientes.Columns["Telefono"].HeaderText = "Teléfono";
                dataGridViewClientes.Columns["Telefono"].FillWeight = 14;
            }

            if (dataGridViewClientes.Columns["Email"] != null)
            {
                dataGridViewClientes.Columns["Email"].HeaderText = "Email";
                dataGridViewClientes.Columns["Email"].FillWeight = 20;
            }

            if (dataGridViewClientes.Columns["Notas"] != null)
            {
                dataGridViewClientes.Columns["Notas"].HeaderText = "Notas";
                dataGridViewClientes.Columns["Notas"].FillWeight = 16;
            }
        }

        private void RefrescarClientes()
        {
            string criterio = txtBoxBusquedaCliente.Text.ToLower();

            List<ClienteDto> clientes = _controller.ListarClientes().ToList();

            List<ClienteDto> filtrados = clientes.Where(c =>
                (c.Nombre != null && c.Nombre.ToLower().Contains(criterio)) ||
                (c.Apellido != null && c.Apellido.ToLower().Contains(criterio)) ||
                (c.Dni != null && c.Dni.ToLower().Contains(criterio)) ||
                (c.Email != null && c.Email.ToLower().Contains(criterio))
            ).ToList();

            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Rows.Clear();
            dataGridViewClientes.Refresh();
            dataGridViewClientes.DataSource = filtrados;

            ConfigurarFormatoColumnas();
        }

        private void dataGridViewClientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string criterio = txtBoxBusquedaCliente.Text.ToLower();

            List<ClienteDto> clientes = _controller.ListarClientes().ToList();

            List<ClienteDto> listaFiltrada = clientes.Where(c =>
                (c.Nombre != null && c.Nombre.ToLower().Contains(criterio)) ||
                (c.Apellido != null && c.Apellido.ToLower().Contains(criterio)) ||
                (c.Dni != null && c.Dni.ToLower().Contains(criterio)) ||
                (c.Email != null && c.Email.ToLower().Contains(criterio))
            ).ToList();

            if (listaFiltrada.Count > 0)
            {
                string nombrePropiedad = dataGridViewClientes.Columns[e.ColumnIndex].DataPropertyName;

                if (_ultimaColumnaOrdenada == nombrePropiedad)
                {
                    _ordenAscendente = !_ordenAscendente;
                }
                else
                {
                    _ultimaColumnaOrdenada = nombrePropiedad;
                    _ordenAscendente = true;
                }

                System.Reflection.PropertyInfo propiedad = typeof(ClienteDto).GetProperty(nombrePropiedad);

                if (propiedad != null)
                {
                    listaFiltrada = _ordenAscendente
                        ? listaFiltrada.OrderBy(x => propiedad.GetValue(x, null)).ToList()
                        : listaFiltrada.OrderByDescending(x => propiedad.GetValue(x, null)).ToList();
                }

                dataGridViewClientes.DataSource = null;
                dataGridViewClientes.DataSource = listaFiltrada;
                ConfigurarFormatoColumnas();

                foreach (DataGridViewColumn col in dataGridViewClientes.Columns)
                {
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;
                }

                dataGridViewClientes.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection =
                    _ordenAscendente ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDto clienteDto = new ClienteDto();
                clienteDto.Nombre = txtNombre.Text;
                clienteDto.Dni = txtDni.Text;
                clienteDto.Email = txtEmail.Text;

                _controller.CrearCliente(clienteDto);

                MessageBox.Show("Cliente creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarClientes();
                LimpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            ActivarDatosCliente();
            txtNombre.Focus();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCamposCliente();
            DesactivarDatosCliente();
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    _controller.CrearCliente(
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text,
                        txtDni.Text,
                        txtEmail.Text,
                        txtNotas.Text
                    );
                    MessageBox.Show("Cliente creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id = int.Parse(txtId.Text);
                    _controller.ActualizarCliente(
                        id,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text,
                        txtDni.Text,
                        txtEmail.Text,
                        txtNotas.Text
                    );
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCamposCliente();
                RefrescarClientes();
                DesactivarDatosCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClienteEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClientes.CurrentRow != null)
                {
                    string dniCliente = dataGridViewClientes.CurrentRow.Cells["Dni"].Value?.ToString() ?? "";
                    string nombreCliente = dataGridViewClientes.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
                    string apellidoCliente = dataGridViewClientes.CurrentRow.Cells["Apellido"].Value?.ToString() ?? "";

                    DialogResult confirmacion = MessageBox.Show(
                        $"¿Está seguro que desea eliminar al cliente {nombreCliente} {apellidoCliente} con DNI {dniCliente}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        int idCliente = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["Id"].Value);
                        _controller.EliminarCliente(idCliente);

                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarClientes();
                        LimpiarCamposCliente();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente en la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string mensajeDetallado = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error al eliminar cliente: {mensajeDetallado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            RefrescarClientes();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // ==========================================
        // MÉTODO REUTILIZABLE DE SELECCIÓN
        // ==========================================
        private void SeleccionarCliente(ClienteDto clienteDto)
        {
            if (clienteDto == null) return;

            Cliente clienteModelo = new Cliente
            {
                Id = clienteDto.Id,
                Nombre = clienteDto.Nombre,
                Apellido = clienteDto.Apellido,
                Dni = clienteDto.Dni,
                Telefono = clienteDto.Telefono,
                Email = clienteDto.Email,
                Notas = clienteDto.Notas
            };

            if (this.Modal || this.Owner != null)
            {
                ClienteSeleccionado = clienteModelo;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (Application.OpenForms["Principal"] is Principal formPrincipal)
                {
                    FormPresupuestoGestion formPresupuesto = new FormPresupuestoGestion(clienteModelo);
                    formPrincipal.AbrirGestionPresupuesto(formPresupuesto);
                }
            }
        }

        // Evento del Botón (usa la fila actual seleccionada)
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null && dataGridViewClientes.CurrentRow.DataBoundItem is ClienteDto clienteDto)
            {
                BloquearPanelPrincipal();
                SeleccionarCliente(clienteDto);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClienteEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClientes.CurrentRow != null)
                {
                    ActivarDatosCliente();

                    txtId.Text = dataGridViewClientes.CurrentRow.Cells["Id"].Value?.ToString();
                    txtNombre.Text = dataGridViewClientes.CurrentRow.Cells["Nombre"].Value?.ToString();
                    txtApellido.Text = dataGridViewClientes.CurrentRow.Cells["Apellido"].Value?.ToString();
                    txtDni.Text = dataGridViewClientes.CurrentRow.Cells["Dni"].Value?.ToString();
                    txtTelefono.Text = dataGridViewClientes.CurrentRow.Cells["Telefono"].Value?.ToString();
                    txtEmail.Text = dataGridViewClientes.CurrentRow.Cells["Email"].Value?.ToString();
                    txtNotas.Text = dataGridViewClientes.CurrentRow.Cells["Notas"].Value?.ToString();

                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "Por favor, seleccione un cliente en la lista para editar.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar cliente para edición: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewClientes.Rows[e.RowIndex].DataBoundItem is ClienteDto clienteDto)
            {
                BloquearPanelPrincipal();
                SeleccionarCliente(clienteDto);
            }
        }


    }
}