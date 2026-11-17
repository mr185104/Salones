using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormDetalleMenu : Form
    {
        private readonly MenuDto _menu;

        public ItemMenu ItemMenuSeleccionado { get; private set; }

        private TextBox txtCantidad;
        private Button btnAgregarAlPresupuesto;

        public FormDetalleMenu(MenuDto menu)
        {
            InitializeComponent();
            _menu = menu;
            ConfigurarVentana();
            CargarDatosVisuales();
        }

        private void ConfigurarVentana()
        {
            this.Text = "Detalle y Selección de Menú";
            this.Width = 640;
            this.Height = 520;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CargarDatosVisuales()
        {
            Panel panelPrincipal = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };

            Label lblTitulo = new Label
            {
                Text = $"Menú ID: {_menu.Id}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 30
            };

            TextBox txtInfo = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Segoe UI", 10),
                Text =
                    $"Nombre:\r\n{_menu.Nombre}\r\n\r\n" +
                    $"Detalle Completo:\r\n{_menu.Detalle}\r\n\r\n" +
                    $"Precio Unitario:\r\n${_menu.Precio:N2}\r\n\r\n" +
                    $"Tipo:\r\n{(_menu.EsAdulto ? "Adulto" : "Infantil")}\r\n\r\n" +
                    $"Apto para:\r\n{(_menu.AptosMenu != null && _menu.AptosMenu.Count > 0 ? string.Join(", ", _menu.AptosMenu.Select(a => a.Detalle)) : "Ninguno")}"
            };

            Panel panelInferior = new Panel { Dock = DockStyle.Bottom, Height = 70, Padding = new Padding(0, 10, 0, 0) };

            Label lblCantidad = new Label { Text = "Cantidad:", Location = new Point(0, 15), AutoSize = true, Font = new Font("Segoe UI", 10) };

            txtCantidad = new TextBox
            {
                Text = "1",
                Location = new Point(75, 12),
                Width = 60,
                Font = new Font("Segoe UI", 10)
            };

            btnAgregarAlPresupuesto = new Button
            {
                Text = "Agregar al Presupuesto",
                Location = new Point(145, 10),
                Width = 180,
                Height = 32,
                BackColor = Color.LightGreen,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnAgregarAlPresupuesto.Click += BtnAgregarAlPresupuesto_Click;

            Button btnCerrar = new Button
            {
                Text = "Cerrar",
                Location = new Point(335, 10),
                Width = 100,
                Height = 32,
                DialogResult = DialogResult.Cancel
            };

            panelInferior.Controls.Add(lblCantidad);
            panelInferior.Controls.Add(txtCantidad);
            panelInferior.Controls.Add(btnAgregarAlPresupuesto);
            panelInferior.Controls.Add(btnCerrar);

            panelPrincipal.Controls.Add(txtInfo);
            panelPrincipal.Controls.Add(panelInferior);
            panelPrincipal.Controls.Add(lblTitulo);

            this.Controls.Add(panelPrincipal);
        }

        private void BtnAgregarAlPresupuesto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            Menu menuModelo = new Menu(
                _menu.Nombre,
                _menu.Detalle,
                _menu.Precio,
                _menu.EsAdulto,
                _menu.AptosMenu != null
                    ? _menu.AptosMenu.Select(a => new AptoMenu { Id = a.Id, Detalle = a.Detalle }).ToList()
                    : null
            )
            {
                Id = _menu.Id
            };

            ItemMenu itemMenu = new ItemMenu
            {
                Id = 0,
                Cantidad = cantidad,
                Item = menuModelo
            };

            ItemMenuSeleccionado = itemMenu;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}