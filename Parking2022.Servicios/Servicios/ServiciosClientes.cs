using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Datos;
using Parking2022.Datos.Repositorios;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Servicios.Servicios
{
    public class ServiciosClientes
    {
        private RepositorioClientes repositorio;

        public ServiciosClientes()
        {

        }

        public List<Cliente> GetLista()
        {
            try
            {
                List<Cliente> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    lista = repositorio.GetLista();
                  
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);

                    existe = repositorio.Existe(cliente);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Cliente cliente)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);

                    registros = repositorio.Agregar(cliente);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Cliente cliente)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);

                    registros = repositorio.Editar(cliente);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Borrar(Cliente cliente)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);

                    registros = repositorio.Borrar(cliente);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    estaRelacionado = repositorio.EstaRelacionado(cliente);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad()
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    registros = repositorio.GetCantidad();
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
    }
}
