using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking2022.Datos.Repositorios;
using Parking2022.Entidades.Entidades;
using Parking2022.Servicios.Servicios;
using Parking2022.Windows.Helpers;

namespace Parking2022.Windows
{
    public partial class frmFinalizarAlquilerAE : Form
    {
        public frmFinalizarAlquilerAE()
        {
            InitializeComponent();
        }

        private FinalizarAlquilerDiario finalizarAlquilerDiario;
        private ServicioAlquileresEnElDia servicio;
        private AlquilerDiario alquilerDiario;
        //private NrosSectores nrosSectores;
        private TiempoTarifa tiempoTarifa;
        private TipoDeVehiculo tipoDeVehiculo;
        private ServicioTarifas servicioImporteTarifa;
        private ServicioNrosSectores servicioNrosSectores;
        private Recaudacion recaudacion;
        private ServicioFinalizarAlquileres servicioFinalizarAlquileres;

        private void frmFinalizarAlquiler_Load(object sender, EventArgs e)
        {

        }

        public FinalizarAlquilerDiario GetFinalizarAlquilerDiario()
        {
            return finalizarAlquilerDiario;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioAlquileresEnElDia();
            servicioImporteTarifa = new ServicioTarifas();
            HelperCombos.CargarDatosComboTipoVehiculo(ref cbxTipoVehiculo);
            HelperCombos.CargarDatosComboTipoTarifa(ref cbxTiempoTarifa);
            if (alquilerDiario != null)
            {

                txtTipoVehiculo.Text = alquilerDiario.TipoDeVehiculo.TipoVehiculo.ToString();
                txtPatente.Text = alquilerDiario.Patente;
                txtTipoSec.Text = alquilerDiario.TipoDeSector.TipoSector;
                txtNro.Text = alquilerDiario.NrosSectores.Nro;
                txtFechaIngreso.Text = alquilerDiario.FechaIngreso.ToString();
                //lblTotalHoras.Text = Math.Truncate(DateTime.Now.Subtract(alquilerDiario.FechaIngreso).TotalHours).ToString();

                var TotalHoras = Math.Truncate(DateTime.Now.Subtract(alquilerDiario.FechaIngreso).TotalHours).ToString();
                lblTotalHoras.Text = TotalHoras;

                cbxTipoVehiculo.SelectedValue = alquilerDiario.TipoVehiculoId;
                cbxTiempoTarifa.SelectedValue = alquilerDiario.TiempotarifaId;
                HelperCombos.CargarDatosComboCostoTarifa(ref cbxImporteAPagar, alquilerDiario.TipoDeVehiculo, alquilerDiario.TiempoTarifa);
                cbxImporteAPagar.SelectedValue = alquilerDiario.TarifaId;
                
            }
            
            //base.OnLoad(e);
            //servicio = new ServicioAlquileresEnElDia();
            ////HelperCombos.CargarDatosComboTipoTarifa(ref cbxTipoTarifa);
            //if (alquilerDiario != null)
            //{
            //    //txtTipoVehiculo.Text = alquilerDiario.TipoDeVehiculo.ToString();
            //    //txtPatente.Text = alquilerDiario.Patente;
            //    //txtTipoSec.Text = alquilerDiario.TipoDeSector.TipoSector;
            //    //txtNro.Text = alquilerDiario.NrosSectores.Nro;
            //    //txtFechaIngreso.Text = alquilerDiario.FechaIngreso.ToLongDateString();
            //    FechaDtp.Value = alquilerDiario.FechaIngreso;
            //    DateTime horaentrada = FechaDtp.Value;
            //    DateTime horaSalida = HoraSalidaDtp.Value;
            //    var cantidadHoras = ((ushort) (horaSalida - horaentrada).TotalHours).ToString();
            //    lblTotalHoras.Text = cantidadHoras.ToString();
            //    cxbPagado.Checked = alquilerDiario.Pagado;
            //    cbxRetirado.Checked = alquilerDiario.Retirado;

            //}
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            //if (ValidarDatos())
            //{
            //    if (alquilerDiario == null)
            //    {
            //        alquilerDiario = new AlquilerDiario();
            //    }

            //    alquilerDiario.FechaIngreso = HoraSalidaDtp.Value;
            //    alquilerDiario.TiempoTotal =  finalizarAlquilerDiario.TotalHoras;
            //    alquilerDiario.TiempotarifaId = ((TiempoTarifa) cbxTiempoTarifa.SelectedItem).TiempoTarifaId;
            //    alquilerDiario.TiempoTarifa = (TiempoTarifa) cbxTiempoTarifa.SelectedItem;
            //    alquilerDiario.TarifaId = ((Tarifa)cbxImporteAPagar.SelectedItem).TarifaId;
            //    alquilerDiario.Tarifa = (Tarifa)cbxImporteAPagar.SelectedItem;
            //    //alquilerDiario.FechaSalida = FechaDtp.Value;
            //    //ActualizarEstado();
            //    DialogResult = DialogResult.OK;
            //}

        }

        //private void ActualizarEstado()
        //{
        //    int ID = alquilerDiario.NroId;
        //    bool Ocupado = false;
        //    servicioNrosSectores.ActualizarEstado(ID, Ocupado);
        //}

        private bool ValidarDatos()
        {
            return true;
        }

        public void SetAlquilerDiario(AlquilerDiario ad)
        {
            this.alquilerDiario = ad;
        }

        public AlquilerDiario GetAlquilerDiario()
        {
            return alquilerDiario;
        }

