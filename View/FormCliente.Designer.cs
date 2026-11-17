namespace Proyecto_Salon_de_Eventos.View
{
    partial class PantallaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            gBoxBuscarCliente = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            txtBoxBusquedaCliente = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            dataGridViewClientes = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnClienteNuevo = new Button();
            btnClienteEliminar = new Button();
            btnClienteEditar = new Button();
            BtClienteSeleccionar = new Button();
            groupBoxDetalle = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label7 = new Label();
            lblIdCliente = new Label();
            lblNombreCliente = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtNotas = new TextBox();
            label9 = new Label();
            label11 = new Label();
            txtEmail = new TextBox();
            btnConfirmarCliente = new Button();
            btnCancelarCliente = new Button();
            tableLayoutPanel1.SuspendLayout();
            gBoxBuscarCliente.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBoxDetalle.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(gBoxBuscarCliente, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBoxDetalle, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.Size = new Size(1422, 752);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gBoxBuscarCliente
            // 
            gBoxBuscarCliente.Controls.Add(tableLayoutPanel2);
            gBoxBuscarCliente.Dock = DockStyle.Fill;
            gBoxBuscarCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gBoxBuscarCliente.Location = new Point(3, 3);
            gBoxBuscarCliente.Name = "gBoxBuscarCliente";
            gBoxBuscarCliente.Size = new Size(1416, 114);
            gBoxBuscarCliente.TabIndex = 0;
            gBoxBuscarCliente.TabStop = false;
            gBoxBuscarCliente.Text = "Buscar Cliente";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1410, 82);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBoxBusquedaCliente);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 43);
            panel1.TabIndex = 0;
            // 
            // txtBoxBusquedaCliente
            // 
            txtBoxBusquedaCliente.Dock = DockStyle.Fill;
            txtBoxBusquedaCliente.Font = new Font("Segoe UI", 14.25F);
            txtBoxBusquedaCliente.Location = new Point(375, 0);
            txtBoxBusquedaCliente.Name = "txtBoxBusquedaCliente";
            txtBoxBusquedaCliente.Size = new Size(888, 33);
            txtBoxBusquedaCliente.TabIndex = 1;
            txtBoxBusquedaCliente.TextChanged += txtBoxBusquedaCliente_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(375, 25);
            label1.TabIndex = 0;
            label1.Text = "Criterio de búsqueda (Nombre, DNI, Email):";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.clientes;
            pictureBox1.Location = new Point(1272, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 123);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1416, 309);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewClientes);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1268, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Clientes";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientes.Dock = DockStyle.Fill;
            dataGridViewClientes.Location = new Point(3, 25);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(1262, 275);
            dataGridViewClientes.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnClienteNuevo, 0, 0);
            tableLayoutPanel4.Controls.Add(btnClienteEliminar, 0, 2);
            tableLayoutPanel4.Controls.Add(btnClienteEditar, 0, 3);
            tableLayoutPanel4.Controls.Add(BtClienteSeleccionar, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1277, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(136, 303);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnClienteNuevo
            // 
            btnClienteNuevo.Dock = DockStyle.Fill;
            btnClienteNuevo.Font = new Font("Segoe UI", 14.25F);
            btnClienteNuevo.Location = new Point(3, 3);
            btnClienteNuevo.Name = "btnClienteNuevo";
            btnClienteNuevo.Size = new Size(130, 69);
            btnClienteNuevo.TabIndex = 0;
            btnClienteNuevo.Text = "Nuevo";
            btnClienteNuevo.UseVisualStyleBackColor = true;
            btnClienteNuevo.Click += btnClienteNuevo_Click;
            // 
            // btnClienteEliminar
            // 
            btnClienteEliminar.Dock = DockStyle.Fill;
            btnClienteEliminar.Font = new Font("Segoe UI", 14.25F);
            btnClienteEliminar.Location = new Point(3, 153);
            btnClienteEliminar.Name = "btnClienteEliminar";
            btnClienteEliminar.Size = new Size(130, 69);
            btnClienteEliminar.TabIndex = 2;
            btnClienteEliminar.Text = "Eliminar";
            btnClienteEliminar.UseVisualStyleBackColor = true;
            btnClienteEliminar.Click += btnClienteEliminar_Click;
            // 
            // btnClienteEditar
            // 
            btnClienteEditar.Dock = DockStyle.Fill;
            btnClienteEditar.Font = new Font("Segoe UI", 14.25F);
            btnClienteEditar.Location = new Point(3, 228);
            btnClienteEditar.Name = "btnClienteEditar";
            btnClienteEditar.Size = new Size(130, 72);
            btnClienteEditar.TabIndex = 3;
            btnClienteEditar.Text = "Editar";
            btnClienteEditar.UseVisualStyleBackColor = true;
            btnClienteEditar.Click += btnClienteEditar_Click;
            // 
            // BtClienteSeleccionar
            // 
            BtClienteSeleccionar.BackColor = Color.Teal;
            BtClienteSeleccionar.Dock = DockStyle.Fill;
            BtClienteSeleccionar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtClienteSeleccionar.ForeColor = SystemColors.ButtonHighlight;
            BtClienteSeleccionar.Location = new Point(0, 75);
            BtClienteSeleccionar.Margin = new Padding(0);
            BtClienteSeleccionar.Name = "BtClienteSeleccionar";
            BtClienteSeleccionar.Size = new Size(136, 75);
            BtClienteSeleccionar.TabIndex = 4;
            BtClienteSeleccionar.Text = "Asignar a Presupuesto";
            BtClienteSeleccionar.UseVisualStyleBackColor = false;
            BtClienteSeleccionar.Click += button1_Click;
            // 
            // groupBoxDetalle
            // 
            groupBoxDetalle.Controls.Add(tableLayoutPanel5);
            groupBoxDetalle.Dock = DockStyle.Fill;
            groupBoxDetalle.Enabled = false;
            groupBoxDetalle.FlatStyle = FlatStyle.Flat;
            groupBoxDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDetalle.ForeColor = SystemColors.ControlText;
            groupBoxDetalle.Location = new Point(3, 438);
            groupBoxDetalle.Name = "groupBoxDetalle";
            groupBoxDetalle.Size = new Size(1416, 311);
            groupBoxDetalle.TabIndex = 2;
            groupBoxDetalle.TabStop = false;
            groupBoxDetalle.Text = "Detalle del Cliente";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.936415F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.02826F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0070648F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.02826F));
            tableLayoutPanel5.Controls.Add(label7, 2, 1);
            tableLayoutPanel5.Controls.Add(lblIdCliente, 0, 0);
            tableLayoutPanel5.Controls.Add(lblNombreCliente, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 2);
            tableLayoutPanel5.Controls.Add(label5, 0, 3);
            tableLayoutPanel5.Controls.Add(txtId, 1, 0);
            tableLayoutPanel5.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel5.Controls.Add(txtApellido, 1, 2);
            tableLayoutPanel5.Controls.Add(txtDni, 1, 3);
            tableLayoutPanel5.Controls.Add(txtTelefono, 3, 2);
            tableLayoutPanel5.Controls.Add(txtNotas, 3, 3);
            tableLayoutPanel5.Controls.Add(label9, 2, 3);
            tableLayoutPanel5.Controls.Add(label11, 2, 2);
            tableLayoutPanel5.Controls.Add(txtEmail, 3, 1);
            tableLayoutPanel5.Controls.Add(btnConfirmarCliente, 1, 4);
            tableLayoutPanel5.Controls.Add(btnCancelarCliente, 3, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel5.Location = new Point(3, 25);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.10995F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1099434F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1099434F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.10995F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9929962F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25.5672226F));
            tableLayoutPanel5.Size = new Size(1410, 283);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(707, 39);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(135, 39);
            label7.TabIndex = 32;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Dock = DockStyle.Fill;
            lblIdCliente.Font = new Font("Segoe UI", 12F);
            lblIdCliente.Location = new Point(3, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Padding = new Padding(5);
            lblIdCliente.Size = new Size(134, 39);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "ID:";
            lblIdCliente.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Dock = DockStyle.Fill;
            lblNombreCliente.Font = new Font("Segoe UI", 12F);
            lblNombreCliente.Location = new Point(3, 39);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Padding = new Padding(5);
            lblNombreCliente.Size = new Size(134, 39);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre:";
            lblNombreCliente.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(134, 39);
            label4.TabIndex = 2;
            label4.Text = "Apellido:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 117);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(134, 39);
            label5.TabIndex = 3;
            label5.Text = "DNI:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(143, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(558, 29);
            txtId.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Location = new Point(143, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(558, 29);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Dock = DockStyle.Fill;
            txtApellido.Location = new Point(143, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(558, 29);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Dock = DockStyle.Fill;
            txtDni.Location = new Point(143, 120);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(558, 29);
            txtDni.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Location = new Point(848, 81);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(559, 29);
            txtTelefono.TabIndex = 7;
            // 
            // txtNotas
            // 
            txtNotas.Dock = DockStyle.Fill;
            txtNotas.Location = new Point(848, 120);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(559, 29);
            txtNotas.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(707, 117);
            label9.Name = "label9";
            label9.Padding = new Padding(5);
            label9.Size = new Size(135, 39);
            label9.TabIndex = 16;
            label9.Text = "Notas";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(707, 78);
            label11.Name = "label11";
            label11.Padding = new Padding(5);
            label11.Size = new Size(135, 39);
            label11.TabIndex = 29;
            label11.Text = "Teléfono:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(848, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(559, 29);
            txtEmail.TabIndex = 6;
            // 
            // btnConfirmarCliente
            // 
            btnConfirmarCliente.Dock = DockStyle.Right;
            btnConfirmarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarCliente.Location = new Point(531, 159);
            btnConfirmarCliente.Name = "btnConfirmarCliente";
            btnConfirmarCliente.Size = new Size(170, 44);
            btnConfirmarCliente.TabIndex = 33;
            btnConfirmarCliente.Text = "Confirmar";
            btnConfirmarCliente.UseVisualStyleBackColor = true;
            btnConfirmarCliente.Click += btnConfirmarCliente_Click;
            // 
            // btnCancelarCliente
            // 
            btnCancelarCliente.Dock = DockStyle.Left;
            btnCancelarCliente.Location = new Point(848, 159);
            btnCancelarCliente.Name = "btnCancelarCliente";
            btnCancelarCliente.Size = new Size(170, 44);
            btnCancelarCliente.TabIndex = 34;
            btnCancelarCliente.Text = "Cancelar";
            btnCancelarCliente.UseVisualStyleBackColor = true;
            btnCancelarCliente.Click += btnCancelarCliente_Click;
            // 
            // PantallaCliente
            // 
            AcceptButton = btnConfirmarCliente;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1422, 752);
            Controls.Add(tableLayoutPanel1);
            Name = "PantallaCliente";
            Text = "Form1";
            Load += PantallaCliente_Load;
            tableLayoutPanel1.ResumeLayout(false);
            gBoxBuscarCliente.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            groupBoxDetalle.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gBoxBuscarCliente;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TextBox txtBoxBusquedaCliente;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private DataGridView dataGridViewClientes;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBoxDetalle;
        private Button btnClienteNuevo;
        private Button btnClienteEliminar;
        private Button btnClienteEditar;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblIdCliente;
        private Label lblNombreCliente;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtNotas;
        private Label label9;
        private Label label11;
        private TextBox txtEmail;
        private Label label7;
        private Button btnConfirmarCliente;
        private Button btnCancelarCliente;
        private Button BtClienteSeleccionar;
        private PictureBox pictureBox1;
    }
}