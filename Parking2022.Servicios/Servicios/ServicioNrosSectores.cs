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
    public class ServicioNrosSectores
    {
        private RepositorioNrosSectores repositorio;
        private RepositorioTiposSectores repoTiposSectores;

        public ServicioNrosSectores()
        {

        }

        public List<NrosSectores> GetLista(TipoDeSector tipoDeSector=null)
        {
            try
            {
                List<NrosSectores> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioNrosSectores(cn);
                    repoTiposSectores = new RepositorioTiposSectores(cn);
                    lista = repositorio.GetLista(tipoDeSector);
                    foreach (var nroSector in lista)
                    {
                        nroSector.TipoDeSector = repoTiposSectores.GetTipoSectorPorId(nroSector.TipoSectorId);
                    }
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public int Agregar(NrosSectores nrosSectores)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioNrosSectores(cn);

                    registros = repositorio.Agregar(nrosSectores);

                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public int Borrar(NrosSectores nrosSectores)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioNrosSectores(cn);

                    registros = repositorio.Borrar(nrosSectores);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Editar(NrosSectores nrosSectores)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioNrosSectores(cn);

                    registros = repositorio.Editar(nrosSectores);

                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(NrosSectores nrosSectores)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioNrosSectores(cn);
                    estaRelacionado = repositorio.EstaRelacionado(nrosSectores);
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