        //private void CalcularImporteTotal()
        //{
        //    int Horas = Convert.ToInt32(lblTotalHoras);
        //    if (Horas<=0)
        //    {
                
        //    }
        //}

        private void cbxTiempoTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTiempoTarifa.SelectedIndex > 0)
            {
                tiempoTarifa = (TiempoTarifa)cbxTiempoTarifa.SelectedItem;
                HelperCombos.CargarDatosComboCostoTarifa(ref cbxImporteAPagar, tipoDeVehiculo, tiempoTarifa);
            }
            else
            {
                cbxImporteAPagar.DataSource = null;
                //cbxNroSector.Enabled = false;
            }
        }

        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoVehiculo.SelectedIndex > 0)
            {
                tipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
                HelperCombos.CargarDatosComboTipoTarifa(ref cbxTiempoTarifa);
            }
            else
            {
                cbxTiempoTarifa.DataSource = null;
                //cbxNroSector.Enabled = false;
            }
        }

        private void cbxImporteAPagar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuardarIconButton_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatosFinalizacion())
            { 
                txtImporte.Enabled = true;
                btnEfectivo.Enabled = true;

                txtImporte.Text = cbxImporteAPagar.Text;
                picCuadroTarifario.Visible = false;



            }


        }

        private bool ValidarDatosFinalizacion()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (cbxTiempoTarifa.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxTiempoTarifa, "Debe seleccionar el tipo de tarifa!");

            }

            return valido;
        }

        private void cbxImporteAPagar_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbxTiempoTarifa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxTiempoTarifa.SelectedIndex > 0)
            {
                tiempoTarifa = (TiempoTarifa)cbxTiempoTarifa.SelectedItem;
                HelperCombos.CargarDatosComboCostoTarifa(ref cbxImporteAPagar, tipoDeVehiculo, tiempoTarifa);
            }
            else
            {
                cbxImporteAPagar.DataSource = null;
                //cbxNroSector.Enabled = false;
            }
        }

        private void cbxTipoVehiculo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxTipoVehiculo.SelectedIndex > 0)
            {
                tipoDeVehiculo = (TipoDeVehiculo)cbxTipoVehiculo.SelectedItem;
                HelperCombos.CargarDatosComboTipoTarifa(ref cbxTiempoTarifa);
            }
            else
            {
                cbxTiempoTarifa.DataSource = null;
                //cbxNroSector.Enabled = false;
            }
        }

        private void CancelarIconButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if (ValidarDatosFinalizacionPago())
            {
                double vuelto;
                double importeAPagar = Convert.ToDouble(txtImporte.Text);
                double dineroRecibido = Convert.ToDouble(txtDineroRecibido.Text);
                //DateTime Fecha= DateTime.Now;


                if (dineroRecibido <= 0)
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "El importe debe ser mayor que 0.", "Error");
                    return;
                }
                else if (dineroRecibido < importeAPagar)
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "El pago recibido es inferior al importe total a pagar.",
                        "Error");
                    return;
                }
                else
                {
                    vuelto = dineroRecibido - importeAPagar;
                    txtVuelto.Text = vuelto.ToString();
                    PictureTilde.Visible = true;

                    //int ID = alquilerDiario.AlquilerEnElDiaId;
                    //bool desocupado = false;
                    //servicioNrosSectores.ActualizarEstado(ID, desocupado);

                    int IDD = alquilerDiario.AlquilerEnElDiaId;
                    bool pagado = true;
                    servicio.ActualizarPago(IDD, pagado);

                    ActualizarEstadoSalida();
                    //ActualizarEstadoAlRetirar();

                    //servicio.Retirar(alquilerDiario);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Pago finalizado con éxito!", "Mensaje");

                    
                    AgregarRecaudacion();

                    Close();
            
                }
            }
           
        }

        private void ActualizarEstadoSalida()
        {
            ServicioNrosSectores servicioNros = new ServicioNrosSectores();
            int ID = alquilerDiario.NroId;
            servicioNros.ActualizarEstadoSalida(ID);
        }

        private bool ValidarDatosFinalizacionPago()
        {
            errorProvider1.Clear();
            bool valido = true;
            
            if (string.IsNullOrEmpty(txtDineroRecibido.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtDineroRecibido, "El monto del dinero recibido es requerido!");
            }
            if (!decimal.TryParse(txtDineroRecibido.Text, out decimal precioResult))
            {
                valido = false;
                errorProvider1.SetError(txtDineroRecibido, "Monto mal ingresado");
            }
            else if (precioResult <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtDineroRecibido, "El monto no debe ser menor que 0");
            }
            return valido;
            
        }

        private void IconEfectivo_Click(object sender, EventArgs e)
        {
            txtDineroRecibido.Enabled = true;
            txtDineroRecibido.Focus();
            iconButton1.Enabled = true;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            txtDineroRecibido.Enabled = true;
            txtDineroRecibido.Focus();
            iconButton1.Enabled = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void AgregarRecaudacion()
        {
            ServicioFinalizarAlquileres servicioFin = new ServicioFinalizarAlquileres();
            Recaudacion recaudacion = new Recaudacion();
            recaudacion.Monto = Convert.ToDecimal(txtImporte.Text);
            recaudacion.Fecha = DateTime.Now.Date;
            servicioFin.Agregar(recaudacion);

        }

        private Recaudacion GetRecaudacion()
        {
            return recaudacion;
        }
    }
}
    

