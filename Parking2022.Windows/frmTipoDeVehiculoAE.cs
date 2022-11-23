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

namespace Parking2022.Windows
{
    public partial class frmTipoDeVehiculoAE : Form
    {
        public frmTipoDeVehiculoAE()
        {
            InitializeComponent();
        }

        private TipoDeVehiculo tipoDeVehiculo;

        public TipoDeVehiculo GetTipoDeVehiculo()
        {
            return tipoDeVehiculo;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeVehiculo == null)
                {
                    tipoDeVehiculo = new TipoDeVehiculo();
                }

                tipoDeVehiculo.TipoVehiculo = txtTipoVehiculo.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtTipoVehiculo.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTipoVehiculo, "El nombre del tipo de vehiculo es requerido");
            }

            return valido;
        }

        public void SetTipoVehiculo(TipoDeVehiculo tipoDeVehiculo)
        {
            this.tipoDeVehiculo = tipoDeVehiculo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeVehiculo != null)
            {
                txtTipoVehiculo.Text = tipoDeVehiculo.TipoVehiculo;
            }
        }
        private void frmTipoDeVehiculoAE_Load(object sender, EventArgs e)
        {

        }
    }
}
