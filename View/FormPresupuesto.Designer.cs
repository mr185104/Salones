namespace Proyecto_Salon_de_Eventos.View
{
    partial class FormPresupuesto
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
            lblPresupuestoTest = new Label();
            dataGridView1 = new DataGridView();
            btnCrearPresupuesto = new Button();
            btnResetBaseDatos = new Button();
            txtBoxBuscarPresupuesto = new TextBox();
            label1 = new Label();
            txtBoxPrecioMaximo = new TextBox();
            label2 = new Label();
            btnPresupuestoDetalles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblPresupuestoTest
            // 
            lblPresupuestoTest.AutoSize = true;
            lblPresupuestoTest.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPresupuestoTest.Location = new Point(488, 20);
            lblPresupuestoTest.Name = "lblPresupuestoTest";
            lblPresupuestoTest.Size = new Size(279, 50);
            lblPresupuestoTest.TabIndex = 0;
            lblPresupuestoTest.Text = "PRESUPUESTOS";
            lblPresupuestoTest.TextAlign = ContentAlignment.TopCenter;
            lblPresupuestoTest.Click += lblPresupuestoTest_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1131, 386);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnCrearPresupuesto
            // 
            btnCrearPresupuesto.Location = new Point(411, 625);
            btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            btnCrearPresupuesto.Size = new Size(194, 71);
            btnCrearPresupuesto.TabIndex = 5;
            btnCrearPresupuesto.Text = "Crear Presupuesto";
            btnCrearPresupuesto.UseVisualStyleBackColor = true;
            btnCrearPresupuesto.Click += button1_Click_1;
            // 
            // btnResetBaseDatos
            // 
            btnResetBaseDatos.Location = new Point(1310, 673);
            btnResetBaseDatos.Name = "btnResetBaseDatos";
            btnResetBaseDatos.Size = new Size(179, 23);
            btnResetBaseDatos.TabIndex = 6;
            btnResetBaseDatos.Text = "Borrar base de datos completa";
            btnResetBaseDatos.UseVisualStyleBackColor = true;
            btnResetBaseDatos.Click += btnResetBaseDatos_Click;
            // 
            // txtBoxBuscarPresupuesto
            // 
            txtBoxBuscarPresupuesto.Location = new Point(320, 94);
            txtBoxBuscarPresupuesto.MinimumSize = new Size(0, 30);
            txtBoxBuscarPresupuesto.Name = "txtBoxBuscarPresupuesto";
            txtBoxBuscarPresupuesto.Size = new Size(377, 30);
            txtBoxBuscarPresupuesto.TabIndex = 7;
            txtBoxBuscarPresupuesto.TextChanged += txtBoxBuscarPresupuesto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 99);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 8;
            label1.Text = "Buscar";
            // 
            // txtBoxPrecioMaximo
            // 
            txtBoxPrecioMaximo.Location = new Point(1028, 93);
            txtBoxPrecioMaximo.MinimumSize = new Size(0, 30);
            txtBoxPrecioMaximo.Name = "txtBoxPrecioMaximo";
            txtBoxPrecioMaximo.Size = new Size(100, 23);
            txtBoxPrecioMaximo.TabIndex = 9;
            txtBoxPrecioMaximo.TextChanged += txtBoxPrecioMaximo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(922, 99);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 10;
            label2.Text = "Precio Maximo";
            // 
            // btnPresupuestoDetalles
            // 
            btnPresupuestoDetalles.Location = new Point(694, 625);
            btnPresupuestoDetalles.Name = "btnPresupuestoDetalles";
            btnPresupuestoDetalles.Size = new Size(194, 71);
            btnPresupuestoDetalles.TabIndex = 11;
            btnPresupuestoDetalles.Text = "Detalles";
            btnPresupuestoDetalles.UseVisualStyleBackColor = true;
            btnPresupuestoDetalles.Click += btnPresupuestoDetalles_Click;
            // 
            // FormPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 740);
            Controls.Add(btnPresupuestoDetalles);
            Controls.Add(label2);
            Controls.Add(txtBoxPrecioMaximo);
            Controls.Add(label1);
            Controls.Add(txtBoxBuscarPresupuesto);
            Controls.Add(btnResetBaseDatos);
            Controls.Add(btnCrearPresupuesto);
            Controls.Add(dataGridView1);
            Controls.Add(lblPresupuestoTest);
            Name = "FormPresupuesto";
            Text = "FormPresupuesto";
            Load += FormPresupuesto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPresupuestoTest;
        private DataGridView dataGridView1;
        private Button btnCrearPresupuesto;
        private Button btnResetBaseDatos;
        private TextBox txtBoxBuscarPresupuesto;
        private Label label1;
        private TextBox txtBoxPrecioMaximo;
        private Label label2;
        private Button btnPresupuestoDetalles;
    }
}