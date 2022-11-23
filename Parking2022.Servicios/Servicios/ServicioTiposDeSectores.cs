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
    public class ServicioTiposDeSectores
    {
        private RepositorioTiposSectores repositorio;

        public ServicioTiposDeSectores()
        {
            
        }
        public List<TipoDeSector> GetLista()
        {
            try
            {
                List<TipoDeSector> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposSectores(cn);
                    lista = repositorio.GetLista();
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Agregar(TipoDeSector tipoDeSector)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposSectores(cn);
                    registros = repositorio.Agregar(tipoDeSector);
                }

                return registros;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public int Borrar(TipoDeSector tipoDeSector)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposSectores(cn);

                    registros = repositorio.Borrar(tipoDeSector);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Editar(TipoDeSector tipoDeSector)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposSectores(cn);

                    registros = repositorio.Editar(tipoDeSector);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool Existe(TipoDeSector tipoDeSector)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposSectores(cn);

                    existe = repositorio.Existe(tipoDeSector);
                }
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(TipoDeSector tipoDeSector)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposSectores(cn);
                    estaRelacionado = repositorio.EstaRelacionado(tipoDeSector);
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
