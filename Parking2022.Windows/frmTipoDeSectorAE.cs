using Parking2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking2022.Windows.Helpers;

namespace Parking2022.Windows
{
    public partial class frmTipoDeSectorAE : Form
    {
        public frmTipoDeSectorAE()
        {
            InitializeComponent();
        }

        private TipoDeSector tipoDeSector;
        private void frmTipoDeSectorAE_Load(object sender, EventArgs e)
        {

        }

        public TipoDeSector GetTipoDeSector()
        {
            return tipoDeSector;
        }

        public void SetTipoSector(TipoDeSector tipoDeSector)
        {
            this.tipoDeSector = tipoDeSector;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = HelperMessage.Mensaje("¿Desea cancelar el ingreso del nuevo sector?", "Confirmar");
            if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeSector == null)
                {
                    tipoDeSector = new TipoDeSector();
                }

                tipoDeSector.TipoSector = txtTipoSector.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtTipoSector.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTipoSector, "El nombre del sector es requerido");
            }

            return valido;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeSector != null)
            {
                txtTipoSector.Text = tipoDeSector.TipoSector;
            }
        }
    }
}
