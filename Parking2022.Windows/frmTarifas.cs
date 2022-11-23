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
    public partial class frmTarifas : Form
    {
        public frmTarifas()
        {
            InitializeComponent();
        }

        private ServicioTarifas servicio;
        private List<TipoDeTarifa> lista;
        private void frmTarifas_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTarifas();
            lista = servicio.GetLista();
            HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            //try
            //{
            //    lista = servicio.GetLista();
            //    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}
        }


        //private void MostrarDatosEnGrilla()
        //{
        //    HelperGrid.LimpiarGrilla(dgvDatos);
        //    foreach (var tipoDeTarifa in lista)
        //    {
        //        DataGridViewRow r = HelperGrid.ConstruirFila(dgvDatos);
        //        HelperGrid.SetearFila(r, tipoDeTarifa);
        //        HelperGrid.AgregarFila(dgvDatos, r);
        //    }
        //}

        private void IconNuevo_Click(object sender, EventArgs e)
        {
            frmTarifaAE frm = new frmTarifaAE() { Text = "Nueva Tipo de Tarifa" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                TipoDeTarifa tipoDeTarifa = frm.GetTipoTarifa();
                if (servicio.Existe(tipoDeTarifa))
                { 
                    HelperMessage.Mensaje(TipoMensaje.Error, "Tipo de tarifa existente!!!", "ERROR");
                }
                else
                {
                    int registros = servicio.Agregar(tipoDeTarifa);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Tipo de Tarifa agregado!!!", "Mensaje");
                    var r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, tipoDeTarifa);
                    HelperGrid.AgregarFila(dgvDatos, r);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void EditarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            //int registrosAfectados = 0;
            //var r = dgvDatos.SelectedRows[0];
            //TipoDeTarifa tt = (TipoDeTarifa)r.Tag;

            //try
            //{

            //    frmTarifaAE frm = new frmTarifaAE() { Text = "Editar Tipo de Tarifa." };
            //    frm.SetTipoTarifa(tt);
            //    DialogResult dr = frm.ShowDialog(this);
            //    if (dr == DialogResult.Cancel)
            //    {
            //        return;
            //    }

            //    tt = frm.GetTipoTarifa();
            //    registrosAfectados = servicio.Editar(tt);
            //    if (registrosAfectados == 0)
            //    {

            //        HelperMessage.Mensaje(TipoMensaje.Warning, "Registro editado", "Mensaje");
            //        HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);

            //    }
            //    else
            //    {
            //        HelperGrid.SetearFila(r, tt);
            //        HelperMessage.Mensaje(TipoMensaje.OK, "Registro editado", "Mensaje");

            //    }
            //}
            //catch (Exception exception)
            //{
            //    HelperGrid.SetearFila(r, tt);
            //    HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}
            var r = dgvDatos.SelectedRows[0];
            TipoDeTarifa tipoDeTarifa = (TipoDeTarifa)r.Tag;
            frmTarifaAE frm = new frmTarifaAE() { Text = "Editar Tarifa" };
            frm.SetTipoTarifa(tipoDeTarifa);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoDeTarifa = frm.GetTipoTarifa();
                if (servicio.Existe(tipoDeTarifa))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Tipo de Tarifa existente!!!", "ERROR");
                }
                else
                {
                    int registros = servicio.Editar(tipoDeTarifa);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Tarifa editada!!!", "Mensaje");
                    r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, tipoDeTarifa);
                    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void BorrarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            TipoDeTarifa tipoDeTarifa = (TipoDeTarifa)r.Tag;
            DialogResult dr = HelperMessage.Mensaje("¿Desea borrar la tarifa?", "Confirmar");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (servicio.EstaRelacionado(tipoDeTarifa))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Tarifa relacionado!!", "ERROR");
                }
                else
                {
                    int registros = servicio.Borrar(tipoDeTarifa);
                    if (registros == 0)
                    {
                        HelperMessage.Mensaje(TipoMensaje.Warning, "No se editaron registros", "Advertencia");
                    }
                    else
                    {
                        HelperGrid.BorrarFila(dgvDatos, r);

                        HelperMessage.Mensaje(TipoMensaje.OK, "tarifa borrado", "Mensaje");
                    }
                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }
    }
}
