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
    public class ServicioTiposDeVehiculos
    {
        private RepositorioTiposVehiculos repositorio;

        public ServicioTiposDeVehiculos()
        {
            
        }

        public List<TipoDeVehiculo> GetLista()
        {
            try
            {
                List<TipoDeVehiculo> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);
                    lista = repositorio.GetLista();
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);
                    registros = repositorio.Agregar(tipoDeVehiculo);
                }

                return registros;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int Borrar(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);

                    registros = repositorio.Borrar(tipoDeVehiculo);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);

                    registros = repositorio.Editar(tipoDeVehiculo);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);

                    existe = repositorio.Existe(tipoDeVehiculo);
                }
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);
                    estaRelacionado = repositorio.EstaRelacionado(tipoDeVehiculo);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
