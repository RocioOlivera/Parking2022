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

        public double GetRecaudado()
        {
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioFinalizarAlquileres(cn);
                    double recaudado = repositorio.GetRecaudado();

                    return recaudado;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public int Agregar(Recaudacion recaudacion)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioFinalizarAlquileres(cn);

                    registros = repositorio.Agregar(recaudacion);
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
