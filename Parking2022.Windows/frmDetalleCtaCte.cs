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

namespace Parking2022.Windows
{
    public partial class frmDetalleCtaCte : Form
    {
        public frmDetalleCtaCte()
        {
            InitializeComponent();
        }

        private void frmDetalleCtaCte_Load(object sender, EventArgs e)
        {

        }

        private List<CtaCte> lista;
        private Cliente cliente;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (lista != null)
            {
                cliente = lista[0].Cliente;
                txtApellidoYNombre.Text = cliente.ApellidoYNombre.ToString();
                txtNumDocumento.Text = cliente.NumDocumento;
                txtTelDeContacto.Text = cliente.TelDeContacto;

                if (lista.Count > 0)
                {
                    MostrarDatosGrilla(lista);
                    txtSaldo.Text = lista[lista.Count - 1].Saldo.ToString("c");
                }
            }
        }

        private void MostrarDatosGrilla(List<CtaCte> lista)
        {
            dgDatos.Rows.Clear();
            foreach (var ctaCte in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgDatos);
                SetearFila(r, ctaCte);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, CtaCte ctaCte)
        {
            r.Cells[cmnFecha.Index].Value = ctaCte.FechaMovimiento;
            r.Cells[cmnDebe.Index].Value = ctaCte.Debe;
            r.Cells[cmnHaber.Index].Value = ctaCte.Haber;

            r.Tag = ctaCte;

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgDatos.Rows.Add(r);
        }

        public void SetCtaCte(List<CtaCte> movimientos)
        {
            lista = movimientos;
        }
    }
}
