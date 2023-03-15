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

        private Tarifa tarifa;
        private ServicioTiposDeVehiculos servicioTipoVehiculo;
        private ServicioTiempoTarifa servicioTiempoTarifa;

        public Tarifa GetTarifa()
        {
            return tarifa;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicioTipoVehiculo = new ServicioTiposDeVehiculos();
            servicioTiempoTarifa = new ServicioTiempoTarifa();
            HelperCombos.CargarDatosComboTipoVehiculo(ref cbxTipoVehiculo);
            HelperCombos.CargarDatosComboTipoTarifa(ref cbxTiempoTarifa);
            if (tarifa != null)
            {
                txtDescripcion.Text = tarifa.Descripcion.ToString();
                cbxTipoVehiculo.SelectedValue = tarifa.TipoVehiculoId;
                cbxTiempoTarifa.SelectedValue = tarifa.TiempoTarifaId;
                txtImporte.Text = tarifa.Importe.ToString();

            }
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tarifa == null)
                {
                    tarifa = new Tarifa();
                }

                tarifa.Descripcion = txtDescripcion.Text;
                tarifa.TipoVehiculoId = ((TipoDeVehiculo)cbxTipoVehiculo.SelectedItem).TipoVehiculoId;
                tarifa.TipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
                tarifa.TiempoTarifaId = ((TiempoTarifa)cbxTiempoTarifa.SelectedItem).TiempoTarifaId;
                tarifa.TiempoTarifa = (TiempoTarifa)cbxTiempoTarifa.SelectedItem;
                tarifa.Importe = decimal.Parse(txtImporte.Text);

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
            if (cbxTiempoTarifa.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxTiempoTarifa, "Debe seleccionar un Tiempo de Tarifa");

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

        public void SetTarifa(Tarifa tarifa)
        {
            this.tarifa=tarifa;
        }

        private TipoDeVehiculo tipoDeVehiculo;
        private TiempoTarifa tiempoTarifa;
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

        private void cbxTiempoTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //internal void SetPais(TipoDeVehiculo tipoDeVehiculo)
        //{
        //    this.tipoDeVehiculo = this.tipoDeVehiculo;
        //}
    }
}
