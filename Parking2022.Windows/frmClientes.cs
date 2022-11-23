using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking2022.Datos;
using Parking2022.Datos.Repositorios;
using Parking2022.Entidades.Entidades;
using Parking2022.Servicios.Servicios;
using Parking2022.Windows.Helpers;

namespace Parking2022.Windows
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private RepositorioClientes repositorio;
        private ServiciosClientes servicio;
        private List<Cliente> lista;
        private void frmClientes_Load(object sender, EventArgs e)
        {
            //servicio = new ServiciosClientes();
            //try
            //{ 
            //    lista = servicio.GetLista(); 
            //    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            //}
            //catch (Exception exception)
            //{
            //    throw new Exception(exception.Message);
            //}
            servicio = new ServiciosClientes();
            paginaActual = 1;
            cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(), registrosPorPagina);

            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        //AGREGAR
        private void IconNuevo_Click(object sender, EventArgs e)
        {
            frmClienteAE frm = new frmClienteAE() { Text = "Nuevo Cliente" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Cliente cliente = frm.GetCliente();
                if (servicio.Existe(cliente))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Cliente existente!!!", "ERROR");
                }
                else
                {
                    int registors = servicio.Agregar(cliente);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Cliente agregado!!!", "Mensaje");
                    var r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, cliente);
                    HelperGrid.AgregarFila(dgvDatos, r);
                }
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        //EDITAR
        private void EditarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Cliente cliente = (Cliente)r.Tag;
            frmClienteAE frm = new frmClienteAE() { Text = "Editar Cliente" };
            frm.SetCliente(cliente);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                cliente = frm.GetCliente();
                if (servicio.Existe(cliente))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Cliente existente!!!", "ERROR");
                }
                else
                {
                    int registros = servicio.Editar(cliente);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Cliente editado!!!", "Mensaje");
                    r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, cliente);
                    HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        //BORRAR
        private void BorrarMenu_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Cliente cliente = (Cliente)r.Tag;
            DialogResult dr = HelperMessage.Mensaje("¿Desea borrar el cliente?", "Confirmar");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (servicio.EstaRelacionado(cliente))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Cliente relacionado!!", "ERROR");
                }
                else
                {
                    int registros = servicio.Borrar(cliente);
                    if (registros == 0)
                    {
                        HelperMessage.Mensaje(TipoMensaje.Warning, "No se puede eliminar registro", "Advertencia");
                    }
                    else
                    {
                        HelperGrid.BorrarFila(dgvDatos, r);
                        HelperMessage.Mensaje(TipoMensaje.OK, "Cliente borrado", "Mensaje");
                    }
                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        //PAGINACION 
        private int cantidadPaginas;
        private int registrosPorPagina = 6;
        private int paginaActual = 1;

        private void ManejoBotonesNavegacion()
        {
            if (paginaActual == 1)
            {
                AnteriorMenuPag.Enabled = false;
                SiguienteMenuPag.Enabled = true;
            }
            else if (paginaActual == cantidadPaginas)
            {
                AnteriorMenuPag.Enabled = true;
                SiguienteMenuPag.Enabled = false;
            }
            else
            {
                AnteriorMenuPag.Enabled = true;
                SiguienteMenuPag.Enabled = true;
            }
        }


        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina);
                HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        public List<Cliente> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            try
            {
                List<Cliente> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina);
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void PrimeroMenuPag_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void AnteriorMenuPag_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual < 1)
            {
                paginaActual = 1;
            }
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void SiguienteMenuPag_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual > cantidadPaginas)
            {
                paginaActual = cantidadPaginas;
            }
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void UltimoMenuPag_Click(object sender, EventArgs e)
        {
            paginaActual = cantidadPaginas;
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
