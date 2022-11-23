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
    public partial class frmTiposDeVehiculos : Form
    {
        public frmTiposDeVehiculos()
        {
            InitializeComponent();
        }

        private ServicioTiposDeVehiculos servicio;
        private List<TipoDeVehiculo> lista;
        private void frmTiposDeVehiculos_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTiposDeVehiculos();
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void IconNuevo_Click(object sender, EventArgs e)
        {
            frmTipoDeVehiculoAE frm = new frmTipoDeVehiculoAE() { Text = "Nuevo Tipo de Vehiculo" };
            DialogResult dr= frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                TipoDeVehiculo tipoDeVehiculo = frm.GetTipoDeVehiculo();
                //int registrosAfectados = servicio.Agregar(tipoDeVehiculo);
                if (servicio.Existe(tipoDeVehiculo))
                {
                    //HelperMessage.Mensaje(TipoMensaje.Warning, "No se agregaron registros", "Advertencia");
                    //HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
                    HelperMessage.Mensaje(TipoMensaje.Error, "Tipo de Vehiculo existente!!!", "ERROR");
                }
                else
                {
                    //DataGridViewRow r = HelperGrid.ConstruirFila(dgvDatos);
                    //HelperGrid.SetearFila(r, tipoDeVehiculo);
                    //HelperGrid.AgregarFila(dgvDatos, r);
                    //HelperMessage.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
                    int registros = servicio.Agregar(tipoDeVehiculo);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Tipo de vehiculo agregado!!!", "Mensaje");
                    var r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, tipoDeVehiculo);
                    HelperGrid.AgregarFila(dgvDatos, r);
                }

            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        //private void MostrarDatosEnGrilla()
        //{
        //    HelperGrid.LimpiarGrilla(dgvDatos);
        //    foreach (var categoria in lista)
        //    {
        //        var r = HelperGrid.ConstruirFila(dgvDatos);
        //        HelperGrid.SetearFila(r, categoria);
        //        HelperGrid.AgregarFila(dgvDatos, r);
        //    }
        //}

        private void BorrarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = dgvDatos.SelectedRows[0];
                TipoDeVehiculo tipoDeVehiculo = (TipoDeVehiculo)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar el registro seleccionado?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                int registrosAfectados = servicio.Borrar(tipoDeVehiculo);
                if (registrosAfectados == 0)
                {
                    MessageBox.Show("No se borraron registros...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Recargar grilla
                    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);

                }
                else
                {
                    dgvDatos.Rows.Remove(r);
                    MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            TipoDeVehiculo tipoDeVehiculo = (TipoDeVehiculo) r.Tag;
            frmTipoDeVehiculoAE frm = new frmTipoDeVehiculoAE() {Text = "Editar un Tipo de Vehiculo."};
            frm.SetTipoVehiculo(tipoDeVehiculo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoDeVehiculo = frm.GetTipoDeVehiculo();
                if (servicio.Existe(tipoDeVehiculo))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Tipo de Vehiculo existente!!!", "ERROR");
                }
                else
                {
                    int registrosAfectados = servicio.Editar(tipoDeVehiculo);     
                    HelperGrid.SetearFila(r, tipoDeVehiculo); MessageBox.Show("Registro modificado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }


        //private void RecargarGrilla()
        //{
        //    try
        //    {
        //        lista = servicio.GetLista();
        //        MostrarDatosEnGrilla();
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message, "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
