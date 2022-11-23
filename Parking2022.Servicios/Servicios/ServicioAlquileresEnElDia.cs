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
    public class ServicioAlquileresEnElDia
    {
        private RepositorioAlquileresDiarios repositorio;
        private RepositorioTiposVehiculos repoTiposVehiculos;
        private RepositorioTiposSectores repoTiposSectores;
        private RepositorioNrosSectores repoNroSectores;

        public ServicioAlquileresEnElDia()
        {

        }

        public List<AlquilerDiario> GetLista()
        {
            try
            {
                List<AlquilerDiario> lista=null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioAlquileresDiarios(cn);
                    repoTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    repoTiposSectores = new RepositorioTiposSectores(cn);
                    repoNroSectores = new RepositorioNrosSectores(cn);
                    lista = repositorio.GetLista();
                    foreach (var alquilerDiario in lista)
                    {
                        alquilerDiario.TipoDeVehiculo = repoTiposVehiculos.GetTipoDeVehiculoPorId(alquilerDiario.TipoVehiculoId);
                        alquilerDiario.TipoDeSector = repoTiposSectores.GetTipoSectorPorId(alquilerDiario.TipoSectorId);
                        alquilerDiario.NrosSectores = repoNroSectores.GetNroPorId(alquilerDiario.NroId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //public bool Existe(AlquilerDiario alquilerDiario)
        //{
        //    try
        //    {
        //        bool existe = true;
        //        using (var cn = ConexionBd.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioAlquileresDiarios(cn);

        //            existe = repositorio.Existe(alquilerDiario);
        //        }

        //        return existe;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
        public int Agregar(AlquilerDiario alquilerDiario)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioAlquileresDiarios(cn);

                    registros = repositorio.Agregar(alquilerDiario);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(AlquilerDiario alquilerDiario)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioAlquileresDiarios(cn);
                    estaRelacionado = repositorio.EstaRelacionado(alquilerDiario);
                }
                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Borrar(AlquilerDiario alquilerDiario)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioAlquileresDiarios(cn);

                    registros = repositorio.Borrar(alquilerDiario);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(AlquilerDiario alquilerDiario)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioAlquileresDiarios(cn);

                    registros = repositorio.Editar(alquilerDiario);

                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
