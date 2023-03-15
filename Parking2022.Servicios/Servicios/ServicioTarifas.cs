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
    public class ServicioTarifas
    {
        private RepositorioTarifas repositorio;
        private RepositorioTiempoTarifas repositorioTiempoTarifas;
        private RepositorioTiposVehiculos repositorioTiposVehiculos;

        public ServicioTarifas()
        {

        }

        public List<Tarifa> GetLista(TipoDeVehiculo tipoDeVehiculo=null, TiempoTarifa tiempoTarifa = null)
        {
            try
            {
                List<Tarifa> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    repositorioTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    repositorioTiempoTarifas = new RepositorioTiempoTarifas(cn);
                    lista = repositorio.GetLista(tipoDeVehiculo,tiempoTarifa);
                    foreach (var tarifa in lista)
                    {
                        tarifa.TipoDeVehiculo = repositorioTiposVehiculos.GetTipoDeVehiculoPorId(tarifa.TipoVehiculoId);
                        tarifa.TiempoTarifa = repositorioTiempoTarifas.GetTiempoTarifaPorId(tarifa.TiempoTarifaId);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    registros = repositorio.Agregar(tarifa);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public bool Existe(Tarifa tarifa)
        //{
        //    try
        //    {
        //        bool existe = true;
        //        using (var cn = ConexionBd.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioTarifas(cn);

        //            existe = repositorio.Existe(tarifa);
        //        }

        //        return existe;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        public int Borrar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);

                    registros = repositorio.Borrar(tarifa);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);

                    registros = repositorio.Editar(tarifa);

                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Tarifa tarifa)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    estaRelacionado = repositorio.EstaRelacionado(tarifa);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public bool Existe(TipoDeTarifa tipoDeTarifa)
        //{
        //    try
        //    {
        //        bool existe = true;
        //        using (var cn = ConexionBd.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioTarifas(cn);

        //            existe = repositorio.Existe(tipoDeTarifa);
        //        }

        //        return existe;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
        public Tarifa GetTarifaPorId(int id)
        {
            try
            {
                Tarifa tarifa = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    tarifa = repositorio.GetTarifaPorId(id);
                }

                return tarifa;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
