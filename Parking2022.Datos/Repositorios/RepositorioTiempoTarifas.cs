using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioTiempoTarifas
    {
        private SqlConnection cn;

        public RepositorioTiempoTarifas(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<TiempoTarifa> GetLista()
        {
            List<TiempoTarifa> lista = new List<TiempoTarifa>();
            try
            {
                var cadenaComando = "SELECT TiempoTarifaId, Descripcion, RowVersion FROM TiempoTarifas ORDER BY Descripcion";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tiempoTarifa = ConstruirTiempoTarifa(reader);
                        lista.Add(tiempoTarifa);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error a leer los datos de Tiempos de Tarifas.");
            }
        }

        private TiempoTarifa ConstruirTiempoTarifa(SqlDataReader reader)
        {
            return new TiempoTarifa()
            {
                TiempoTarifaId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[]) reader[2]
            };
        }

        public TiempoTarifa GetTiempoTarifaPorId(int id)
        {
            try
            {
                TiempoTarifa tiempoTarifa = null;
                var cadenaComando = "SELECT TiempoTarifaId, Descripcion, RowVersion FROM TiempoTarifas WHERE TiempoTarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tiempoTarifa = ConstruirTiempoTarifa(reader);
                    }
                }
                return tiempoTarifa;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
