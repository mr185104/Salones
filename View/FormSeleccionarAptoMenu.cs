using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Dto;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormSeleccionarAptoMenu : Form
    {
        private readonly AptoMenuController _controller;

        /// <summary>
        /// Devuelve el AptoMenu seleccionado en la grilla.
        /// </summary>
        public AptoMenuDto? AptoSeleccionado { get; private set; }

        public FormSeleccionarAptoMenu()
        {
            InitializeComponent();
            _controller = new AptoMenuController();

            // Suscripción al evento Shown para garantizar que la UI esté visible antes de armar la grilla
            this.Shown += FormSeleccionarAptoMenu_Shown;

            if (dataGridViewAptoMenu != null)
            {
                dataGridViewAptoMenu.CellDoubleClick += dataGridViewAptoMenu_CellDoubleClick;
            }
        }

        private void FormSeleccionarAptoMenu_Shown(object? sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarGrilla();
        }

        private void ConfigurarGrilla()
        {
            if (dataGridViewAptoMenu == null) return;

            dataGridViewAptoMenu.SuspendLayout();

            dataGridViewAptoMenu.AutoGenerateColumns = false;
            dataGridViewAptoMenu.Columns.Clear();

            dataGridViewAptoMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAptoMenu.MultiSelect = false;
            dataGridViewAptoMenu.ReadOnly = true;
            dataGridViewAptoMenu.AllowUserToAddRows = false;
            dataGridViewAptoMenu.AllowUserToDeleteRows = false;
            dataGridViewAptoMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAptoMenu.ColumnHeadersVisible = true;
            dataGridViewAptoMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAptoMenu.ColumnHeadersHeight = 35;
            dataGridViewAptoMenu.EnableHeadersVisualStyles = true;

            dataGridViewAptoMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dataGridViewAptoMenu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAptoMenu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                FillWeight = 25,
                Resizable = DataGridViewTriState.False
            };

            DataGridViewTextBoxColumn colDetalle = new DataGridViewTextBoxColumn
            {
                Name = "colDetalle",
                HeaderText = "Detalle",
                DataPropertyName = "Detalle",
                FillWeight = 75,
                Resizable = DataGridViewTriState.False
            };

            dataGridViewAptoMenu.Columns.Add(colId);
            dataGridViewAptoMenu.Columns.Add(colDetalle);

            dataGridViewAptoMenu.ResumeLayout();
        }

        private void CargarGrilla()
        {
            if (dataGridViewAptoMenu == null) return;

            List<AptoMenuDto> lista = _controller.ListarAptosMenu()?.ToList() ?? new List<AptoMenuDto>();

            dataGridViewAptoMenu.DataSource = null;
            dataGridViewAptoMenu.DataSource = lista;

            AptoSeleccionado = ObtenerSeleccionado();
        }

        // --- MÉTODO DUAL DE SELECCIÓN ---
        private void SeleccionarApto(AptoMenuDto aptoDto)
        {
            if (aptoDto == null) return;

            AptoSeleccionado = aptoDto;

            if (this.Modal || this.Owner != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridViewAptoMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewAptoMenu.Rows[e.RowIndex].DataBoundItem is AptoMenuDto dto)
            {
                SeleccionarApto(dto);
            }
        }

        // --- BOTÓN NUEVO ---
        private void btnAptoMenuNuevo_Click(object sender, EventArgs e)
        {
            string nuevoDetalle = MostrarDialogoTexto("Nuevo AptoMenu", "Ingrese el detalle del AptoMenu (ej: Celíaco):");

            if (!string.IsNullOrWhiteSpace(nuevoDetalle))
            {
                string mensaje = _controller.CrearAptoMenu(nuevoDetalle);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
        }

        // --- BOTÓN EDITAR ---
        private void btnAptoMenuEditar_Click(object sender, EventArgs e)
        {
            AptoMenuDto? seleccionado = ObtenerSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un AptoMenu para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string detalleEditado = MostrarDialogoTexto("Editar AptoMenu", "Modifique el detalle:", seleccionado.Detalle);

            if (!string.IsNullOrWhiteSpace(detalleEditado) && detalleEditado != seleccionado.Detalle)
            {
                string mensaje = _controller.ActualizarAptoMenu(seleccionado.Id, detalleEditado);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
        }

        // --- BOTÓN ELIMINAR ---
        private void btnAptoMenuEliminar_Click(object sender, EventArgs e)
        {
            AptoMenuDto? seleccionado = ObtenerSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un AptoMenu para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar '{seleccionado.Detalle}' (ID: {seleccionado.Id})?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                string mensaje = _controller.EliminarAptoMenu(seleccionado.Id);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
        }

        // --- MOCK: AGREGAR 10 EJEMPLOS ---
        private void btnMockagregar10ejemplos_Click(object sender, EventArgs e)
        {
            string[] ejemplos = new string[]
            {
                "Celíaco (Sin TACC)",
                "Vegano",
                "Vegetariano",
                "Sin Lactosa",
                "Diabético (Sin Azúcar Agregada)",
                "Hipertenso (Bajo en Sodio)",
                "Sin huevo",
                "Orgánico",
                "Kosher",
                "Halal"
            };

            int creados = 0;
            foreach (string ejemplo in ejemplos)
            {
                string res = _controller.CrearAptoMenu(ejemplo);
                if (res.Contains("correctamente"))
                {
                    creados++;
                }
            }

            MessageBox.Show($"Se agregaron {creados} nuevos registros de prueba.", "Mock Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrilla();
        }

        // --- SELECCIÓN EN LA GRILLA ---
        private void dataGridViewAptoMenu_SelectionChanged(object sender, EventArgs e)
        {
            AptoSeleccionado = ObtenerSeleccionado();
        }

        private AptoMenuDto? ObtenerSeleccionado()
        {
            if (dataGridViewAptoMenu?.CurrentRow != null && dataGridViewAptoMenu.CurrentRow.DataBoundItem is AptoMenuDto dto)
            {
                return dto;
            }
            return null;
        }

        // --- DIÁLOGO RÁPIDO PARA PEDIR TEXTO ---
        private string MostrarDialogoTexto(string titulo, string prompt, string valorPredeterminado = "")
        {
            using Form formPrompt = new Form()
            {
                Width = 400,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titulo,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblText = new Label() { Left = 20, Top = 15, Text = prompt, AutoSize = true };
            TextBox txtInput = new TextBox() { Left = 20, Top = 40, Width = 340, Text = valorPredeterminado };
            Button btnOk = new Button() { Text = "Aceptar", Left = 180, Width = 80, Top = 75, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancelar", Left = 280, Width = 80, Top = 75, DialogResult = DialogResult.Cancel };

            formPrompt.Controls.Add(lblText);
            formPrompt.Controls.Add(txtInput);
            formPrompt.Controls.Add(btnOk);
            formPrompt.Controls.Add(btnCancel);
            formPrompt.AcceptButton = btnOk;
            formPrompt.CancelButton = btnCancel;

            DialogResult resultadoDialogo = formPrompt.ShowDialog(this);

            return resultadoDialogo == DialogResult.OK ? txtInput.Text.Trim() : string.Empty;
        }
    }
}