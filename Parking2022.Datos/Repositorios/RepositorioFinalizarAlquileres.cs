using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioFinalizarAlquileres
    {
        private SqlConnection cn;

        public RepositorioFinalizarAlquileres (SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<FinalizarAlquilerDiario> GetLista()
        {
            List<FinalizarAlquilerDiario> lista = new List<FinalizarAlquilerDiario>();
            try
            {
                var cadenaComando = "SELECT FechaIngreso, FechaSalida, TipoTarifaId, Pagado, Retirado, RowVersion FROM AlquileresEnElDia";
                var comando = new SqlCommand(cadenaComando, cn);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FinalizarAlquilerDiario alquilerDiario = ConstruirFinalizarAlquilerDiario(reader);
                        lista.Add(alquilerDiario);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //List<FinalizarAlquilerDiario> lista = new List<FinalizarAlquilerDiario>();
            //try
            //{
            //    var cadenaComando = "SELECT FinAlquilerDiaId, TipoVehiculoId, AlquilerEnElDiaId, HoraSalida, TotalHoras, TipoTarifaId, Costo, " +
            //                        "ImporteAPagar, Abonado, Retirado, RowVersion FROM FinalizarAlquileresDiarios";
            //    var comando = new SqlCommand(cadenaComando, cn);

            //    using (var reader = comando.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            FinalizarAlquilerDiario finalizarAlquilerDiario = ConstruirFinalizarAlquilerDiario(reader);
            //            lista.Add(finalizarAlquilerDiario);
            //        }
            //    }
            //    return lista;
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
        }

        private FinalizarAlquilerDiario ConstruirFinalizarAlquilerDiario(SqlDataReader reader)
        {
            return new FinalizarAlquilerDiario()
            {
                FinAlquilerDiaId = reader.GetInt32(0),
                TipoVehiculoId = reader.GetInt32(1),
                AlquilerEnElDiaId = reader.GetInt32(2),
                HoraSalida = reader.GetDateTime(3),
                TotalHoras = reader.GetTimeSpan(4),
                TarifaId = reader.GetInt32(5),
                Costo = reader.GetDouble(6),
                ImporteAPagar = reader.GetDouble(7),
                Abonado = reader.GetBoolean(8),
                Retirado = reader.GetBoolean(9),
                RowVersion = (byte[]) reader[10]
            };

        }

        public int Agregar(FinalizarAlquilerDiario finalizarAlquilerDiario)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO FinalizarAlquileresDiarios (TipoVehiculoId, AlquilerEnElDiaId, HoraSalida, TotalHoras, TipoTarifaId, Costo, " +
                          "ImporteAPagar, Abonado, Retirado) VALUES(@tipov, @alqui, @hrsalida, @hrtotal, @tipot, @costo, @importe, @abonado, " +
                          "@retirado)");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipov", finalizarAlquilerDiario.TipoVehiculoId);
                comando.Parameters.AddWithValue("@alqui", finalizarAlquilerDiario.AlquilerEnElDiaId);
                comando.Parameters.AddWithValue("@hrsalida", finalizarAlquilerDiario.HoraSalida);
                comando.Parameters.AddWithValue("@hrtotal", finalizarAlquilerDiario.TotalHoras);
                comando.Parameters.AddWithValue("@tipot", finalizarAlquilerDiario.Tarifa);
                comando.Parameters.AddWithValue("@costo", finalizarAlquilerDiario.Costo);
                comando.Parameters.AddWithValue("@importe", finalizarAlquilerDiario.ImporteAPagar);
                comando.Parameters.AddWithValue("@abonado", finalizarAlquilerDiario.Abonado);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    finalizarAlquilerDiario.FinAlquilerDiaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM FinalizarAlquileresDiario WHERE FinAlquilerDiaId=@Id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", finalizarAlquilerDiario.FinAlquilerDiaId);
                    finalizarAlquilerDiario.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EstaRelacionado(FinalizarAlquilerDiario finalizarAlquilerDiario)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM FinalizarAlquileresDiarios WHERE FinAlquilerDiaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", finalizarAlquilerDiario.FinAlquilerDiaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
