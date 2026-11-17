namespace Proyecto_Salon_de_Eventos.View
{
    partial class FormPresupuestoGestion
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
            tableLayoutPanel1 = new TableLayoutPanel();
            gBoxPresupuesto = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnPresupuestoGuardar = new Button();
            btnPresupuestoCancelar = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            cbboxPresupuestoEstado = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            lblPresupuestoNumeroAsignado = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            dateTimePickPresupuestoEvento = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txtBoxPresupuestoCantidadHoras = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dateTimePickPresupuestoFecha = new DateTimePicker();
            label2 = new Label();
            gBoxPresupuestoCliente = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblPresupuestoClienteDNI = new Label();
            btnPresupuestoBuscarCliente = new Button();
            label4 = new Label();
            lblPresupuestoClienteNombreyApelllido = new Label();
            label5 = new Label();
            gBoxPresupuestoSalon = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblPresupuestoSalonLocalidad = new Label();
            lblPresupuestoSalonNombre = new Label();
            btnPresupuestoBuscarSalon = new Button();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            dtaGridItemsMenuServicios = new DataGridView();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnPresupuestoEliminarItem = new Button();
            btnPresupuestoAgregarMenu = new Button();
            btnPresupuestoAgregarServicio = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            lblPresupuestoTotalInvitados = new Label();
            lblPresupuestoTituloTotalInvitados = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            label10 = new Label();
            lblPresupuestoTotalMonto = new Label();
            tableLayoutPanel1.SuspendLayout();
            gBoxPresupuesto.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gBoxPresupuestoCliente.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            gBoxPresupuestoSalon.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtaGridItemsMenuServicios).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(gBoxPresupuesto, 0, 0);
            tableLayoutPanel1.Controls.Add(gBoxPresupuestoCliente, 0, 1);
            tableLayoutPanel1.Controls.Add(gBoxPresupuestoSalon, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.63158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.Size = new Size(1152, 668);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gBoxPresupuesto
            // 
            gBoxPresupuesto.Controls.Add(tableLayoutPanel2);
            gBoxPresupuesto.Dock = DockStyle.Fill;
            gBoxPresupuesto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gBoxPresupuesto.ForeColor = SystemColors.ControlText;
            gBoxPresupuesto.Location = new Point(3, 3);
            gBoxPresupuesto.Name = "gBoxPresupuesto";
            gBoxPresupuesto.Size = new Size(1146, 132);
            gBoxPresupuesto.TabIndex = 0;
            gBoxPresupuesto.TabStop = false;
            gBoxPresupuesto.Text = "Presupuesto";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1140, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311157F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(btnPresupuestoGuardar, 1, 0);
            tableLayoutPanel8.Controls.Add(btnPresupuestoCancelar, 2, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(687, 53);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(450, 44);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // btnPresupuestoGuardar
            // 
            btnPresupuestoGuardar.BackColor = Color.PapayaWhip;
            btnPresupuestoGuardar.Dock = DockStyle.Fill;
            btnPresupuestoGuardar.Font = new Font("Segoe UI", 9F);
            btnPresupuestoGuardar.Location = new Point(149, 0);
            btnPresupuestoGuardar.Margin = new Padding(0);
            btnPresupuestoGuardar.Name = "btnPresupuestoGuardar";
            btnPresupuestoGuardar.Size = new Size(150, 44);
            btnPresupuestoGuardar.TabIndex = 0;
            btnPresupuestoGuardar.Text = "Guardar";
            btnPresupuestoGuardar.UseVisualStyleBackColor = false;
            btnPresupuestoGuardar.Click += btnPresupuestoGuardar_Click;
            // 
            // btnPresupuestoCancelar
            // 
            btnPresupuestoCancelar.Dock = DockStyle.Fill;
            btnPresupuestoCancelar.Font = new Font("Segoe UI", 9F);
            btnPresupuestoCancelar.Location = new Point(299, 0);
            btnPresupuestoCancelar.Margin = new Padding(0);
            btnPresupuestoCancelar.Name = "btnPresupuestoCancelar";
            btnPresupuestoCancelar.Size = new Size(151, 44);
            btnPresupuestoCancelar.TabIndex = 1;
            btnPresupuestoCancelar.Text = "Cancelar";
            btnPresupuestoCancelar.UseVisualStyleBackColor = true;
            btnPresupuestoCancelar.Click += btnPresupuestoCancelar_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(cbboxPresupuestoEstado, 3, 0);
            tableLayoutPanel4.Controls.Add(label3, 2, 0);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(lblPresupuestoNumeroAsignado, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(678, 44);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // cbboxPresupuestoEstado
            // 
            cbboxPresupuestoEstado.Dock = DockStyle.Fill;
            cbboxPresupuestoEstado.FormattingEnabled = true;
            cbboxPresupuestoEstado.Location = new Point(507, 0);
            cbboxPresupuestoEstado.Margin = new Padding(0);
            cbboxPresupuestoEstado.Name = "cbboxPresupuestoEstado";
            cbboxPresupuestoEstado.Size = new Size(171, 33);
            cbboxPresupuestoEstado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(439, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(68, 44);
            label3.TabIndex = 3;
            label3.Text = "Estado";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(85, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 44);
            label1.TabIndex = 0;
            label1.Text = "Número";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPresupuestoNumeroAsignado
            // 
            lblPresupuestoNumeroAsignado.AutoSize = true;
            lblPresupuestoNumeroAsignado.Dock = DockStyle.Left;
            lblPresupuestoNumeroAsignado.ForeColor = SystemColors.HotTrack;
            lblPresupuestoNumeroAsignado.Location = new Point(172, 0);
            lblPresupuestoNumeroAsignado.Name = "lblPresupuestoNumeroAsignado";
            lblPresupuestoNumeroAsignado.Size = new Size(0, 44);
            lblPresupuestoNumeroAsignado.TabIndex = 2;
            lblPresupuestoNumeroAsignado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Controls.Add(dateTimePickPresupuestoEvento, 1, 0);
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(label9, 2, 0);
            tableLayoutPanel5.Controls.Add(txtBoxPresupuestoCantidadHoras, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 53);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(678, 44);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // dateTimePickPresupuestoEvento
            // 
            dateTimePickPresupuestoEvento.Dock = DockStyle.Fill;
            dateTimePickPresupuestoEvento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickPresupuestoEvento.Format = DateTimePickerFormat.Short;
            dateTimePickPresupuestoEvento.Location = new Point(203, 0);
            dateTimePickPresupuestoEvento.Margin = new Padding(0);
            dateTimePickPresupuestoEvento.MinDate = new DateTime(2026, 10, 30, 0, 0, 0, 0);
            dateTimePickPresupuestoEvento.Name = "dateTimePickPresupuestoEvento";
            dateTimePickPresupuestoEvento.Size = new Size(271, 29);
            dateTimePickPresupuestoEvento.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(73, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 44);
            label8.TabIndex = 0;
            label8.Text = "Fecha Evento:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(477, 0);
            label9.Name = "label9";
            label9.Size = new Size(129, 44);
            label9.TabIndex = 6;
            label9.Text = "Duración";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBoxPresupuestoCantidadHoras
            // 
            txtBoxPresupuestoCantidadHoras.Location = new Point(612, 3);
            txtBoxPresupuestoCantidadHoras.Name = "txtBoxPresupuestoCantidadHoras";
            txtBoxPresupuestoCantidadHoras.Size = new Size(63, 33);
            txtBoxPresupuestoCantidadHoras.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dateTimePickPresupuestoFecha, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(687, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(450, 44);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // dateTimePickPresupuestoFecha
            // 
            dateTimePickPresupuestoFecha.Dock = DockStyle.Fill;
            dateTimePickPresupuestoFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickPresupuestoFecha.Format = DateTimePickerFormat.Short;
            dateTimePickPresupuestoFecha.Location = new Point(225, 0);
            dateTimePickPresupuestoFecha.Margin = new Padding(0);
            dateTimePickPresupuestoFecha.Name = "dateTimePickPresupuestoFecha";
            dateTimePickPresupuestoFecha.Size = new Size(225, 29);
            dateTimePickPresupuestoFecha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(43, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 44);
            label2.TabIndex = 2;
            label2.Text = "Fecha Presupuesto: ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // gBoxPresupuestoCliente
            // 
            gBoxPresupuestoCliente.Controls.Add(tableLayoutPanel6);
            gBoxPresupuestoCliente.Dock = DockStyle.Fill;
            gBoxPresupuestoCliente.Font = new Font("Segoe UI", 14.25F);
            gBoxPresupuestoCliente.Location = new Point(3, 141);
            gBoxPresupuestoCliente.Name = "gBoxPresupuestoCliente";
            gBoxPresupuestoCliente.Size = new Size(1146, 64);
            gBoxPresupuestoCliente.TabIndex = 1;
            gBoxPresupuestoCliente.TabStop = false;
            gBoxPresupuestoCliente.Text = "Cliente";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.727272F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.72727F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.87879F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.575756F));
            tableLayoutPanel6.Controls.Add(lblPresupuestoClienteDNI, 3, 0);
            tableLayoutPanel6.Controls.Add(btnPresupuestoBuscarCliente, 4, 0);
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(lblPresupuestoClienteNombreyApelllido, 1, 0);
            tableLayoutPanel6.Controls.Add(label5, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 29);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1140, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // lblPresupuestoClienteDNI
            // 
            lblPresupuestoClienteDNI.AutoSize = true;
            lblPresupuestoClienteDNI.Dock = DockStyle.Left;
            lblPresupuestoClienteDNI.ForeColor = SystemColors.HotTrack;
            lblPresupuestoClienteDNI.Location = new Point(621, 0);
            lblPresupuestoClienteDNI.Margin = new Padding(0);
            lblPresupuestoClienteDNI.Name = "lblPresupuestoClienteDNI";
            lblPresupuestoClienteDNI.Size = new Size(0, 32);
            lblPresupuestoClienteDNI.TabIndex = 4;
            lblPresupuestoClienteDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPresupuestoBuscarCliente
            // 
            btnPresupuestoBuscarCliente.Dock = DockStyle.Fill;
            btnPresupuestoBuscarCliente.Font = new Font("Segoe UI", 9.75F);
            btnPresupuestoBuscarCliente.Location = new Point(1055, 3);
            btnPresupuestoBuscarCliente.Name = "btnPresupuestoBuscarCliente";
            btnPresupuestoBuscarCliente.Size = new Size(82, 26);
            btnPresupuestoBuscarCliente.TabIndex = 0;
            btnPresupuestoBuscarCliente.Text = "Buscar";
            btnPresupuestoBuscarCliente.UseVisualStyleBackColor = true;
            btnPresupuestoBuscarCliente.Click += btnPresupuestoBuscarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(80, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 1;
            label4.Text = "Nombre y Apellido: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPresupuestoClienteNombreyApelllido
            // 
            lblPresupuestoClienteNombreyApelllido.AutoSize = true;
            lblPresupuestoClienteNombreyApelllido.Dock = DockStyle.Left;
            lblPresupuestoClienteNombreyApelllido.ForeColor = SystemColors.HotTrack;
            lblPresupuestoClienteNombreyApelllido.Location = new Point(259, 0);
            lblPresupuestoClienteNombreyApelllido.Margin = new Padding(0);
            lblPresupuestoClienteNombreyApelllido.Name = "lblPresupuestoClienteNombreyApelllido";
            lblPresupuestoClienteNombreyApelllido.Size = new Size(0, 32);
            lblPresupuestoClienteNombreyApelllido.TabIndex = 2;
            lblPresupuestoClienteNombreyApelllido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(518, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 3;
            label5.Text = "DNI:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBoxPresupuestoSalon
            // 
            gBoxPresupuestoSalon.Controls.Add(tableLayoutPanel7);
            gBoxPresupuestoSalon.Dock = DockStyle.Fill;
            gBoxPresupuestoSalon.Font = new Font("Segoe UI", 14.25F);
            gBoxPresupuestoSalon.Location = new Point(3, 211);
            gBoxPresupuestoSalon.Name = "gBoxPresupuestoSalon";
            gBoxPresupuestoSalon.Size = new Size(1146, 64);
            gBoxPresupuestoSalon.TabIndex = 2;
            gBoxPresupuestoSalon.TabStop = false;
            gBoxPresupuestoSalon.Text = "Salón";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 5;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9600344F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.9067459F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9600344F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3798847F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.793295F));
            tableLayoutPanel7.Controls.Add(lblPresupuestoSalonLocalidad, 3, 0);
            tableLayoutPanel7.Controls.Add(lblPresupuestoSalonNombre, 1, 0);
            tableLayoutPanel7.Controls.Add(btnPresupuestoBuscarSalon, 4, 0);
            tableLayoutPanel7.Controls.Add(label6, 0, 0);
            tableLayoutPanel7.Controls.Add(label7, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 29);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1140, 32);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // lblPresupuestoSalonLocalidad
            // 
            lblPresupuestoSalonLocalidad.AutoSize = true;
            lblPresupuestoSalonLocalidad.Dock = DockStyle.Left;
            lblPresupuestoSalonLocalidad.ForeColor = SystemColors.HotTrack;
            lblPresupuestoSalonLocalidad.Location = new Point(737, 0);
            lblPresupuestoSalonLocalidad.Margin = new Padding(0);
            lblPresupuestoSalonLocalidad.Name = "lblPresupuestoSalonLocalidad";
            lblPresupuestoSalonLocalidad.Size = new Size(0, 32);
            lblPresupuestoSalonLocalidad.TabIndex = 7;
            lblPresupuestoSalonLocalidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPresupuestoSalonNombre
            // 
            lblPresupuestoSalonNombre.AutoSize = true;
            lblPresupuestoSalonNombre.Dock = DockStyle.Left;
            lblPresupuestoSalonNombre.ForeColor = SystemColors.HotTrack;
            lblPresupuestoSalonNombre.Location = new Point(170, 0);
            lblPresupuestoSalonNombre.Margin = new Padding(0);
            lblPresupuestoSalonNombre.Name = "lblPresupuestoSalonNombre";
            lblPresupuestoSalonNombre.Size = new Size(0, 32);
            lblPresupuestoSalonNombre.TabIndex = 6;
            lblPresupuestoSalonNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPresupuestoBuscarSalon
            // 
            btnPresupuestoBuscarSalon.Dock = DockStyle.Fill;
            btnPresupuestoBuscarSalon.Font = new Font("Segoe UI", 9.75F);
            btnPresupuestoBuscarSalon.Location = new Point(1040, 3);
            btnPresupuestoBuscarSalon.Name = "btnPresupuestoBuscarSalon";
            btnPresupuestoBuscarSalon.Size = new Size(97, 26);
            btnPresupuestoBuscarSalon.TabIndex = 0;
            btnPresupuestoBuscarSalon.Text = "Buscar";
            btnPresupuestoBuscarSalon.UseVisualStyleBackColor = true;
            btnPresupuestoBuscarSalon.Click += btnPresupuestoBuscarSalon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(164, 32);
            label6.TabIndex = 1;
            label6.Text = "Nombre:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(637, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 3;
            label7.Text = "Localidad:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel9);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 14.25F);
            groupBox3.Location = new Point(3, 281);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1146, 271);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Items";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel9.Controls.Add(dtaGridItemsMenuServicios, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 29);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(1140, 239);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // dtaGridItemsMenuServicios
            // 
            dtaGridItemsMenuServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtaGridItemsMenuServicios.Dock = DockStyle.Fill;
            dtaGridItemsMenuServicios.Location = new Point(3, 3);
            dtaGridItemsMenuServicios.Name = "dtaGridItemsMenuServicios";
            dtaGridItemsMenuServicios.Size = new Size(792, 233);
            dtaGridItemsMenuServicios.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(btnPresupuestoEliminarItem, 0, 2);
            tableLayoutPanel10.Controls.Add(btnPresupuestoAgregarMenu, 0, 0);
            tableLayoutPanel10.Controls.Add(btnPresupuestoAgregarServicio, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(801, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel10.Size = new Size(336, 233);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // btnPresupuestoEliminarItem
            // 
            btnPresupuestoEliminarItem.Dock = DockStyle.Fill;
            btnPresupuestoEliminarItem.ForeColor = Color.Red;
            btnPresupuestoEliminarItem.Location = new Point(3, 189);
            btnPresupuestoEliminarItem.Name = "btnPresupuestoEliminarItem";
            btnPresupuestoEliminarItem.Size = new Size(330, 41);
            btnPresupuestoEliminarItem.TabIndex = 2;
            btnPresupuestoEliminarItem.Text = "Eliminar Item";
            btnPresupuestoEliminarItem.UseVisualStyleBackColor = true;
            btnPresupuestoEliminarItem.Click += btnPresupuestoEliminarItem_Click;
            // 
            // btnPresupuestoAgregarMenu
            // 
            btnPresupuestoAgregarMenu.Dock = DockStyle.Fill;
            btnPresupuestoAgregarMenu.Location = new Point(3, 3);
            btnPresupuestoAgregarMenu.Name = "btnPresupuestoAgregarMenu";
            btnPresupuestoAgregarMenu.Size = new Size(330, 87);
            btnPresupuestoAgregarMenu.TabIndex = 0;
            btnPresupuestoAgregarMenu.Text = "Agregar Menu";
            btnPresupuestoAgregarMenu.UseVisualStyleBackColor = true;
            btnPresupuestoAgregarMenu.Click += btnPresupuestoAgregarMenu_Click;
            // 
            // btnPresupuestoAgregarServicio
            // 
            btnPresupuestoAgregarServicio.Dock = DockStyle.Fill;
            btnPresupuestoAgregarServicio.Location = new Point(3, 96);
            btnPresupuestoAgregarServicio.Name = "btnPresupuestoAgregarServicio";
            btnPresupuestoAgregarServicio.Size = new Size(330, 87);
            btnPresupuestoAgregarServicio.TabIndex = 1;
            btnPresupuestoAgregarServicio.Text = "Agregar Servicio";
            btnPresupuestoAgregarServicio.UseVisualStyleBackColor = true;
            btnPresupuestoAgregarServicio.Click += btnPresupuestoAgregarServicio_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel11);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 14.25F);
            groupBox4.Location = new Point(3, 558);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1146, 107);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumen";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 29);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(1140, 75);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(lblPresupuestoTotalInvitados, 1, 0);
            tableLayoutPanel12.Controls.Add(lblPresupuestoTituloTotalInvitados, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(564, 69);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // lblPresupuestoTotalInvitados
            // 
            lblPresupuestoTotalInvitados.AutoSize = true;
            lblPresupuestoTotalInvitados.Dock = DockStyle.Fill;
            lblPresupuestoTotalInvitados.Location = new Point(285, 0);
            lblPresupuestoTotalInvitados.Name = "lblPresupuestoTotalInvitados";
            lblPresupuestoTotalInvitados.Size = new Size(276, 69);
            lblPresupuestoTotalInvitados.TabIndex = 1;
            lblPresupuestoTotalInvitados.Text = "0";
            lblPresupuestoTotalInvitados.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPresupuestoTituloTotalInvitados
            // 
            lblPresupuestoTituloTotalInvitados.AutoSize = true;
            lblPresupuestoTituloTotalInvitados.Dock = DockStyle.Fill;
            lblPresupuestoTituloTotalInvitados.Location = new Point(3, 0);
            lblPresupuestoTituloTotalInvitados.Name = "lblPresupuestoTituloTotalInvitados";
            lblPresupuestoTituloTotalInvitados.Size = new Size(276, 69);
            lblPresupuestoTituloTotalInvitados.TabIndex = 0;
            lblPresupuestoTituloTotalInvitados.Text = "Total Invitados:";
            lblPresupuestoTituloTotalInvitados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label10, 0, 0);
            tableLayoutPanel13.Controls.Add(lblPresupuestoTotalMonto, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(573, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(564, 69);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Right;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(174, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 69);
            label10.TabIndex = 0;
            label10.Text = "TOTAL:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPresupuestoTotalMonto
            // 
            lblPresupuestoTotalMonto.AutoSize = true;
            lblPresupuestoTotalMonto.Dock = DockStyle.Fill;
            lblPresupuestoTotalMonto.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresupuestoTotalMonto.ForeColor = Color.Teal;
            lblPresupuestoTotalMonto.Location = new Point(285, 0);
            lblPresupuestoTotalMonto.Name = "lblPresupuestoTotalMonto";
            lblPresupuestoTotalMonto.Size = new Size(276, 69);
            lblPresupuestoTotalMonto.TabIndex = 1;
            lblPresupuestoTotalMonto.Text = "$0,00";
            lblPresupuestoTotalMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPresupuestoGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 668);
            Controls.Add(tableLayoutPanel1);
            Name = "FormPresupuestoGestion";
            Text = "Presupuesto";
            Load += FormPresupuestoGestion_Load;
            tableLayoutPanel1.ResumeLayout(false);
            gBoxPresupuesto.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            gBoxPresupuestoCliente.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            gBoxPresupuestoSalon.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtaGridItemsMenuServicios).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gBoxPresupuesto;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label lblPresupuestoNumeroAsignado;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox gBoxPresupuestoCliente;
        private GroupBox gBoxPresupuestoSalon;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnPresupuestoBuscarCliente;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnPresupuestoBuscarSalon;
        private Label label4;
        private Label lblPresupuestoClienteNombreyApelllido;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btnPresupuestoGuardar;
        private Button btnPresupuestoCancelar;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel3;
        private DateTimePicker dateTimePickPresupuestoFecha;
        private Label label2;
        private ComboBox cbboxPresupuestoEstado;
        private Label label3;
        private Label label8;
        private DateTimePicker dateTimePickPresupuestoEvento;
        private TableLayoutPanel tableLayoutPanel9;
        private DataGridView dtaGridItemsMenuServicios;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnPresupuestoAgregarMenu;
        private Button btnPresupuestoAgregarServicio;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private Label lblPresupuestoTituloTotalInvitados;
        private Label label10;
        private Label lblPresupuestoTotalMonto;
        private Label lblPresupuestoTotalInvitados;
        private Label lblPresupuestoSalonNombre;
        private TextBox txtBoxPresupuestoCantidadHoras;
        private Label lblPresupuestoClienteDNI;
        private Label lblPresupuestoSalonLocalidad;
        private Button btnPresupuestoEliminarItem;
    }
}