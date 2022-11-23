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
        private RepositorioTiposVehiculos repositorioTiposVehiculos;

        public ServicioTarifas()
        {

        }

        public List<TipoDeTarifa> GetLista()
        {
            try
            {
                List<TipoDeTarifa> lista=null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    repositorioTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    lista = repositorio.GetLista();
                    foreach (var tipoDeTarifa in lista)
                    {
                        tipoDeTarifa.TipoDeVehiculo = repositorioTiposVehiculos.GetTipoDeVehiculoPorId(tipoDeTarifa.TipoVehiculoId);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(TipoDeTarifa tipoDeTarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    registros = repositorio.Agregar(tipoDeTarifa);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeTarifa tipoDeTarifa)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);

                    existe = repositorio.Existe(tipoDeTarifa);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoDeTarifa tipoDeTarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);

                    registros = repositorio.Borrar(tipoDeTarifa);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoDeTarifa tipoDeTarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);

                    registros = repositorio.Editar(tipoDeTarifa);

                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeTarifa tipoDeTarifa)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    estaRelacionado = repositorio.EstaRelacionado(tipoDeTarifa);
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
        public TipoDeTarifa GetTipoDeTarifaPorId(int id)
        {
            try
            {
                TipoDeTarifa tipoDeTarifa = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    tipoDeTarifa = repositorio.GetTipoDeTarifaPorId(id);
                }

                return tipoDeTarifa;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
