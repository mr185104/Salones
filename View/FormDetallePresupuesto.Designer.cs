namespace Proyecto_Salon_de_Eventos.View
{
    partial class FormDetallePresupuesto
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
            txtDetalle = new RichTextBox();
            btnCerrar = new Button();
            btnExportarPdf = new Button();
            btnPresupuestoEditar = new Button();
            btnPresupuestoClonar = new Button();
            btnPresupuestoEliminar = new Button();
            SuspendLayout();
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(62, 12);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(918, 368);
            txtDetalle.TabIndex = 1;
            txtDetalle.Text = "";
            txtDetalle.TextChanged += txtDetalle_TextChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(737, 401);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(113, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.ForeColor = Color.FromArgb(64, 0, 64);
            btnExportarPdf.Location = new Point(199, 401);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(166, 23);
            btnExportarPdf.TabIndex = 3;
            btnExportarPdf.Text = "Exportar a PDF";
            btnExportarPdf.UseVisualStyleBackColor = true;
            btnExportarPdf.Click += btnExportarPdf_Click_1;
            // 
            // btnPresupuestoEditar
            // 
            btnPresupuestoEditar.ForeColor = Color.Blue;
            btnPresupuestoEditar.Location = new Point(371, 401);
            btnPresupuestoEditar.Name = "btnPresupuestoEditar";
            btnPresupuestoEditar.Size = new Size(125, 23);
            btnPresupuestoEditar.TabIndex = 4;
            btnPresupuestoEditar.Text = "Editar";
            btnPresupuestoEditar.UseVisualStyleBackColor = true;
            btnPresupuestoEditar.Click += btnPresupuestoEditar_Click;
            // 
            // btnPresupuestoClonar
            // 
            btnPresupuestoClonar.ForeColor = Color.Green;
            btnPresupuestoClonar.Location = new Point(502, 401);
            btnPresupuestoClonar.Name = "btnPresupuestoClonar";
            btnPresupuestoClonar.Size = new Size(137, 23);
            btnPresupuestoClonar.TabIndex = 5;
            btnPresupuestoClonar.Text = "Clonar";
            btnPresupuestoClonar.UseVisualStyleBackColor = true;
            btnPresupuestoClonar.Click += btnPresupuestoClonar_Click;
            // 
            // btnPresupuestoEliminar
            // 
            btnPresupuestoEliminar.ForeColor = Color.Red;
            btnPresupuestoEliminar.Location = new Point(645, 401);
            btnPresupuestoEliminar.Name = "btnPresupuestoEliminar";
            btnPresupuestoEliminar.Size = new Size(86, 23);
            btnPresupuestoEliminar.TabIndex = 6;
            btnPresupuestoEliminar.Text = "Eliminar";
            btnPresupuestoEliminar.UseVisualStyleBackColor = true;
            btnPresupuestoEliminar.Click += btnPresupuestoEliminar_Click;
            // 
            // FormDetallePresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(btnPresupuestoEliminar);
            Controls.Add(btnPresupuestoClonar);
            Controls.Add(btnPresupuestoEditar);
            Controls.Add(btnExportarPdf);
            Controls.Add(btnCerrar);
            Controls.Add(txtDetalle);
            Name = "FormDetallePresupuesto";
            Text = "FormDetallePresupuesto";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtDetalle;
        private Button btnCerrar;
        private Button btnExportarPdf;
        private Button btnPresupuestoEditar;
        private Button btnPresupuestoClonar;
        private Button btnPresupuestoEliminar;
    }
}