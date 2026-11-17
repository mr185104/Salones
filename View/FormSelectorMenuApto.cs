using Proyecto_Salon_de_Eventos.Controller;
using Proyecto_Salon_de_Eventos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.View
{
    public partial class FormSelectorMenuApto : Form
    {
        private readonly AptoMenuController _controller;
        private readonly List<AptoMenuDto> _seleccionadosPrevios;

        // Constructor: recibe opcionalmente la lista de seleccionados previos
        public FormSelectorMenuApto(List<AptoMenuDto> seleccionadosPrevios = null)
        {
            InitializeComponent();
            _controller = new AptoMenuController();
            _seleccionadosPrevios = seleccionadosPrevios ?? new List<AptoMenuDto>();

            CargarOpciones();
        }

        // Propiedad pública para devolver lo seleccionado
        public List<AptoMenuDto> Seleccionados
        {
            get
            {
                List<AptoMenuDto> seleccionados = chklistMenuAptoSeleccion.CheckedItems
                    .Cast<AptoMenuDto>()
                    .ToList();

                return seleccionados;
            }
        }

        private void CargarOpciones()
        {
            List<AptoMenuDto> lista = _controller.ListarAptosMenu()?.ToList() ?? new List<AptoMenuDto>();

            chklistMenuAptoSeleccion.DataSource = lista;
            chklistMenuAptoSeleccion.DisplayMember = "Detalle";

            // Marcar los ítems que ya estaban seleccionados
            for (int i = 0; i < lista.Count; i++)
            {
                bool estabaSeleccionado = _seleccionadosPrevios.Any(s => s.Id == lista[i].Id);
                if (estabaSeleccionado)
                {
                    chklistMenuAptoSeleccion.SetItemChecked(i, true);
                }
            }
        }

        private void btnMenuAptoConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMenuAptoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
