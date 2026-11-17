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
    public partial class FormSalon : Form
    {
        private readonly SalonController _controller = new SalonController();
        private bool _esNuevo = true;

        public SalonDto SalonSeleccionado { get; private set; }

        private string _ultimaColumnaOrdenada = "";
        private bool _ordenAscendente = true;

        public FormSalon()
        {
            InitializeComponent();

            dataGridViewSalones.ColumnHeaderMouseClick += dataGridViewSalones_ColumnHeaderMouseClick;
            dataGridViewSalones.CellDoubleClick += dataGridViewSalones_CellDoubleClick;
            dataGridViewSalones.CellClick += dataGridViewSalones_CellClick;

            DesactivarDatosSalones();
            CargarGrilla();
        }

        private void LimpiarCamposSalones()
        {
            txtIdSalon.Clear();
            txtNombreSalon.Clear();
            txtDireccionSalon.Clear();
            txtCapacidadSalon.Clear();
            textLocalidadSalon.Clear();
            textPrecioSalon.Clear();
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

        private void ActivarDatosSalones()
        {
            groupBoxDetalle.Enabled = true;
            btnSalonEditar.Enabled = false;
            btnSalonNuevo.Enabled = false;
            btnSalonEliminar.Enabled = false;
            txtBoxFiltroCapacidad.Enabled = false;
            txtBoxFiltroPrecio.Enabled = false;
            btnSalonAsignarPresupuesto.Visible = false;
            dataGridViewSalones.Enabled = false;
            this.AcceptButton = btnConfirmarSalon;

            BloquearPanelPrincipal();
        }

        private void DesactivarDatosSalones()
        {
            groupBoxDetalle.Enabled = false;
            btnSalonEditar.Enabled = true;
            btnSalonNuevo.Enabled = true;
            btnSalonEliminar.Enabled = true;
            txtBoxFiltroCapacidad.Enabled = true;
            txtBoxFiltroPrecio.Enabled = true;
            btnSalonAsignarPresupuesto.Visible = true;
            dataGridViewSalones.Enabled = true;

            DesbloquearPanelPrincipal();
        }

        private void CargarGrilla()
        {
            IEnumerable<SalonDto> listaSalones = _controller.ListarSalones();

            dataGridViewSalones.DataSource = null;
            dataGridViewSalones.DataSource = listaSalones.ToList();

            ConfigurarFormatoColumnas();
        }

        private void ConfigurarFormatoColumnas()
        {
            if (dataGridViewSalones.Columns.Count == 0) return;

            dataGridViewSalones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSalones.EnableHeadersVisualStyles = false;

            Color colorFondoEncabezado = Color.AliceBlue;

            dataGridViewSalones.ColumnHeadersDefaultCellStyle.BackColor = colorFondoEncabezado;
            dataGridViewSalones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridViewSalones.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorFondoEncabezado;
            dataGridViewSalones.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridViewSalones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            dataGridViewSalones.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSalones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dataGridViewSalones.Columns["Id"] != null)
            {
                dataGridViewSalones.Columns["Id"].HeaderText = "ID";
                dataGridViewSalones.Columns["Id"].FillWeight = 7;
            }

            if (dataGridViewSalones.Columns["Nombre"] != null)
            {
                dataGridViewSalones.Columns["Nombre"].HeaderText = "Nombre del Salón";
                dataGridViewSalones.Columns["Nombre"].FillWeight = 20;
            }

            if (dataGridViewSalones.Columns["Direccion"] != null)
            {
                dataGridViewSalones.Columns["Direccion"].HeaderText = "Dirección";
                dataGridViewSalones.Columns["Direccion"].FillWeight = 35;
            }

            if (dataGridViewSalones.Columns["Capacidad"] != null)
            {
                dataGridViewSalones.Columns["Capacidad"].HeaderText = "Capacidad";
                dataGridViewSalones.Columns["Capacidad"].FillWeight = 12;
            }
            if (dataGridViewSalones.Columns["Localidad"] != null)
            {
                dataGridViewSalones.Columns["Localidad"].HeaderText = "Localidad";
                dataGridViewSalones.Columns["Localidad"].FillWeight = 18;
            }
            if (dataGridViewSalones.Columns["Precio"] != null)
            {
                dataGridViewSalones.Columns["Precio"].HeaderText = "Precio ($)";
                dataGridViewSalones.Columns["Precio"].FillWeight = 15;
                dataGridViewSalones.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dataGridViewSalones.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewSalones.Columns["Precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                dataGridViewSalones.Columns["Precio"].HeaderCell.Style.SelectionBackColor = colorFondoEncabezado;
                dataGridViewSalones.Columns["Precio"].HeaderCell.Style.SelectionForeColor = Color.Black;
            }
        }

        private void dataGridViewSalones_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewSalones.DataSource is List<SalonDto> listaSalones && listaSalones.Count > 0)
            {
                string nombrePropiedad = dataGridViewSalones.Columns[e.ColumnIndex].DataPropertyName;

                if (_ultimaColumnaOrdenada == nombrePropiedad)
                    _ordenAscendente = !_ordenAscendente;
                else
                {
                    _ultimaColumnaOrdenada = nombrePropiedad;
                    _ordenAscendente = true;
                }

                System.Reflection.PropertyInfo propiedad = typeof(SalonDto).GetProperty(nombrePropiedad);
                if (propiedad != null)
                {
                    listaSalones = _ordenAscendente
                        ? listaSalones.OrderBy(x => propiedad.GetValue(x, null)).ToList()
                        : listaSalones.OrderByDescending(x => propiedad.GetValue(x, null)).ToList();
                }

                dataGridViewSalones.DataSource = null;
                dataGridViewSalones.DataSource = listaSalones;
                ConfigurarFormatoColumnas();

                foreach (DataGridViewColumn col in dataGridViewSalones.Columns)
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;

                dataGridViewSalones.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection =
                    _ordenAscendente ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void btnSalonNuevo_Click(object sender, EventArgs e)
        {
            _esNuevo = true;
            LimpiarCamposSalones();
            ActivarDatosSalones();
            txtNombreSalon.Focus();
        }

        private void btnSalonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalones.CurrentRow != null && dataGridViewSalones.CurrentRow.DataBoundItem is SalonDto dto)
            {
                txtIdSalon.Text = dto.Id.ToString();
                txtNombreSalon.Text = dto.Nombre;
                txtDireccionSalon.Text = dto.Direccion;
                txtCapacidadSalon.Text = dto.Capacidad.ToString();
                textLocalidadSalon.Text = dto.Localidad;
                textPrecioSalon.Text = dto.Precio.ToString();

                _esNuevo = false;
                ActivarDatosSalones();
                txtNombreSalon.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un salón de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string EjecutarActualizacion(SalonDto dto)
        {
            dto.Id = int.Parse(txtIdSalon.Text);
            return _controller.ActualizarSalon(dto);
        }

        private void btnCancelarSalon_Click(object sender, EventArgs e)
        {
            LimpiarCamposSalones();
            DesactivarDatosSalones();
        }

        private void dataGridViewSalones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewSalones.Rows[e.RowIndex].DataBoundItem is SalonDto dto)
            {
                txtIdSalon.Text = dto.Id.ToString();
                txtNombreSalon.Text = dto.Nombre;
                txtDireccionSalon.Text = dto.Direccion;
                txtCapacidadSalon.Text = dto.Capacidad.ToString();
                textLocalidadSalon.Text = dto.Localidad;
                textPrecioSalon.Text = dto.Precio.ToString();
            }
        }

        private void SeleccionarSalon(SalonDto salonDto)
        {
            if (salonDto == null) return;

            Salon salonModelo = new Salon(
                salonDto.Nombre,
                salonDto.Direccion,
                salonDto.Localidad,
                salonDto.Capacidad,
                salonDto.Precio
            );
            salonModelo.Id = salonDto.Id;

            if (this.Modal || this.Owner != null)
            {
                SalonSeleccionado = salonDto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (Application.OpenForms["Principal"] is Principal formPrincipal)
                {
                    FormPresupuestoGestion formPresupuesto = new FormPresupuestoGestion(salonModelo);
                    formPrincipal.AbrirGestionPresupuesto(formPresupuesto);
                }
            }
        }

        private void dataGridViewSalones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewSalones.Rows[e.RowIndex].DataBoundItem is SalonDto salonDto)
            {
                BloquearPanelPrincipal();
                SeleccionarSalon(salonDto);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalones.CurrentRow != null && dataGridViewSalones.CurrentRow.DataBoundItem is SalonDto salonDto)
            {
                BloquearPanelPrincipal();
                SeleccionarSalon(salonDto);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un salón de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBoxFiltroCapacidad_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            List<SalonDto> todosLosSalones = _controller.ListarSalones()?.ToList() ?? new List<SalonDto>();

            string textoCapacidad = txtBoxFiltroCapacidad.Text.Trim();
            string textoPrecio = txtBoxFiltroPrecio.Text.Trim();

            bool tieneCapacidad = int.TryParse(textoCapacidad, out int capacidadMinima);

            string textoPrecioLimpio = textoPrecio.Replace(".", "").Replace("$", "").Trim();
            bool tienePrecio = decimal.TryParse(textoPrecioLimpio, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal precioMaximo);

            List<SalonDto> salonesFiltrados = todosLosSalones.Where(s =>
                (string.IsNullOrEmpty(textoCapacidad) || (tieneCapacidad && s.Capacidad >= capacidadMinima)) &&
                (string.IsNullOrEmpty(textoPrecio) || (tienePrecio && s.Precio <= precioMaximo))
            ).ToList();

            if (!string.IsNullOrEmpty(_ultimaColumnaOrdenada))
            {
                System.Reflection.PropertyInfo propiedad = typeof(SalonDto).GetProperty(_ultimaColumnaOrdenada);
                if (propiedad != null)
                {
                    salonesFiltrados = _ordenAscendente
                        ? salonesFiltrados.OrderBy(x => propiedad.GetValue(x, null)).ToList()
                        : salonesFiltrados.OrderByDescending(x => propiedad.GetValue(x, null)).ToList();
                }
            }

            dataGridViewSalones.DataSource = null;
            dataGridViewSalones.DataSource = salonesFiltrados;
            ConfigurarFormatoColumnas();
        }

        private void txtBoxFiltroPrecio_TextChanged_1(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnConfirmarSalon_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCapacidadSalon.Text, out int capacidad))
            {
                MessageBox.Show("La capacidad debe ser un número entero válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrecioSalon.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SalonDto dto = new SalonDto
            {
                Nombre = txtNombreSalon.Text,
                Direccion = txtDireccionSalon.Text,
                Localidad = textLocalidadSalon.Text,
                Capacidad = capacidad,
                Precio = precio
            };

            string mensaje = _esNuevo ? _controller.CrearSalon(dto) : EjecutarActualizacion(dto);

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje.Contains("correctamente"))
            {
                LimpiarCamposSalones();
                DesactivarDatosSalones();
                CargarGrilla();
            }
        }

        private void btnSalonEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSalones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un salón de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este salón?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                int idSalon = Convert.ToInt32(dataGridViewSalones.CurrentRow.Cells["Id"].Value);
                string mensaje = _controller.EliminarSalon(idSalon);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposSalones();
                CargarGrilla();
            }
        }

        private void dataGridViewSalones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}