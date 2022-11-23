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
    public class ServicioCtasCtes
    {
        private RepositorioCtasCtes repositorio;
        private RepositorioClientes repositorioCliente;
        public List<CtaCte> GetSaldos()
        {
            try
            {
                List<CtaCte> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioCtasCtes(cn);
                    repositorioCliente = new RepositorioClientes(cn);
                    lista = repositorio.GetSaldos();
                    foreach (var ctaCte in lista)
                    {
                        ctaCte.Cliente = repositorioCliente.GetClientePorId(ctaCte.ClienteId);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<CtaCte> GetLista(int id)
        {
            try
            {
                List<CtaCte> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioCtasCtes(cn);
                    repositorioCliente = new RepositorioClientes(cn);
                    lista = repositorio.GetLista(id);
                    //foreach (var ctaCte in lista)
                    //{
                    //    ctaCte.Cliente = repositorioCliente.GetClientePorId(ctaCte.ClienteId);
                    //}
                    lista[0].Cliente = repositorioCliente.GetClientePorId(lista[0].ClienteId);
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
