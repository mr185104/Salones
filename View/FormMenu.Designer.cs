namespace Proyecto_Salon_de_Eventos.View
{
    partial class FormMenu
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
            gBoxBuscarMenu = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            lblMenuPrecioMax = new Label();
            txtBoxMenuPrecioMaximo = new TextBox();
            chkBoxNino = new CheckBox();
            chkBoxAdulto = new CheckBox();
            txtBoxBusquedaMenu = new TextBox();
            lblMenuBusqueda = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            gboxCentralMenu = new GroupBox();
            dataGridViewMenu = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnMenuNuevo = new Button();
            btnMenuEliminar = new Button();
            btnMenuEditar = new Button();
            groupBoxMenuDetalle = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            textMenuPrecio = new TextBox();
            lblMenuPrecio = new Label();
            lblMenuApto = new Label();
            lblMenuId = new Label();
            lblMenuNombre = new Label();
            lblMenuDetalle = new Label();
            lblMenuAdulto = new Label();
            txtMenuId = new TextBox();
            txtMenuNombre = new TextBox();
            txtMenuDetalle = new TextBox();
            btnMenuConfirmar = new Button();
            btnMenuCancelar = new Button();
            panel1 = new Panel();
            radioBtnMenuNino = new RadioButton();
            radioBtnMenuAdulto = new RadioButton();
            btnMenuAgregarAptoMenu = new Button();
            textBoxMenuListaApto = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            gBoxBuscarMenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            gboxCentralMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBoxMenuDetalle.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(gBoxBuscarMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBoxMenuDetalle, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.Size = new Size(1257, 654);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // gBoxBuscarMenu
            // 
            gBoxBuscarMenu.Controls.Add(tableLayoutPanel2);
            gBoxBuscarMenu.Dock = DockStyle.Fill;
            gBoxBuscarMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gBoxBuscarMenu.Location = new Point(3, 3);
            gBoxBuscarMenu.Name = "gBoxBuscarMenu";
            gBoxBuscarMenu.Size = new Size(1251, 98);
            gBoxBuscarMenu.TabIndex = 0;
            gBoxBuscarMenu.TabStop = false;
            gBoxBuscarMenu.Text = "Buscar Menú";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1245, 66);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMenuPrecioMax);
            panel2.Controls.Add(txtBoxMenuPrecioMaximo);
            panel2.Controls.Add(chkBoxNino);
            panel2.Controls.Add(chkBoxAdulto);
            panel2.Controls.Add(txtBoxBusquedaMenu);
            panel2.Controls.Add(lblMenuBusqueda);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(1114, 33);
            panel2.TabIndex = 0;
            // 
            // lblMenuPrecioMax
            // 
            lblMenuPrecioMax.AutoSize = true;
            lblMenuPrecioMax.Dock = DockStyle.Right;
            lblMenuPrecioMax.Font = new Font("Segoe UI", 14.25F);
            lblMenuPrecioMax.Location = new Point(802, 0);
            lblMenuPrecioMax.Name = "lblMenuPrecioMax";
            lblMenuPrecioMax.Size = new Size(137, 25);
            lblMenuPrecioMax.TabIndex = 6;
            lblMenuPrecioMax.Text = "Precio máximo";
            // 
            // txtBoxMenuPrecioMaximo
            // 
            txtBoxMenuPrecioMaximo.Dock = DockStyle.Right;
            txtBoxMenuPrecioMaximo.Font = new Font("Segoe UI", 14.25F);
            txtBoxMenuPrecioMaximo.Location = new Point(939, 0);
            txtBoxMenuPrecioMaximo.Name = "txtBoxMenuPrecioMaximo";
            txtBoxMenuPrecioMaximo.Size = new Size(175, 33);
            txtBoxMenuPrecioMaximo.TabIndex = 5;
            txtBoxMenuPrecioMaximo.TextChanged += txtBoxMenuPrecioMaximo_TextChanged;
            // 
            // chkBoxNino
            // 
            chkBoxNino.AutoSize = true;
            chkBoxNino.Checked = true;
            chkBoxNino.CheckState = CheckState.Checked;
            chkBoxNino.Dock = DockStyle.Left;
            chkBoxNino.Location = new Point(441, 0);
            chkBoxNino.Name = "chkBoxNino";
            chkBoxNino.Padding = new Padding(15, 0, 0, 0);
            chkBoxNino.Size = new Size(87, 33);
            chkBoxNino.TabIndex = 3;
            chkBoxNino.Text = "Niño";
            chkBoxNino.UseVisualStyleBackColor = true;
            chkBoxNino.CheckedChanged += chkBoxNino_CheckedChanged;
            // 
            // chkBoxAdulto
            // 
            chkBoxAdulto.AutoSize = true;
            chkBoxAdulto.Checked = true;
            chkBoxAdulto.CheckState = CheckState.Checked;
            chkBoxAdulto.Dock = DockStyle.Left;
            chkBoxAdulto.Location = new Point(339, 0);
            chkBoxAdulto.Name = "chkBoxAdulto";
            chkBoxAdulto.Padding = new Padding(15, 0, 0, 0);
            chkBoxAdulto.Size = new Size(102, 33);
            chkBoxAdulto.TabIndex = 2;
            chkBoxAdulto.Text = "Adulto";
            chkBoxAdulto.UseVisualStyleBackColor = true;
            chkBoxAdulto.CheckedChanged += chkBoxAduto_CheckedChanged;
            // 
            // txtBoxBusquedaMenu
            // 
            txtBoxBusquedaMenu.Dock = DockStyle.Left;
            txtBoxBusquedaMenu.Font = new Font("Segoe UI", 14.25F);
            txtBoxBusquedaMenu.Location = new Point(64, 0);
            txtBoxBusquedaMenu.Name = "txtBoxBusquedaMenu";
            txtBoxBusquedaMenu.Size = new Size(275, 33);
            txtBoxBusquedaMenu.TabIndex = 1;
            txtBoxBusquedaMenu.TextChanged += txtBoxBusquedaMenu_TextChanged;
            // 
            // lblMenuBusqueda
            // 
            lblMenuBusqueda.AutoSize = true;
            lblMenuBusqueda.Dock = DockStyle.Left;
            lblMenuBusqueda.Font = new Font("Segoe UI", 14.25F);
            lblMenuBusqueda.Location = new Point(0, 0);
            lblMenuBusqueda.Name = "lblMenuBusqueda";
            lblMenuBusqueda.Size = new Size(64, 25);
            lblMenuBusqueda.TabIndex = 0;
            lblMenuBusqueda.Text = "Filtro: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.menus4;
            pictureBox1.Location = new Point(1123, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(gboxCentralMenu, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 107);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1251, 268);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // gboxCentralMenu
            // 
            gboxCentralMenu.Controls.Add(dataGridViewMenu);
            gboxCentralMenu.Dock = DockStyle.Fill;
            gboxCentralMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxCentralMenu.Location = new Point(3, 3);
            gboxCentralMenu.Name = "gboxCentralMenu";
            gboxCentralMenu.Size = new Size(1119, 262);
            gboxCentralMenu.TabIndex = 0;
            gboxCentralMenu.TabStop = false;
            gboxCentralMenu.Text = "Menús";
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.AllowUserToDeleteRows = false;
            dataGridViewMenu.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMenu.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMenu.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMenu.Dock = DockStyle.Fill;
            dataGridViewMenu.Location = new Point(3, 25);
            dataGridViewMenu.MultiSelect = false;
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewMenu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenu.Size = new Size(1113, 234);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellContentClick += dataGridViewMenu_CellContentClick;
            dataGridViewMenu.CellMouseDoubleClick += dataGridViewMenu_CellMouseDoubleClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnMenuNuevo, 0, 0);
            tableLayoutPanel4.Controls.Add(btnMenuEliminar, 0, 2);
            tableLayoutPanel4.Controls.Add(btnMenuEditar, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1128, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(120, 262);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnMenuNuevo
            // 
            btnMenuNuevo.Dock = DockStyle.Fill;
            btnMenuNuevo.Font = new Font("Segoe UI", 14.25F);
            btnMenuNuevo.Location = new Point(3, 3);
            btnMenuNuevo.Name = "btnMenuNuevo";
            btnMenuNuevo.Size = new Size(114, 59);
            btnMenuNuevo.TabIndex = 0;
            btnMenuNuevo.Text = "Nuevo";
            btnMenuNuevo.UseVisualStyleBackColor = true;
            btnMenuNuevo.Click += btnMenuNuevo_Click;
            // 
            // btnMenuEliminar
            // 
            btnMenuEliminar.Dock = DockStyle.Fill;
            btnMenuEliminar.Font = new Font("Segoe UI", 14.25F);
            btnMenuEliminar.Location = new Point(3, 133);
            btnMenuEliminar.Name = "btnMenuEliminar";
            btnMenuEliminar.Size = new Size(114, 59);
            btnMenuEliminar.TabIndex = 2;
            btnMenuEliminar.Text = "Eliminar";
            btnMenuEliminar.UseVisualStyleBackColor = true;
            btnMenuEliminar.Click += btnMenuEliminar_Click;
            // 
            // btnMenuEditar
            // 
            btnMenuEditar.Dock = DockStyle.Fill;
            btnMenuEditar.Font = new Font("Segoe UI", 14.25F);
            btnMenuEditar.Location = new Point(3, 198);
            btnMenuEditar.Name = "btnMenuEditar";
            btnMenuEditar.Size = new Size(114, 61);
            btnMenuEditar.TabIndex = 3;
            btnMenuEditar.Text = "Editar";
            btnMenuEditar.UseVisualStyleBackColor = true;
            btnMenuEditar.Click += btnMenuEditar_Click;
            // 
            // groupBoxMenuDetalle
            // 
            groupBoxMenuDetalle.Controls.Add(tableLayoutPanel5);
            groupBoxMenuDetalle.Dock = DockStyle.Fill;
            groupBoxMenuDetalle.FlatStyle = FlatStyle.Flat;
            groupBoxMenuDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxMenuDetalle.ForeColor = SystemColors.ControlText;
            groupBoxMenuDetalle.Location = new Point(3, 381);
            groupBoxMenuDetalle.Name = "groupBoxMenuDetalle";
            groupBoxMenuDetalle.Size = new Size(1251, 270);
            groupBoxMenuDetalle.TabIndex = 2;
            groupBoxMenuDetalle.TabStop = false;
            groupBoxMenuDetalle.Text = "Detalle del Menú";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.936415F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.02826F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0070648F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.02826F));
            tableLayoutPanel5.Controls.Add(textMenuPrecio, 3, 3);
            tableLayoutPanel5.Controls.Add(lblMenuPrecio, 2, 3);
            tableLayoutPanel5.Controls.Add(lblMenuApto, 2, 2);
            tableLayoutPanel5.Controls.Add(lblMenuId, 0, 0);
            tableLayoutPanel5.Controls.Add(lblMenuNombre, 0, 1);
            tableLayoutPanel5.Controls.Add(lblMenuDetalle, 0, 2);
            tableLayoutPanel5.Controls.Add(lblMenuAdulto, 0, 3);
            tableLayoutPanel5.Controls.Add(txtMenuId, 1, 0);
            tableLayoutPanel5.Controls.Add(txtMenuNombre, 1, 1);
            tableLayoutPanel5.Controls.Add(txtMenuDetalle, 1, 2);
            tableLayoutPanel5.Controls.Add(btnMenuConfirmar, 1, 4);
            tableLayoutPanel5.Controls.Add(btnMenuCancelar, 3, 4);
            tableLayoutPanel5.Controls.Add(panel1, 1, 3);
            tableLayoutPanel5.Controls.Add(btnMenuAgregarAptoMenu, 3, 2);
            tableLayoutPanel5.Controls.Add(textBoxMenuListaApto, 3, 1);
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
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1245, 242);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // textMenuPrecio
            // 
            textMenuPrecio.Dock = DockStyle.Fill;
            textMenuPrecio.Location = new Point(748, 105);
            textMenuPrecio.Name = "textMenuPrecio";
            textMenuPrecio.Size = new Size(494, 29);
            textMenuPrecio.TabIndex = 7;
            // 
            // lblMenuPrecio
            // 
            lblMenuPrecio.AutoSize = true;
            lblMenuPrecio.Dock = DockStyle.Fill;
            lblMenuPrecio.Font = new Font("Segoe UI", 12F);
            lblMenuPrecio.ImageAlign = ContentAlignment.BottomLeft;
            lblMenuPrecio.Location = new Point(624, 102);
            lblMenuPrecio.Name = "lblMenuPrecio";
            lblMenuPrecio.Padding = new Padding(5);
            lblMenuPrecio.Size = new Size(118, 34);
            lblMenuPrecio.TabIndex = 41;
            lblMenuPrecio.Text = "Precio:";
            lblMenuPrecio.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMenuApto
            // 
            lblMenuApto.AutoSize = true;
            lblMenuApto.Dock = DockStyle.Fill;
            lblMenuApto.Font = new Font("Segoe UI", 12F);
            lblMenuApto.ImageAlign = ContentAlignment.BottomLeft;
            lblMenuApto.Location = new Point(624, 68);
            lblMenuApto.Name = "lblMenuApto";
            lblMenuApto.Padding = new Padding(5);
            lblMenuApto.Size = new Size(118, 34);
            lblMenuApto.TabIndex = 39;
            lblMenuApto.Text = "Apto para:";
            lblMenuApto.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMenuId
            // 
            lblMenuId.AutoSize = true;
            lblMenuId.Dock = DockStyle.Fill;
            lblMenuId.Font = new Font("Segoe UI", 12F);
            lblMenuId.Location = new Point(3, 0);
            lblMenuId.Name = "lblMenuId";
            lblMenuId.Padding = new Padding(5);
            lblMenuId.Size = new Size(117, 34);
            lblMenuId.TabIndex = 0;
            lblMenuId.Text = "ID:";
            lblMenuId.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMenuNombre
            // 
            lblMenuNombre.AutoSize = true;
            lblMenuNombre.Dock = DockStyle.Fill;
            lblMenuNombre.Font = new Font("Segoe UI", 12F);
            lblMenuNombre.Location = new Point(3, 34);
            lblMenuNombre.Name = "lblMenuNombre";
            lblMenuNombre.Padding = new Padding(5);
            lblMenuNombre.Size = new Size(117, 34);
            lblMenuNombre.TabIndex = 1;
            lblMenuNombre.Text = "Nombre:";
            lblMenuNombre.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMenuDetalle
            // 
            lblMenuDetalle.AutoSize = true;
            lblMenuDetalle.Dock = DockStyle.Fill;
            lblMenuDetalle.Font = new Font("Segoe UI", 12F);
            lblMenuDetalle.Location = new Point(3, 68);
            lblMenuDetalle.Name = "lblMenuDetalle";
            lblMenuDetalle.Padding = new Padding(5);
            lblMenuDetalle.Size = new Size(117, 34);
            lblMenuDetalle.TabIndex = 2;
            lblMenuDetalle.Text = "Detalle:";
            lblMenuDetalle.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMenuAdulto
            // 
            lblMenuAdulto.AutoSize = true;
            lblMenuAdulto.Dock = DockStyle.Fill;
            lblMenuAdulto.Font = new Font("Segoe UI", 12F);
            lblMenuAdulto.Location = new Point(3, 102);
            lblMenuAdulto.Name = "lblMenuAdulto";
            lblMenuAdulto.Padding = new Padding(5);
            lblMenuAdulto.Size = new Size(117, 34);
            lblMenuAdulto.TabIndex = 3;
            lblMenuAdulto.Text = "Edad:";
            lblMenuAdulto.TextAlign = ContentAlignment.TopRight;
            // 
            // txtMenuId
            // 
            txtMenuId.Dock = DockStyle.Fill;
            txtMenuId.Enabled = false;
            txtMenuId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuId.Location = new Point(126, 3);
            txtMenuId.Name = "txtMenuId";
            txtMenuId.Size = new Size(492, 29);
            txtMenuId.TabIndex = 2;
            // 
            // txtMenuNombre
            // 
            txtMenuNombre.Dock = DockStyle.Fill;
            txtMenuNombre.Location = new Point(126, 37);
            txtMenuNombre.Name = "txtMenuNombre";
            txtMenuNombre.Size = new Size(492, 29);
            txtMenuNombre.TabIndex = 3;
            // 
            // txtMenuDetalle
            // 
            txtMenuDetalle.Dock = DockStyle.Fill;
            txtMenuDetalle.Location = new Point(126, 71);
            txtMenuDetalle.Name = "txtMenuDetalle";
            txtMenuDetalle.Size = new Size(492, 29);
            txtMenuDetalle.TabIndex = 4;
            // 
            // btnMenuConfirmar
            // 
            btnMenuConfirmar.Dock = DockStyle.Right;
            btnMenuConfirmar.Location = new Point(448, 139);
            btnMenuConfirmar.Name = "btnMenuConfirmar";
            btnMenuConfirmar.Size = new Size(170, 37);
            btnMenuConfirmar.TabIndex = 8;
            btnMenuConfirmar.Text = "Confirmar";
            btnMenuConfirmar.UseVisualStyleBackColor = true;
            btnMenuConfirmar.Click += btnMenuConfirmar_Click;
            // 
            // btnMenuCancelar
            // 
            btnMenuCancelar.Dock = DockStyle.Left;
            btnMenuCancelar.Location = new Point(748, 139);
            btnMenuCancelar.Name = "btnMenuCancelar";
            btnMenuCancelar.Size = new Size(170, 37);
            btnMenuCancelar.TabIndex = 9;
            btnMenuCancelar.Text = "Cancelar";
            btnMenuCancelar.UseVisualStyleBackColor = true;
            btnMenuCancelar.Click += btnMenuCancelar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioBtnMenuNino);
            panel1.Controls.Add(radioBtnMenuAdulto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(126, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 28);
            panel1.TabIndex = 43;
            // 
            // radioBtnMenuNino
            // 
            radioBtnMenuNino.AutoSize = true;
            radioBtnMenuNino.Dock = DockStyle.Left;
            radioBtnMenuNino.Location = new Point(146, 0);
            radioBtnMenuNino.Name = "radioBtnMenuNino";
            radioBtnMenuNino.Padding = new Padding(10, 0, 20, 0);
            radioBtnMenuNino.Size = new Size(133, 28);
            radioBtnMenuNino.TabIndex = 1;
            radioBtnMenuNino.TabStop = true;
            radioBtnMenuNino.Text = "Menú niño";
            radioBtnMenuNino.UseVisualStyleBackColor = true;
            // 
            // radioBtnMenuAdulto
            // 
            radioBtnMenuAdulto.AutoSize = true;
            radioBtnMenuAdulto.Checked = true;
            radioBtnMenuAdulto.Dock = DockStyle.Left;
            radioBtnMenuAdulto.Location = new Point(0, 0);
            radioBtnMenuAdulto.Name = "radioBtnMenuAdulto";
            radioBtnMenuAdulto.Padding = new Padding(10, 0, 20, 0);
            radioBtnMenuAdulto.Size = new Size(146, 28);
            radioBtnMenuAdulto.TabIndex = 0;
            radioBtnMenuAdulto.TabStop = true;
            radioBtnMenuAdulto.Text = "Menú adulto";
            radioBtnMenuAdulto.UseVisualStyleBackColor = true;
            // 
            // btnMenuAgregarAptoMenu
            // 
            btnMenuAgregarAptoMenu.AutoSize = true;
            btnMenuAgregarAptoMenu.Dock = DockStyle.Left;
            btnMenuAgregarAptoMenu.Location = new Point(748, 71);
            btnMenuAgregarAptoMenu.Name = "btnMenuAgregarAptoMenu";
            btnMenuAgregarAptoMenu.Size = new Size(109, 28);
            btnMenuAgregarAptoMenu.TabIndex = 44;
            btnMenuAgregarAptoMenu.Text = "Ver opciones";
            btnMenuAgregarAptoMenu.UseVisualStyleBackColor = true;
            btnMenuAgregarAptoMenu.Click += btnMenuAgregarAptoMenu_Click;
            // 
            // textBoxMenuListaApto
            // 
            textBoxMenuListaApto.Dock = DockStyle.Fill;
            textBoxMenuListaApto.Enabled = false;
            textBoxMenuListaApto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMenuListaApto.Location = new Point(748, 37);
            textBoxMenuListaApto.Multiline = true;
            textBoxMenuListaApto.Name = "textBoxMenuListaApto";
            textBoxMenuListaApto.Size = new Size(494, 28);
            textBoxMenuListaApto.TabIndex = 45;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 654);
            Controls.Add(tableLayoutPanel1);
            Name = "FormMenu";
            Text = "FormMenu";
            tableLayoutPanel1.ResumeLayout(false);
            gBoxBuscarMenu.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            gboxCentralMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            groupBoxMenuDetalle.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxBuscarMenu;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        //private Label lblCriterioBusquedaSalon;
        //private PictureBox imgLogoSalon;
        private TableLayoutPanel tableLayoutPanel1;
        //private GroupBox gBoxBuscarMenu;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox gboxCentralMenu;
        private DataGridView dataGridViewMenu;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnMenuNuevo;
        private Button btnMenuEliminar;
        private Button btnMenuEditar;
        private GroupBox groupBoxMenuDetalle;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textMenuPrecio;
        private Label lblMenuPrecio;
        private Label lblMenuApto;
        private Label lblMenuId;
        private Label lblMenuNombre;
        private Label lblMenuDetalle;
        private Label lblMenuAdulto;
        private TextBox txtMenuId;
        private TextBox txtMenuNombre;
        private TextBox txtMenuDetalle;
        //private CheckedListBox chkBoxMenuApto;
        private RadioButton radioBtnMenuNino;
        private RadioButton radioBtnMenuAdulto;
        private Button btnMenuAgregarAptoMenu;
        private TextBox textBoxMenuListaApto;
        private Button btnMenuConfirmar;
        private Button btnMenuCancelar;
        private Panel panel2;
        private TextBox txtBoxBusquedaMenu;
        private Label lblMenuBusqueda;
        private PictureBox pictureBox1;
        private CheckBox chkBoxNino;
        private CheckBox chkBoxAdulto;
        private Label lblMenuPrecioMax;
        private TextBox txtBoxMenuPrecioMaximo;
    }
}