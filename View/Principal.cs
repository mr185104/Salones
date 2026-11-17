using Proyecto_Salon_de_Eventos.Model;
using Proyecto_Salon_de_Eventos.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos
{
    public partial class Principal : Form
    {
        private Button[] botones;

        public Principal()
        {
            InitializeComponent();

            botones = new Button[] { btnPresupuesto, btnSalones, btnClientes, btnAptoMenu, btnMenus, btnOtrosServicios };

            foreach (Button boton in botones)
            {
                boton.Click += Boton_Click;
                boton.FlatStyle = FlatStyle.Flat;
            }

            this.Load += Principal_Load;
        }

        public void BloquearPanelPrincipal()
        {
            panelPrincipal.Enabled = false;
        }

        public void ActivarPanelPrincipal()
        {
            panelPrincipal.Enabled = true;
        }

        public void CargarFormularioEnPanel(Form formHijo)
        {
            // Validamos si hay una gestión de presupuesto activa y se intenta cambiar a otro formulario distinto
            if (panelPrincipalFormularios.Controls.Count > 0)
            {
                Control controlActual = panelPrincipalFormularios.Controls[0];
                if (controlActual is FormPresupuestoGestion && !(formHijo is FormPresupuestoGestion))
                {
                    DialogResult respuesta = MessageBox.Show(
                        "Tiene una gestión de presupuesto abierta. ¿Está seguro de que desea salir sin guardar los cambios?",
                        "Atención",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (respuesta == DialogResult.No)
                    {
                        // Si el usuario cancela, restauramos el color activo al botón de presupuestos
                        int indicePresupuesto = Array.IndexOf(botones, btnPresupuesto);
                        CambiarColores(indicePresupuesto);
                        return;
                    }
                }
            }

            panelPrincipalFormularios.Controls.Clear();

            // Configuraciones estrictas para incrustar formularios hijos en el panel
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.WindowState = FormWindowState.Normal;

            panelPrincipalFormularios.Controls.Add(formHijo);

            // Forzamos las dimensiones, el redibujo y la visualización correcta
            formHijo.Size = panelPrincipalFormularios.ClientSize;
            formHijo.BringToFront();
            formHijo.PerformLayout();
            formHijo.Show();
        }

        private void Principal_Load(object? sender, EventArgs e)
        {
            btnPresupuesto.PerformClick();
        }

        public void SeleccionarBotonPresupuesto()
        {
            int indicePresupuesto = Array.IndexOf(botones, btnPresupuesto);
            CambiarColores(indicePresupuesto);
            CargarFormularioEnPanel(new FormPresupuesto());
        }

        public void MostrarSalida(string texto)
        {
            txtSalida.AppendText(texto + Environment.NewLine);
        }

        private void Boton_Click(object? sender, EventArgs e)
        {
            Button? boton = sender as Button;
            if (boton != null)
            {
                int indiceActivo = Array.IndexOf(botones, boton);
                CambiarColores(indiceActivo);
            }
        }

        private void CambiarColores(int indiceActivo)
        {
            for (int i = 0; i < botones.Length; i++)
            {
                if (i == indiceActivo)
                {
                    botones[i].BackColor = Color.DarkBlue;   // Activo
                    botones[i].ForeColor = Color.White;      // Texto visible
                }
                else
                {
                    botones[i].BackColor = Color.LightSteelBlue;  // Inactivos
                    botones[i].ForeColor = Color.Black;
                }
            }
        }

        private void btnSalones_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FormSalon());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new PantallaCliente());
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FormPresupuesto());
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FormMenu());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FormSeleccionarAptoMenu());
        }

        private void btnOtrosServicios_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FormServicioAdicional());
        }

        private void panelPrincipalFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirGestionPresupuesto(Form formPresupuesto)
        {
            int indicePresupuesto = Array.IndexOf(botones, btnPresupuesto);
            CambiarColores(indicePresupuesto);
            CargarFormularioEnPanel(formPresupuesto);
        }
    }
}