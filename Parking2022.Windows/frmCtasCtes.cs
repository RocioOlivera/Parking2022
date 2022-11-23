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

namespace Parking2022.Windows
{
    public partial class frmCtasCtes : Form
    {
        public frmCtasCtes()
        {
            InitializeComponent();
        }

        private ServicioCtasCtes servicio;
        private List<CtaCte> lista;
        private void frmCtasCtes_Load(object sender, EventArgs e)
        {
            servicio = new ServicioCtasCtes();
            this.Dock = DockStyle.Fill;
            try
            {
                lista = servicio.GetSaldos();
                MostrarDatosGrilla(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarDatosGrilla(List<CtaCte> lista)
        {
            dgvDatos.Rows.Clear();
            foreach (var item in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, CtaCte item)
        {
            r.Cells[cmnCliente.Index].Value = item.Cliente.ApellidoYNombre;
            r.Cells[cmnSaldo.Index].Value = item.Saldo;
            if (item.Saldo > 0)
            {
                r.Cells[cmnSaldo.Index].Style.BackColor = Color.Red;
            }
            else if (item.Saldo <= 0)
            {
                r.Cells[cmnSaldo.Index].Style.BackColor = Color.Green;

            }
            r.Tag = item;
        }

        private void IconDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                frmDetalleCtaCte frm = new frmDetalleCtaCte();
                frm.Text = "Detalle de Cuenta Corriente";
                DataGridViewRow r = dgvDatos.CurrentRow;
                var cta = (CtaCte)r.Tag;
                List<CtaCte> listaMovimientosCtaCte = servicio.GetLista(cta.ClienteId);
                frm.SetCtaCte(listaMovimientosCtaCte);
                DialogResult dr = frm.ShowDialog(this);
            }
        }
    }
}
