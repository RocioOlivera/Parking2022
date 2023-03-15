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
    public class ServicioTiempoTarifa
    {
        private RepositorioTiempoTarifas repositorio;

        public ServicioTiempoTarifa()
        {

        }

        public List<TiempoTarifa> GetLista()
        {
            try
            {
                List<TiempoTarifa> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiempoTarifas(cn);
                    lista = repositorio.GetLista();

                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
