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
    public partial class frmTiposDeSectores : Form
    {
        public frmTiposDeSectores()
        {
            InitializeComponent();
        }

        private ServicioTiposDeSectores servicio;
        private List<TipoDeSector> lista;
        private void frmTiposDeSectores_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTiposDeSectores();
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
            frmTipoDeSectorAE frm = new frmTipoDeSectorAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                TipoDeSector tipoDeSector = frm.GetTipoDeSector();
                int registrosAfectados = servicio.Agregar(tipoDeSector);
                if (registrosAfectados == 0)
                {
                    HelperMessage.Mensaje(TipoMensaje.Warning, "No se agregaron registros", "Advertencia");
                    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
                }
                else
                {
                    DataGridViewRow r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, tipoDeSector);
                    HelperGrid.AgregarFila(dgvDatos, r);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
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

            try
            {
                var r = dgvDatos.SelectedRows[0];
                TipoDeSector tipoDeSector = (TipoDeSector)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar el registro seleccionado?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                int registrosAfectados = servicio.Borrar(tipoDeSector);
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
            TipoDeSector tipoDeSector = (TipoDeSector)r.Tag;
            frmTipoDeSectorAE frm = new frmTipoDeSectorAE() { Text = "Editar un Tipo de Sector." };
            frm.SetTipoSector(tipoDeSector);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoDeSector = frm.GetTipoDeSector();
                if (servicio.Existe(tipoDeSector))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Tipo de Sector existente!!!", "ERROR");
                }
                else
                {
                    int registrosAfectados = servicio.Editar(tipoDeSector);
                    HelperGrid.SetearFila(r, tipoDeSector); MessageBox.Show("Registro modificado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
