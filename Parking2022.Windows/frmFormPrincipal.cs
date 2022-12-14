using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Parking2022.Windows
{
    public partial class frmFormPrincipal : Form
    {

        private IconMenuItem menuActivo = null;
        private Form formularioActivo = null;

        public frmFormPrincipal()
        {
            InitializeComponent();
        }



        private void frmFormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            formularioActivo = formulario;

            ContenedorPanel.Controls.Add(formulario);

            formulario.Show();
        }
        private void IconClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void IconCtasCtes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCtasCtes());
        }

        private void ContenedorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconTarifas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new  frmTarifas());
        }

        private void IconTipoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmTiposDeVehiculos());
        }

        private void iconTipoSector_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,new frmTiposDeSectores());
        }

        //private void IconAlquileresDiarios_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario((IconMenuItem)sender, new frmAlquileresDiarios());
        //}

        private void IconAlquileresAsociados_Click(object sender, EventArgs e)
        {

        }

        private void IconAlquileresDiarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAlquileresDiarios());
        }

        //private void IconAlquileresDiarios_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario((IconMenuItem)sender, new frmAlquileresDiarios());
        //}
    }
}
