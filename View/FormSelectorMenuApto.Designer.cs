namespace Proyecto_Salon_de_Eventos.View
{
    partial class FormSelectorMenuApto
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
            tableLayoutPanel2 = new TableLayoutPanel();
            chklistMenuAptoSeleccion = new CheckedListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnMenuAptoConfirmar = new Button();
            btnMenuAptoCancelar = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(chklistMenuAptoSeleccion, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(940, 536);
            tableLayoutPanel2.TabIndex = 55;
            // 
            // chklistMenuAptoSeleccion
            // 
            chklistMenuAptoSeleccion.CheckOnClick = true;
            chklistMenuAptoSeleccion.Dock = DockStyle.Fill;
            chklistMenuAptoSeleccion.FormattingEnabled = true;
            chklistMenuAptoSeleccion.Location = new Point(0, 0);
            chklistMenuAptoSeleccion.Margin = new Padding(0);
            chklistMenuAptoSeleccion.Name = "chklistMenuAptoSeleccion";
            chklistMenuAptoSeleccion.Size = new Size(940, 428);
            chklistMenuAptoSeleccion.TabIndex = 59;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnMenuAptoConfirmar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnMenuAptoCancelar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 431);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(934, 102);
            tableLayoutPanel1.TabIndex = 60;
            // 
            // btnMenuAptoConfirmar
            // 
            btnMenuAptoConfirmar.Dock = DockStyle.Fill;
            btnMenuAptoConfirmar.Location = new Point(470, 3);
            btnMenuAptoConfirmar.Name = "btnMenuAptoConfirmar";
            btnMenuAptoConfirmar.Size = new Size(461, 96);
            btnMenuAptoConfirmar.TabIndex = 59;
            btnMenuAptoConfirmar.Text = "Confirmar";
            btnMenuAptoConfirmar.UseVisualStyleBackColor = true;
            btnMenuAptoConfirmar.Click += btnMenuAptoConfirmar_Click;
            // 
            // btnMenuAptoCancelar
            // 
            btnMenuAptoCancelar.Dock = DockStyle.Fill;
            btnMenuAptoCancelar.Location = new Point(3, 3);
            btnMenuAptoCancelar.Name = "btnMenuAptoCancelar";
            btnMenuAptoCancelar.Size = new Size(461, 96);
            btnMenuAptoCancelar.TabIndex = 58;
            btnMenuAptoCancelar.Text = "Cancelar";
            btnMenuAptoCancelar.UseVisualStyleBackColor = true;
            btnMenuAptoCancelar.Click += btnMenuAptoCancelar_Click;
            // 
            // FormSelectorMenuApto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 536);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            Name = "FormSelectorMenuApto";
            Text = "FormMenuApto";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox chklistMenuAptoSeleccion;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnMenuAptoConfirmar;
        private Button btnMenuAptoCancelar;
    }
}