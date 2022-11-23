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
    public partial class frmAlquilerDiarioAE : Form
    {
        public frmAlquilerDiarioAE()
        {
            InitializeComponent();
        }

        private AlquilerDiario alquilerDiario;
        private TipoDeVehiculo tipoDeVehiculo;
        private TipoDeSector tipoDeSector;
        private NrosSectores nrosSectores;
        public AlquilerDiario GetAlquilerDiario()
        {
            return alquilerDiario;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboTipoVehiculo(ref cbxTipoVehiculo);
            HelperCombos.CargarDatosComboTipoSector(ref cbxTipoSector);
            if (alquilerDiario != null)
            {
                cbxTipoVehiculo.SelectedValue = alquilerDiario.TipoVehiculoId;
                txtPatente.Text = alquilerDiario.Patente;
                cbxTipoSector.SelectedValue = alquilerDiario.TipoSectorId;
                HelperCombos.CargarDatosComboNrosSectores(ref cbxNroSector, alquilerDiario.TipoDeSector);
                cbxNroSector.SelectedValue = alquilerDiario.NroId;
                FechaDtp.Value = alquilerDiario.FechaIngreso;
                ActivoCbx.Checked = alquilerDiario.Activo;

            }
        }

        private void frmAlquilerDiarioAE_Load(object sender, EventArgs e)
        {

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (alquilerDiario == null)
                {
                    alquilerDiario = new AlquilerDiario();
                }

                alquilerDiario.TipoVehiculoId = (int)cbxTipoVehiculo.SelectedValue;
                alquilerDiario.TipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
                alquilerDiario.Patente = txtPatente.Text;
                alquilerDiario.TipoSectorId = (int)cbxTipoSector.SelectedValue;
                alquilerDiario.TipoDeSector = (TipoDeSector)cbxTipoSector.SelectedItem;
                alquilerDiario.NroId = (int)cbxNroSector.SelectedIndex;
                alquilerDiario.NrosSectores = (NrosSectores)cbxNroSector.SelectedItem;
                alquilerDiario.FechaIngreso=FechaDtp.Value;
                alquilerDiario.Activo = ActivoCbx.Checked;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        public void SetAlquilerDiario(AlquilerDiario alquilerDiario)
        {
            this.alquilerDiario = alquilerDiario;
        }

        private void cbxTipoSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoSector.SelectedIndex > 0)
            {
                tipoDeSector = (TipoDeSector)cbxTipoSector.SelectedItem;
                HelperCombos.CargarDatosComboNrosSectores(ref cbxNroSector,tipoDeSector);
            }
            else
            {
                cbxNroSector.DataSource = null;
                //cbxNroSector.Enabled = false;
            }
        }

        private void cbxNroSector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
