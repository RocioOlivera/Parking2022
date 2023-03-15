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
    public partial class frmAlquileresDiarios : Form
    {
        public frmAlquileresDiarios()
        {
            InitializeComponent();
        }
        private ServicioAlquileresEnElDia servicio;
        private ServicioNrosSectores servicioNrosSectores;
        private List<AlquilerDiario> lista;
        private AlquilerDiario alquilerDiario;

        private void frmAlquileresDiarios_Load(object sender, EventArgs e)
        {
            servicio = new ServicioAlquileresEnElDia();
            servicioNrosSectores = new ServicioNrosSectores();
            try
            {
                lista = servicio.GetListaLugaresDesocupados();
                HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        //private void RecargarGrilla()
        //{
        //    try
        //    {
        //        lista = servicio.GetLista();
        //        HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void IconNuevo_Click(object sender, EventArgs e)
        {
            frmAlquilerDiarioAE frm = new frmAlquilerDiarioAE() { Text = "Nuevo Alquiler" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                AlquilerDiario alquilerDiario = frm.GetAlquilerDiario();
                //int registros = servicio.Agregar(alquilerDiario);
                //HelperMessage.Mensaje(TipoMensaje.OK, "Alquiler agregado!!!", "Mensaje");
                //var r = HelperGrid.ConstruirFila(dgvDatos);
                //HelperGrid.SetearFila(r, alquilerDiario);
                //HelperGrid.AgregarFila(dgvDatos, r);
                int registrosAfectados = servicio.Agregar(alquilerDiario);
                if (registrosAfectados == 0)
                {
                    HelperMessage.Mensaje(TipoMensaje.Warning, "No se agregaron registros", "Advertencia");
                    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
                }
                else
                {
                    DataGridViewRow r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, alquilerDiario);
                    HelperGrid.AgregarFila(dgvDatos, r);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
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
            int registrosAfectados = 0;
            var r = dgvDatos.SelectedRows[0];
            AlquilerDiario ad = (AlquilerDiario)r.Tag;

            try
            {

                frmAlquilerDiarioAE frm = new frmAlquilerDiarioAE() { Text = "Editar Alquiler." };
                frm.SetAlquilerDiario(ad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                ad = frm.GetAlquilerDiario();
                registrosAfectados = servicio.Editar(ad);
                if (registrosAfectados == 0)
                {

                    HelperMessage.Mensaje(TipoMensaje.Warning, "No se pudo editar", "Mensaje");

                }
                else
                {
                    HelperGrid.SetearFila(r, ad);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Registro editado", "Mensaje");

                }
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, ad);
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void BorrarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = dgvDatos.SelectedRows[0];
                AlquilerDiario alquilerDiario = (AlquilerDiario)r.Tag;
                DialogResult dr = HelperMessage.Mensaje("¿Desea borrar el alquiler?", "Confirmar");
                if (dr == DialogResult.No)
                {
                    return;
                }


                int registrosAfectados = servicio.Borrar(alquilerDiario);
                if (registrosAfectados == 0)
                {
                    MessageBox.Show("No se pudo borrar el alquiler porque está activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);

                }
                else
                {
                    dgvDatos.Rows.Remove(r);
                    MessageBox.Show("El alquiler abonado ha sido eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        //Boton para actualizar el estado del sector
        private void btnFinalizarMenu_Click(object sender, EventArgs e)
        {
            lista = servicio.GetLista();
            HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            HelperMessage.Mensaje(TipoMensaje.Exclamation, "Datos actualizados.", "Aviso");

        }

        //Retirar
        private void IconRetirar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            int registrosAfectados = 0;
            var r = dgvDatos.SelectedRows[0];
            AlquilerDiario ad = (AlquilerDiario)r.Tag;

            try
            {

                frmFinalizarAlquilerAE frm = new frmFinalizarAlquilerAE() { Text = "Finalizar Alquiler." };
                frm.SetAlquilerDiario(ad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                //ad = frm.GetAlquilerDiario();
                //registrosAfectados = servicio.Borrar(ad);
                //if (registrosAfectados == 0)
                //{

                //    HelperMessage.Mensaje(TipoMensaje.Warning, "No se pudo concretar el retiro.", "Mensaje");

                //}
                //else
                //{
                //    HelperGrid.SetearFila(r, ad);
                //    HelperMessage.Mensaje(TipoMensaje.OK, "Vehiculo retirado.", "Mensaje");

                //}
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, ad);
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
            
        }
    }
}
