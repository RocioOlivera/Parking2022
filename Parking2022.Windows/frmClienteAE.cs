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
using Parking2022.Windows.Helpers;

namespace Parking2022.Windows
{
    public partial class frmClienteAE : Form
    {
        public frmClienteAE()
        {
            InitializeComponent();
        }

        private Cliente cliente;
        public Cliente GetCliente()
        {
            return cliente;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cliente == null)
                {
                    cliente = new Cliente();
                }

                cliente.ApellidoYNombre = txtApellidoYNombre.Text;
                cliente.NumDocumento = txtNumDocumento.Text;
                cliente.TelDeContacto = txtTelContacto.Text;

                DialogResult = DialogResult.OK;
              
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtApellidoYNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtApellidoYNombre, "El Apellido y el Nombre del cliente es requerido.");
            }

            if (string.IsNullOrEmpty(txtNumDocumento.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNumDocumento, "El numero de Documento es obligatorio.");
            }

            if (string.IsNullOrEmpty(txtTelContacto.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTelContacto, "El numero de telefono es requerido.");
            }

            return valido;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cliente != null)
            {
                txtApellidoYNombre.Text = cliente.ApellidoYNombre;
                txtNumDocumento.Text = cliente.NumDocumento;
                txtTelContacto.Text = cliente.TelDeContacto;
            }
        }
    }
}
