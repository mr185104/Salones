using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormPresupuestoGestion : Form
    {
        private readonly PresupuestoController _controller;
        private Presupuesto _presupuestoActual;
        private bool _esEdicion;

        public FormPresupuestoGestion()
        {
            InitializeComponent();
            _controller = new PresupuestoController();
            _presupuestoActual = new Presupuesto();
            _esEdicion = false;

            this.FormClosed += FormPresupuestoGestion_FormClosed;
            this.Activated += FormPresupuestoGestion_Activated;
        }

        public FormPresupuestoGestion(int presupuestoId) : this()
        {
            _esEdicion = true;

            Presupuesto presupuestoEncontrado = _controller.BuscarModeloPresupuestoPorId(presupuestoId);

            if (presupuestoEncontrado != null)
            {
                _presupuestoActual = presupuestoEncontrado;
            }
            else
            {
                MessageBox.Show("No se encontró el presupuesto seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Constructor para Editar o Clonar recibiendo el objeto completo
        public FormPresupuestoGestion(Presupuesto presupuestoExistente) : this()
        {
            if (presupuestoExistente != null)
            {
                _presupuestoActual = presupuestoExistente;
                _esEdicion = (_presupuestoActual.Id > 0);
            }
        }

        public FormPresupuestoGestion(Cliente clientePreseleccionado) : this()
        {
            AsignarCliente(clientePreseleccionado);
        }

        public FormPresupuestoGestion(Salon salonPreseleccionado) : this()
        {
            AsignarSalon(salonPreseleccionado);
        }

        private void FormPresupuestoGestion_Load(object sender, EventArgs e)
        {
            CargarComboBoxEstado();
            CargarGrillaMenusPresupuesto();
            CargarDatosEnPantalla();
        }

        private void FormPresupuestoGestion_Activated(object sender, EventArgs e)
        {
            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.BloquearPanelPrincipal();
            }
        }

        private void FormPresupuestoGestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Principal"] is Principal formPrincipal)
            {
                formPrincipal.ActivarPanelPrincipal();
            }
        }

        private void CargarComboBoxEstado()
        {
            cbboxPresupuestoEstado.DataSource = Enum.GetValues(typeof(Estado));
        }

        private void CargarGrillaMenusPresupuesto()
        {
            if (dtaGridItemsMenuServicios.Columns.Count == 0)
            {
                dtaGridItemsMenuServicios.ColumnHeadersVisible = true;
                dtaGridItemsMenuServicios.AutoGenerateColumns = false;
                dtaGridItemsMenuServicios.Columns.Clear();

                dtaGridItemsMenuServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtaGridItemsMenuServicios.MultiSelect = false;
                dtaGridItemsMenuServicios.ReadOnly = true;
                dtaGridItemsMenuServicios.AllowUserToAddRows = false;
                dtaGridItemsMenuServicios.AllowUserToDeleteRows = false;
                dtaGridItemsMenuServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtaGridItemsMenuServicios.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Ítem / Servicio", DataPropertyName = "Nombre", FillWeight = 35 });
                dtaGridItemsMenuServicios.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tipo", HeaderText = "Tipo", DataPropertyName = "Tipo", FillWeight = 15 });
                dtaGridItemsMenuServicios.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", HeaderText = "Cant.", DataPropertyName = "Cantidad", FillWeight = 12 });
                dtaGridItemsMenuServicios.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioUnitario", HeaderText = "Precio Unit.", DataPropertyName = "PrecioUnitario", FillWeight = 18, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
                dtaGridItemsMenuServicios.Columns.Add(new DataGridViewTextBoxColumn { Name = "Subtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal", FillWeight = 20, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            }

            if (_presupuestoActual.Menus == null)
            {
                _presupuestoActual.Menus = new List<ItemMenu>();
            }

            if (_presupuestoActual.ServiciosAdicionales == null)
            {
                _presupuestoActual.ServiciosAdicionales = new List<ServicioAdicional>();
            }

            List<ItemPresupuestoViewDto> listaMenus = new List<ItemPresupuestoViewDto>();
            foreach (ItemMenu im in _presupuestoActual.Menus)
            {
                ItemPresupuestoViewDto dto = new ItemPresupuestoViewDto
                {
                    Nombre = im.Item != null ? im.Item.Nombre : "Sin nombre",
                    Tipo = im.Item != null && im.Item.EsAdulto ? "Menú Adulto" : "Menú Infantil",
                    Cantidad = im.Cantidad,
                    PrecioUnitario = im.Item != null ? im.Item.Precio : 0m,
                    Subtotal = im.CalcularSubtotal()
                };
                listaMenus.Add(dto);
            }

            List<ItemPresupuestoViewDto> listaServicios = new List<ItemPresupuestoViewDto>();
            foreach (ServicioAdicional sa in _presupuestoActual.ServiciosAdicionales)
            {
                ItemPresupuestoViewDto dto = new ItemPresupuestoViewDto
                {
                    Nombre = sa.Nombre ?? "Sin nombre",
                    Tipo = "Servicio Adicional",
                    Cantidad = 1,
                    PrecioUnitario = sa.Precio,
                    Subtotal = sa.Precio
                };
                listaServicios.Add(dto);
            }

            List<ItemPresupuestoViewDto> dataSource = new List<ItemPresupuestoViewDto>();
            dataSource.AddRange(listaMenus);
            dataSource.AddRange(listaServicios);

            dtaGridItemsMenuServicios.DataSource = null;
            dtaGridItemsMenuServicios.DataSource = dataSource;
        }

        private void CargarDatosEnPantalla()
        {
            lblPresupuestoNumeroAsignado.Text = _presupuestoActual.Id == 0 ? "Sin Asignar" : _presupuestoActual.Id.ToString("D5");
            string textoTitulo = _presupuestoActual.Id == 0 ? "** Nuevo Presupuesto **" : "Presupuesto";
            gBoxPresupuesto.Text = textoTitulo;

            // 1. Aplicamos el color al GroupBox (esto pintará el título)
            if (_presupuestoActual.Id == 0)
            {
                gBoxPresupuesto.ForeColor = Color.Red;
            }
            else
            {
                gBoxPresupuesto.ForeColor = Color.Black;
            }

            // 2. Recorremos los controles hijos para asegurarnos de que mantengan su color normal (ej. Negro)
            foreach (Control hijo in gBoxPresupuesto.Controls)
            {
                hijo.ForeColor = Color.Black;
            }

            if (cbboxPresupuestoEstado.Items.Contains(_presupuestoActual.Estado))
            {
                cbboxPresupuestoEstado.SelectedItem = _presupuestoActual.Estado;
            }

            if (_presupuestoActual.Duracion > 0)
            {
                txtBoxPresupuestoCantidadHoras.Text = _presupuestoActual.Duracion.ToString();
            }

            if (_presupuestoActual.Salon != null)
            {
                AsignarSalon(_presupuestoActual.Salon);
            }

            dateTimePickPresupuestoFecha.Value = _presupuestoActual.FechaPresupuesto.ToDateTime(TimeOnly.MinValue);
            dateTimePickPresupuestoEvento.Value = _presupuestoActual.FechaEvento.ToDateTime(TimeOnly.MinValue);

            if (_presupuestoActual.Cliente != null)
            {
                AsignarCliente(_presupuestoActual.Cliente);
            }

            CargarGrillaMenusPresupuesto();
            ActualizarResumenVisual();
        }

        private void ActualizarResumenVisual()
        {
            try
            {
                if (int.TryParse(txtBoxPresupuestoCantidadHoras.Text, out int horas))
                {
                    _presupuestoActual.Duracion = horas;
                }
            }
            catch
            {
                // El modelo maneja el control de rango de horas
            }

            lblPresupuestoTotalMonto.Text = "$" + _presupuestoActual.CalcularTotal().ToString("N2");
            lblPresupuestoTotalInvitados.Text = _presupuestoActual.CalcularTotalInvitados().ToString();
        }

        private void cbboxPresupuestoEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxPresupuestoEstado.SelectedItem is Estado estadoSeleccionado)
            {
                _presupuestoActual.Estado = estadoSeleccionado;
            }
        }

        private void txtBoxPresupuestoCantidadHoras_TextChanged(object sender, EventArgs e)
        {
            ActualizarResumenVisual();
        }

        private void btnPresupuestoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que quiere salir sin guardar los cambios?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                if (Application.OpenForms["Principal"] is Principal formPrincipal)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();

                    formPrincipal.CargarFormularioEnPanel(new FormPresupuesto());
                }
            }
        }

        private void btnPresupuestoGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBoxPresupuestoCantidadHoras.Text, out int horas))
                {
                    MessageBox.Show(
                        "Ingrese una cantidad de horas válida.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtBoxPresupuestoCantidadHoras.Focus();
                    return;
                }

                if (_presupuestoActual.Salon == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un salón.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int totalInvitados = _presupuestoActual.CalcularTotalInvitados();

                if (totalInvitados > _presupuestoActual.Salon.Capacidad)
                {
                    MessageBox.Show(
                        $"La cantidad total de invitados ({totalInvitados}) supera la capacidad del salón seleccionado ({_presupuestoActual.Salon.Capacidad}).\n\n" +
                        "Seleccione un salón con mayor capacidad o reduzca la cantidad de invitados.",
                        "Capacidad insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Aseguramos capturar el estado seleccionado actual del ComboBox
                if (cbboxPresupuestoEstado.SelectedItem is Estado estadoSeleccionado)
                {
                    _presupuestoActual.Estado = estadoSeleccionado;
                }

                _presupuestoActual.Duracion = horas;
                _presupuestoActual.FechaPresupuesto = DateOnly.FromDateTime(dateTimePickPresupuestoFecha.Value);
                _presupuestoActual.FechaEvento = DateOnly.FromDateTime(dateTimePickPresupuestoEvento.Value);

                string resultado;
                bool operacionExitosa = false;

                if (!_esEdicion)
                {
                    resultado = _controller.CrearPresupuesto(_presupuestoActual);

                    if (_presupuestoActual.Id > 0)
                    {
                        _esEdicion = true;
                        lblPresupuestoNumeroAsignado.Text = _presupuestoActual.Id.ToString("D5");
                        operacionExitosa = true;
                    }
                }
                else
                {
                    resultado = _controller.ActualizarPresupuesto(_presupuestoActual);

                    if (resultado != null && resultado.ToLower().Contains("correctamente"))
                    {
                        operacionExitosa = true;
                    }
                }

                MessageBox.Show(
                    resultado,
                    "Gestión de Presupuestos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Si la operación de guardado fue exitosa, cerramos y recargamos FormPresupuesto en el panel principal
                if (operacionExitosa)
                {
                    if (Application.OpenForms["Principal"] is Principal formPrincipal)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                        formPrincipal.CargarFormularioEnPanel(new FormPresupuesto());
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación de Negocio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxPresupuestoCantidadHoras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el presupuesto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AsignarCliente(Cliente cliente)
        {
            if (cliente == null)
                return;

            _presupuestoActual.Cliente = cliente;

            lblPresupuestoClienteNombreyApelllido.Text = $"{cliente.Nombre} {cliente.Apellido}";
            lblPresupuestoClienteDNI.Text = cliente.Dni;
        }

        private void AsignarSalon(Salon salon)
        {
            if (salon == null)
                return;

            _presupuestoActual.Salon = salon;

            lblPresupuestoSalonNombre.Text = salon.Nombre;
            lblPresupuestoSalonLocalidad.Text = salon.Localidad;

            ActualizarResumenVisual();
        }

        private void btnPresupuestoBuscarCliente_Click(object sender, EventArgs e)
        {
            using (PantallaCliente pantallaClientes = new PantallaCliente())
            {
                pantallaClientes.StartPosition = FormStartPosition.CenterParent;

                if (pantallaClientes.ShowDialog() == DialogResult.OK)
                {
                    Cliente clienteModelo = pantallaClientes.ClienteSeleccionado;

                    if (clienteModelo != null)
                    {
                        AsignarCliente(clienteModelo);
                    }
                }
            }
        }

        private void btnPresupuestoBuscarSalon_Click(object sender, EventArgs e)
        {
            using (FormSalon formSalon = new FormSalon())
            {
                formSalon.StartPosition = FormStartPosition.CenterParent;

                if (formSalon.ShowDialog() == DialogResult.OK)
                {
                    SalonDto salonDto = formSalon.SalonSeleccionado;

                    if (salonDto != null)
                    {
                        Salon salonModelo = new Salon(
                            salonDto.Nombre,
                            salonDto.Direccion,
                            salonDto.Localidad,
                            salonDto.Capacidad,
                            salonDto.Precio
                        );

                        salonModelo.Id = salonDto.Id;

                        AsignarSalon(salonModelo);
                    }
                }
            }
        }

        private void btnPresupuestoAgregarMenu_Click(object sender, EventArgs e)
        {
            using (FormMenu formMenu = new FormMenu())
            {
                formMenu.StartPosition = FormStartPosition.CenterParent;

                if (formMenu.ShowDialog() == DialogResult.OK)
                {
                    ItemMenu itemAgregado = formMenu.ItemMenuSeleccionado;

                    if (itemAgregado != null && itemAgregado.Item != null)
                    {
                        ItemMenu itemExistente = null;
                        foreach (ItemMenu im in _presupuestoActual.Menus)
                        {
                            if (im.Item.Id == itemAgregado.Item.Id)
                            {
                                itemExistente = im;
                                break;
                            }
                        }

                        if (itemExistente != null)
                        {
                            itemExistente.Cantidad += itemAgregado.Cantidad;
                        }
                        else
                        {
                            _presupuestoActual.Menus.Add(itemAgregado);
                        }

                        CargarGrillaMenusPresupuesto();
                        ActualizarResumenVisual();
                    }
                }
            }
        }

        private void btnPresupuestoEliminarItem_Click(object sender, EventArgs e)
        {
            if (dtaGridItemsMenuServicios.CurrentRow == null || dtaGridItemsMenuServicios.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione un ítem de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indiceSeleccionado = dtaGridItemsMenuServicios.CurrentRow.Index;
            int totalMenus = _presupuestoActual.Menus.Count;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < totalMenus)
            {
                _presupuestoActual.Menus.RemoveAt(indiceSeleccionado);
            }
            else
            {
                int indiceServicioRelativo = indiceSeleccionado - totalMenus;

                if (indiceServicioRelativo >= 0 && indiceServicioRelativo < _presupuestoActual.ServiciosAdicionales.Count)
                {
                    _presupuestoActual.ServiciosAdicionales.RemoveAt(indiceServicioRelativo);
                }
            }

            CargarGrillaMenusPresupuesto();
            ActualizarResumenVisual();
        }

        private void btnPresupuestoAgregarServicio_Click(object sender, EventArgs e)
        {
            using (FormServicioAdicional formServicio = new FormServicioAdicional())
            {
                formServicio.StartPosition = FormStartPosition.CenterParent;

                if (formServicio.ShowDialog() == DialogResult.OK)
                {
                    ServicioAdicional servicioAgregado = formServicio.ServicioSeleccionado;

                    if (servicioAgregado != null)
                    {
                        bool yaExiste = false;
                        foreach (ServicioAdicional servicioExistente in _presupuestoActual.ServiciosAdicionales)
                        {
                            if (servicioExistente.Id == servicioAgregado.Id)
                            {
                                yaExiste = true;
                                break;
                            }
                        }

                        if (yaExiste)
                        {
                            MessageBox.Show(
                                "El servicio seleccionado ya existe en el presupuesto. Debe seleccionar otro servicio o crear uno nuevo que incluya la cantidad necesaria.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        _presupuestoActual.ServiciosAdicionales.Add(servicioAgregado);

                        CargarGrillaMenusPresupuesto();
                        ActualizarResumenVisual();
                    }
                }
            }
        }
    }

    // Clase de apoyo para la grilla para evitar el uso de 'var' con tipos anónimos
    public class ItemPresupuestoViewDto
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}