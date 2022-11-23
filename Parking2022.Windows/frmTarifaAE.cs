using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking2022.Entidades.Entidades;
using Parking2022.Servicios.Servicios;
using Parking2022.Windows.Helpers;

namespace Parking2022.Windows
{
    public partial class frmTarifaAE : Form
    {
        public frmTarifaAE()
        {
            InitializeComponent();
        }

        private TipoDeTarifa tipoDeTarifa;
        private ServicioTiposDeVehiculos servicio;

        public TipoDeTarifa GetTipoTarifa()
        {
            return tipoDeTarifa;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioTiposDeVehiculos();
            HelperCombos.CargarDatosComboTipoVehiculo(ref cbxTipoVehiculo);
            if (tipoDeTarifa != null)
            {
                cbxTipoVehiculo.SelectedValue = tipoDeTarifa.TipoVehiculoId;
                txtHora.Text = tipoDeTarifa.Hora.ToString();
                txtMediaEstadia.Text = tipoDeTarifa.MediaEstadia.ToString();
                txtEstadia.Text = tipoDeTarifa.Estadia.ToString();
                txtNoche.Text = tipoDeTarifa.Noche.ToString();
                //txtSemana.Text = tipoDeTarifa.Semana.ToString();
                //txtQuincena.Text = tipoDeTarifa.Quincena.ToString();
                //txtMes.Text = tipoDeTarifa.Mes.ToString();
            }
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeTarifa == null)
                {
                    tipoDeTarifa = new TipoDeTarifa();
                }

                tipoDeTarifa.TipoVehiculoId = (int) cbxTipoVehiculo.SelectedValue;
                tipoDeTarifa.TipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
                tipoDeTarifa.Hora = decimal.Parse(txtHora.Text);
                tipoDeTarifa.MediaEstadia = int.Parse(txtMediaEstadia.Text);
                tipoDeTarifa.Estadia = int.Parse(txtEstadia.Text);
                tipoDeTarifa.Noche = int.Parse(txtNoche.Text);
                //tipoDeTarifa.Semana = int.Parse(txtSemana.Text);
                //tipoDeTarifa.Quincena = int.Parse(txtQuincena.Text);
                //tipoDeTarifa.Mes = int.Parse(txtMes.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (cbxTipoVehiculo.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxTipoVehiculo, "Debe seleccionar un Vehiculo");

            }
            return valido;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtTipoVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetTipoTarifa(TipoDeTarifa tipoDeTarifa)
        {
            this.tipoDeTarifa=tipoDeTarifa;
        }

        private TipoDeVehiculo tipoDeVehiculo;
        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
            //HelperCombos.CargarDatosComboTipoVehiculo(ref cbxTipoVehiculo);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTarifaAE_Load(object sender, EventArgs e)
        {

        }

        //internal void SetPais(TipoDeVehiculo tipoDeVehiculo)
        //{
        //    this.tipoDeVehiculo = this.tipoDeVehiculo;
        //}
    }
}
