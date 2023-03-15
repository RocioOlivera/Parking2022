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
    public partial class frmPagosAE : Form
    {
        public frmPagosAE()
        {
            InitializeComponent();
        }

        private AlquilerDiario alquilerDiario;


        private void frmPagosAE_Load(object sender, EventArgs e)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (alquilerDiario != null)
            {

                txtImporte.Text = alquilerDiario.Tarifa.Importe.ToString();


            }
        }
    }

}

