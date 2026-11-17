namespace Proyecto_Salon_de_Eventos.View
{
    partial class FormSeleccionarAptoMenu
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
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBoxDatagridAptos = new GroupBox();
            dataGridViewAptoMenu = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAptoMenuEditar = new Button();
            btnAptoMenuEliminar = new Button();
            btnAptoMenuNuevo = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxDatagridAptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAptoMenu).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MistyRose;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.LogosApto;
            label1.Location = new Point(3, 355);
            label1.Name = "label1";
            label1.Size = new Size(794, 95);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(groupBoxDatagridAptos, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 349);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxDatagridAptos
            // 
            groupBoxDatagridAptos.Controls.Add(dataGridViewAptoMenu);
            groupBoxDatagridAptos.Dock = DockStyle.Fill;
            groupBoxDatagridAptos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDatagridAptos.Location = new Point(3, 3);
            groupBoxDatagridAptos.Name = "groupBoxDatagridAptos";
            groupBoxDatagridAptos.Size = new Size(629, 343);
            groupBoxDatagridAptos.TabIndex = 2;
            groupBoxDatagridAptos.TabStop = false;
            groupBoxDatagridAptos.Text = "Lista de Aptos Menu";
            // 
            // dataGridViewAptoMenu
            // 
            dataGridViewAptoMenu.AllowUserToAddRows = false;
            dataGridViewAptoMenu.AllowUserToDeleteRows = false;
            dataGridViewAptoMenu.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAptoMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAptoMenu.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAptoMenu.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAptoMenu.Dock = DockStyle.Fill;
            dataGridViewAptoMenu.Location = new Point(3, 23);
            dataGridViewAptoMenu.MultiSelect = false;
            dataGridViewAptoMenu.Name = "dataGridViewAptoMenu";
            dataGridViewAptoMenu.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewAptoMenu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAptoMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAptoMenu.Size = new Size(623, 317);
            dataGridViewAptoMenu.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnAptoMenuEditar, 0, 4);
            tableLayoutPanel3.Controls.Add(btnAptoMenuEliminar, 0, 3);
            tableLayoutPanel3.Controls.Add(btnAptoMenuNuevo, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(638, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Size = new Size(153, 343);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnAptoMenuEditar
            // 
            btnAptoMenuEditar.Dock = DockStyle.Fill;
            btnAptoMenuEditar.Font = new Font("Segoe UI", 14.25F);
            btnAptoMenuEditar.Location = new Point(3, 190);
            btnAptoMenuEditar.Name = "btnAptoMenuEditar";
            btnAptoMenuEditar.Size = new Size(147, 45);
            btnAptoMenuEditar.TabIndex = 3;
            btnAptoMenuEditar.Text = "Editar";
            btnAptoMenuEditar.UseVisualStyleBackColor = true;
            btnAptoMenuEditar.Click += btnAptoMenuEditar_Click;
            // 
            // btnAptoMenuEliminar
            // 
            btnAptoMenuEliminar.Dock = DockStyle.Fill;
            btnAptoMenuEliminar.Font = new Font("Segoe UI", 14.25F);
            btnAptoMenuEliminar.Location = new Point(3, 139);
            btnAptoMenuEliminar.Name = "btnAptoMenuEliminar";
            btnAptoMenuEliminar.Size = new Size(147, 45);
            btnAptoMenuEliminar.TabIndex = 2;
            btnAptoMenuEliminar.Text = "Eliminar";
            btnAptoMenuEliminar.UseVisualStyleBackColor = true;
            btnAptoMenuEliminar.Click += btnAptoMenuEliminar_Click;
            // 
            // btnAptoMenuNuevo
            // 
            btnAptoMenuNuevo.Dock = DockStyle.Fill;
            btnAptoMenuNuevo.Font = new Font("Segoe UI", 14.25F);
            btnAptoMenuNuevo.Location = new Point(3, 37);
            btnAptoMenuNuevo.Name = "btnAptoMenuNuevo";
            btnAptoMenuNuevo.Size = new Size(147, 45);
            btnAptoMenuNuevo.TabIndex = 0;
            btnAptoMenuNuevo.Text = "Nuevo";
            btnAptoMenuNuevo.UseVisualStyleBackColor = true;
            btnAptoMenuNuevo.Click += btnAptoMenuNuevo_Click;
            // 
            // FormSeleccionarAptoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormSeleccionarAptoMenu";
            Text = "FormSeleccionarAptoMenu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBoxDatagridAptos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAptoMenu).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAptoMenuEditar;
        private Button btnAptoMenuEliminar;
        private Button btnAptoMenuNuevo;
        private GroupBox groupBoxDatagridAptos;
        private DataGridView dataGridViewAptoMenu;
        private Label label1;
    }
}