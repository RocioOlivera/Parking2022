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
    public class ServicioFinalizarAlquileres
    {
        private RepositorioFinalizarAlquileres repositorio;
        private RepositorioTiposVehiculos repoTiposVehiculos;
        private RepositorioTarifas repoTarifas;
        private RepositorioAlquileresDiarios repoAlquileresDiarios;

        public ServicioFinalizarAlquileres()
        {

        }

        public List<FinalizarAlquilerDiario> GetLista()
        {
            try
            {
                List<FinalizarAlquilerDiario> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioFinalizarAlquileres(cn);
                    repoTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    repoTarifas = new RepositorioTarifas(cn);
                    repoAlquileresDiarios = new RepositorioAlquileresDiarios(cn);
                    lista = repositorio.GetLista();
                    foreach (var finalizarAlquiler in lista)
                    {
                        finalizarAlquiler.TipoDeVehiculo = repoTiposVehiculos.GetTipoDeVehiculoPorId(finalizarAlquiler.TipoVehiculoId);
                        finalizarAlquiler.Tarifa = repoTarifas.GetTarifaPorId(finalizarAlquiler.TarifaId);
                        finalizarAlquiler.AlquilerDiario = repoAlquileresDiarios.GetAlquilerDiarioPorId(finalizarAlquiler.AlquilerEnElDiaId);
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
        public int Agregar(FinalizarAlquilerDiario finalizarAlquilerDiario)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioFinalizarAlquileres(cn);

                    registros = repositorio.Agregar(finalizarAlquilerDiario);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(FinalizarAlquilerDiario finalizarAlquilerDiario)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioFinalizarAlquileres(cn);
                    estaRelacionado = repositorio.EstaRelacionado(finalizarAlquilerDiario);
                }
                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //public int Borrar(FinalizarAlquilerDiario finalizarAlquilerDiario)
        //{
        //    try
        //    {
        //        int registros = 0;
        //        using (var cn = ConexionBd.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioFinalizarAlquileres(cn);

        //            registros = repositorio.Borrar(finalizarAlquilerDiario);
        //        }
        //        return registros;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        //public int Editar(FinalizarAlquilerDiario finalizarAlquilerDiario)
        //{
        //    try
        //    {
        //        int registros = 0;
        //        using (var cn = ConexionBd.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioFinalizarAlquileres(cn);

        //            registros = repositorio.Editar(finalizarAlquilerDiario);

        //        }
        //        return registros;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
    }
}
