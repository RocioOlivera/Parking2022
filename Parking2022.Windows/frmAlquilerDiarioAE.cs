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
using Parking2022.Servicios.Servicios;
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
        private ServicioAlquileresEnElDia servicio;
        private ServicioNrosSectores servicioNrosSectores;
        public AlquilerDiario GetAlquilerDiario()
        {
            return alquilerDiario;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioAlquileresEnElDia();
            servicioNrosSectores = new ServicioNrosSectores();
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
//                ActivoCbx.Checked = alquilerDiario.Activo;

            }
        }

        private void frmAlquilerDiarioAE_Load(object sender, EventArgs e)
        {

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = HelperMessage.Mensaje("¿Desea cancelar el ingreso de un nuevo alquiler?", "Confirmar");
            if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (alquilerDiario == null)
                {
                    alquilerDiario = new AlquilerDiario();
                }

                alquilerDiario.TipoVehiculoId = ((TipoDeVehiculo)cbxTipoVehiculo.SelectedItem).TipoVehiculoId;
                alquilerDiario.TipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
                alquilerDiario.Patente = txtPatente.Text;
                alquilerDiario.TipoSectorId = ((TipoDeSector)cbxTipoSector.SelectedItem).TipoSectorId;
                alquilerDiario.TipoDeSector = (TipoDeSector)cbxTipoSector.SelectedItem;
                alquilerDiario.NroId = ((NrosSectores)cbxNroSector.SelectedItem).NroId;
                alquilerDiario.NrosSectores = (NrosSectores)cbxNroSector.SelectedItem;
                alquilerDiario.FechaIngreso = FechaDtp.Value;
                ActualizarEstado();
                DialogResult = DialogResult.OK;
            }
        }

        private void ActualizarEstado()
        {
            int ID = alquilerDiario.NroId;
            bool Ocupado = true;
            servicioNrosSectores.ActualizarEstado(ID,Ocupado);
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (cbxTipoVehiculo.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxTipoVehiculo, "Debe seleccionar un tipo de vehiculo");
            }

            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                valido = false;
                errorProvider1.SetError(txtPatente, "La patente es obligatoria.");
            }

            if (cbxTipoSector.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxTipoSector, "Debe seleccionar un tipo de sector.");
            }

            if (cbxNroSector.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxNroSector, "Debe seleccionar un numero para el sector.");
            }

            return valido;
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

        internal void SetAlquiler(AlquilerDiario alquiler)
        {
            throw new NotImplementedException();
        }

        private void btnGuardarRetiro_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (alquilerDiario == null)
                {
                    alquilerDiario = new AlquilerDiario();
                }


                //alquilerDiario.FechaSalida = dtkFechaSalida.Value;
                //alquilerDiario.TiempoTotal = dtpTiempoTotal.Value;
                //alquilerDiario.TipoTarifaId = ((Tarifa)cbxTipoTarifa.SelectedItem).TarifaId;
                //alquilerDiario.Tarifa = (Tarifa)cbxTipoTarifa.SelectedItem;


                //alquilerDiario.Patente = txtPatente.Text;
                //alquilerDiario.TipoSectorId = ((TipoDeSector)cbxTipoSector.SelectedItem).TipoSectorId;
                //alquilerDiario.TipoDeSector = (TipoDeSector)cbxTipoSector.SelectedItem;
                //alquilerDiario.NroId = ((NrosSectores)cbxNroSector.SelectedItem).NroId;
                //alquilerDiario.NrosSectores = (NrosSectores)cbxNroSector.SelectedItem;
                //alquilerDiario.FechaIngreso = FechaDtp.Value;
                //alquilerDiario.Activo = ActivoCbx.Checked;
                //ActualizarEstado();
                //DialogResult = DialogResult.OK;
            }
        }

        private void cbxTipoTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
