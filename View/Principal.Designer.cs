namespace Proyecto_Salon_de_Eventos
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// 


        private Color colorHover = Color.Blue;
        private Color colorActivo = Color.DarkBlue;
        private Color colorInactivo = Color.LightSteelBlue;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MinimumSize = new Size(1400, 600); 
            txtSalida = new TextBox();
            panelPrincipal = new Panel();
            panel1 = new Panel();
            btnOtrosServicios = new Button();
            panelEspacio6 = new Panel();
            btnAptoMenu = new Button();
            panelEspacio5 = new Panel();
            btnMenus = new Button();
            panelEspacio = new Panel();
            btnClientes = new Button();
            panelEspacio3 = new Panel();
            btnSalones = new Button();
            panelEspacio2 = new Panel();
            btnPresupuesto = new Button();
            panelEspacio1 = new Panel();
            lblPrincipalTitulo = new Label();
            btnPrincipalTest1 = new Button();
            btnPrincipalTest2 = new Button();
            panelPrincipalFormularios = new Panel();
            panelPrincipal.SuspendLayout();
            SuspendLayout();


            
            // 
            // txtSalida
            // 
            txtSalida.Location = new Point(962, 386);
            txtSalida.Multiline = true;
            txtSalida.Name = "txtSalida";
            txtSalida.ScrollBars = ScrollBars.Vertical;
            txtSalida.Size = new Size(278, 205);
            txtSalida.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.LightSteelBlue;
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Controls.Add(btnOtrosServicios);
            panelPrincipal.Controls.Add(panelEspacio6);
            panelPrincipal.Controls.Add(btnAptoMenu);
            panelPrincipal.Controls.Add(panelEspacio5);
            panelPrincipal.Controls.Add(btnMenus);
            panelPrincipal.Controls.Add(panelEspacio);
            panelPrincipal.Controls.Add(btnClientes);
            panelPrincipal.Controls.Add(panelEspacio3);
            panelPrincipal.Controls.Add(btnSalones);
            panelPrincipal.Controls.Add(panelEspacio2);
            panelPrincipal.Controls.Add(btnPresupuesto);
            panelPrincipal.Controls.Add(panelEspacio1);
            panelPrincipal.Controls.Add(lblPrincipalTitulo);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(184, 729);
            panelPrincipal.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 30);
            panel1.TabIndex = 16;
            // 
            // btnOtrosServicios
            // 
            btnOtrosServicios.Dock = DockStyle.Top;
            btnOtrosServicios.FlatAppearance.BorderSize = 0;
            btnOtrosServicios.FlatStyle = FlatStyle.Flat;
            btnOtrosServicios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnOtrosServicios.Image = Properties.Resources.OtrosServicios2;
            btnOtrosServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnOtrosServicios.Location = new Point(0, 406);
            btnOtrosServicios.Name = "btnOtrosServicios";
            btnOtrosServicios.Size = new Size(184, 40);
            btnOtrosServicios.TabIndex = 15;
            btnOtrosServicios.Text = "Servicios";
            btnOtrosServicios.TextAlign = ContentAlignment.MiddleRight;
            btnOtrosServicios.UseVisualStyleBackColor = true;
            btnOtrosServicios.Click += btnOtrosServicios_Click;
            // 
            // panelEspacio6
            // 
            panelEspacio6.Dock = DockStyle.Top;
            panelEspacio6.Location = new Point(0, 376);
            panelEspacio6.Name = "panelEspacio6";
            panelEspacio6.Size = new Size(184, 30);
            panelEspacio6.TabIndex = 14;
            // 
            // btnAptoMenu
            // 
            btnAptoMenu.Dock = DockStyle.Top;
            btnAptoMenu.FlatAppearance.BorderSize = 0;
            btnAptoMenu.FlatStyle = FlatStyle.Flat;
            btnAptoMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAptoMenu.Image = Properties.Resources.aptoMenu;
            btnAptoMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAptoMenu.Location = new Point(0, 336);
            btnAptoMenu.Name = "btnAptoMenu";
            btnAptoMenu.Size = new Size(184, 40);
            btnAptoMenu.TabIndex = 5;
            btnAptoMenu.Text = "Aptos Menú";
            btnAptoMenu.TextAlign = ContentAlignment.MiddleRight;
            btnAptoMenu.UseVisualStyleBackColor = true;
            btnAptoMenu.Click += btnConfig_Click;
            // 
            // panelEspacio5
            // 
            panelEspacio5.Dock = DockStyle.Top;
            panelEspacio5.Location = new Point(0, 306);
            panelEspacio5.Name = "panelEspacio5";
            panelEspacio5.Size = new Size(184, 30);
            panelEspacio5.TabIndex = 12;
            // 
            // btnMenus
            // 
            btnMenus.Dock = DockStyle.Top;
            btnMenus.FlatAppearance.BorderSize = 0;
            btnMenus.FlatStyle = FlatStyle.Flat;
            btnMenus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMenus.Image = (Image)resources.GetObject("btnMenus.Image");
            btnMenus.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenus.Location = new Point(0, 266);
            btnMenus.Name = "btnMenus";
            btnMenus.Size = new Size(184, 40);
            btnMenus.TabIndex = 4;
            btnMenus.Text = "Gestión Menús";
            btnMenus.TextAlign = ContentAlignment.MiddleRight;
            btnMenus.UseVisualStyleBackColor = true;
            btnMenus.Click += btnMenus_Click;
            // 
            // panelEspacio
            // 
            panelEspacio.Dock = DockStyle.Top;
            panelEspacio.Location = new Point(0, 236);
            panelEspacio.Name = "panelEspacio";
            panelEspacio.Size = new Size(184, 30);
            panelEspacio.TabIndex = 8;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 196);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(184, 40);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Gestión Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panelEspacio3
            // 
            panelEspacio3.Dock = DockStyle.Top;
            panelEspacio3.Location = new Point(0, 166);
            panelEspacio3.Name = "panelEspacio3";
            panelEspacio3.Size = new Size(184, 30);
            panelEspacio3.TabIndex = 6;
            // 
            // btnSalones
            // 
            btnSalones.Dock = DockStyle.Top;
            btnSalones.FlatAppearance.BorderSize = 0;
            btnSalones.FlatStyle = FlatStyle.Flat;
            btnSalones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalones.Image = (Image)resources.GetObject("btnSalones.Image");
            btnSalones.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalones.Location = new Point(0, 126);
            btnSalones.Name = "btnSalones";
            btnSalones.Size = new Size(184, 40);
            btnSalones.TabIndex = 2;
            btnSalones.Text = "Gestión Salones";
            btnSalones.TextAlign = ContentAlignment.MiddleRight;
            btnSalones.UseVisualStyleBackColor = true;
            btnSalones.Click += btnSalones_Click;
            // 
            // panelEspacio2
            // 
            panelEspacio2.Dock = DockStyle.Top;
            panelEspacio2.Location = new Point(0, 96);
            panelEspacio2.Name = "panelEspacio2";
            panelEspacio2.Size = new Size(184, 30);
            panelEspacio2.TabIndex = 4;
            // 
            // btnPresupuesto
            // 
            btnPresupuesto.BackColor = Color.MidnightBlue;
            btnPresupuesto.Dock = DockStyle.Top;
            btnPresupuesto.FlatAppearance.BorderSize = 0;
            btnPresupuesto.FlatStyle = FlatStyle.Flat;
            btnPresupuesto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPresupuesto.ForeColor = Color.White;
            btnPresupuesto.Image = (Image)resources.GetObject("btnPresupuesto.Image");
            btnPresupuesto.ImageAlign = ContentAlignment.MiddleLeft;
            btnPresupuesto.Location = new Point(0, 56);
            btnPresupuesto.Name = "btnPresupuesto";
            btnPresupuesto.Padding = new Padding(10, 0, 0, 0);
            btnPresupuesto.Size = new Size(184, 40);
            btnPresupuesto.TabIndex = 1;
            btnPresupuesto.Text = "Presupuestos";
            btnPresupuesto.TextAlign = ContentAlignment.MiddleRight;
            btnPresupuesto.UseVisualStyleBackColor = false;
            btnPresupuesto.Click += btnPresupuesto_Click;
            // 
            // panelEspacio1
            // 
            panelEspacio1.Dock = DockStyle.Top;
            panelEspacio1.Location = new Point(0, 30);
            panelEspacio1.Name = "panelEspacio1";
            panelEspacio1.Size = new Size(184, 26);
            panelEspacio1.TabIndex = 1;
            // 
            // lblPrincipalTitulo
            // 
            lblPrincipalTitulo.Dock = DockStyle.Top;
            lblPrincipalTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrincipalTitulo.Location = new Point(0, 0);
            lblPrincipalTitulo.Name = "lblPrincipalTitulo";
            lblPrincipalTitulo.Size = new Size(184, 30);
            lblPrincipalTitulo.TabIndex = 0;
            lblPrincipalTitulo.Text = "- Navegación -";
            lblPrincipalTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrincipalTest1
            // 
            btnPrincipalTest1.Location = new Point(309, 62);
            btnPrincipalTest1.Name = "btnPrincipalTest1";
            btnPrincipalTest1.Size = new Size(293, 23);
            btnPrincipalTest1.TabIndex = 2;
            btnPrincipalTest1.Text = "prueba con otro presupuesto y otro cliente";
            btnPrincipalTest1.UseVisualStyleBackColor = true;
            // 
            // btnPrincipalTest2
            // 
            btnPrincipalTest2.Location = new Point(370, 119);
            btnPrincipalTest2.Name = "btnPrincipalTest2";
            btnPrincipalTest2.Size = new Size(75, 23);
            btnPrincipalTest2.TabIndex = 3;
            btnPrincipalTest2.Text = "button7";
            btnPrincipalTest2.UseVisualStyleBackColor = true;
            // 
            // panelPrincipalFormularios
            // 
            panelPrincipalFormularios.Dock = DockStyle.Fill;
            panelPrincipalFormularios.Location = new Point(184, 0);
            panelPrincipalFormularios.Name = "panelPrincipalFormularios";
            panelPrincipalFormularios.Padding = new Padding(10, 0, 0, 0);
            panelPrincipalFormularios.Size = new Size(1004, 729);
            panelPrincipalFormularios.TabIndex = 4;
            panelPrincipalFormularios.Paint += panelPrincipalFormularios_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 729);
            Controls.Add(panelPrincipalFormularios);
            Controls.Add(btnPrincipalTest2);
            Controls.Add(btnPrincipalTest1);
            Controls.Add(panelPrincipal);
            Controls.Add(txtSalida);
            Name = "Principal";
            Text = "Sistema de Gestión de Eventos - Martín Romano";
            panelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalida;
        private Panel panelPrincipal;
        private Label lblPrincipalTitulo;
        private Button btnMenus;
        private Panel panelEspacio;
        private Button btnClientes;
        private Panel panelEspacio3;
        private Button btnSalones;
        private Panel panelEspacio2;
        private Button btnPresupuesto;
        private Panel panelEspacio1;
        private Panel panelEspacio5;
        private Panel panelEspacio6;
        private Button btnAptoMenu;
        private Button btnPrincipalTest1;
        private Button btnPrincipalTest2;
        private Panel panelPrincipalFormularios;
        private Button btnOtrosServicios;
        private Panel panel1;
    }
}
