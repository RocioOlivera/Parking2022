using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioAlquileresDiarios
    {
        private SqlConnection cn;

        public RepositorioAlquileresDiarios(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<AlquilerDiario> GetLista()
        {
            List<AlquilerDiario> lista = new List<AlquilerDiario>();
            try
            {
                var cadenaComando= "SELECT AlquilerEnElDiaId, TipoVehiculoId, Patente, TipoSectorId, NroId, " +
                             "FechaIngreso, Activo, RowVersion FROM AlquileresEnElDia";
                var comando = new SqlCommand(cadenaComando, cn);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AlquilerDiario alquilerDiario = ConstruirAlquilerDiario(reader);
                        lista.Add(alquilerDiario);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private AlquilerDiario ConstruirAlquilerDiario(SqlDataReader reader)
        {
            return new AlquilerDiario()
            {
                AlquilerEnElDiaId = reader.GetInt32(0),
                TipoVehiculoId = reader.GetInt32(1),
                Patente = reader.GetString(2),
                TipoSectorId = reader.GetInt32(3),
                NroId = reader.GetInt32(4),
                FechaIngreso = reader.GetDateTime(5),
                Activo = reader.GetBoolean(6),
                RowVersion = (byte[])reader[7]
            };
        }
        //public bool Existe(AlquilerDiario alquilerDiario)
        //{
        //    try
        //    {
        //        var cadenaComando = "SELECT COUNT(*) FROM AlquileresEnElDia WHERE Patente=@patente";
        //        if (alquilerDiario.AlquilerEnElDiaId != 0)
        //        {
        //            cadenaComando += " AND AlquilerEnElDiaId<>@Id";
        //        }

        //        var comando = new SqlCommand(cadenaComando, cn);
        //        comando.Parameters.AddWithValue("@patente", alquilerDiario.Patente);
        //        if (alquilerDiario.AlquilerEnElDiaId != 0)
        //        {
        //            comando.Parameters.AddWithValue("@AlquilerEnElDiaId", alquilerDiario.AlquilerEnElDiaId);
        //        }

        //        return (int)comando.ExecuteScalar() > 0;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
        public int Agregar(AlquilerDiario alquilerDiario)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO AlquileresEnElDia (TipoVehiculoId, Patente, TipoSectorId, NroId, FechaIngreso, Activo) VALUES(@tipov, @patente, @tipos, @nro, @fecha, @activo)") ;
                
                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipov", alquilerDiario.TipoVehiculoId);
                comando.Parameters.AddWithValue("@patente", alquilerDiario.Patente);
                comando.Parameters.AddWithValue("@tipos", alquilerDiario.TipoSectorId);
                comando.Parameters.AddWithValue("@nro", alquilerDiario.NroId);
                comando.Parameters.AddWithValue("@fecha", alquilerDiario.FechaIngreso);
                comando.Parameters.AddWithValue("@activo", alquilerDiario.Activo);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    alquilerDiario.AlquilerEnElDiaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM AlquileresEnElDia WHERE AlquilerEnElDiaId=@Id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", alquilerDiario.AlquilerEnElDiaId);
                    alquilerDiario.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Editar(AlquilerDiario alquilerDiario)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE AlquileresEnElDia SET TipoVehiculoId=@vehi, Patente=@pate, " +
                          "TipoSectorId=@tipos, NroId=@nro, FechaIngreso=@fecha, Activo=@Activo WHERE AlquilerEnElDia=@id AND RowVersion=@r");
                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@vehi", alquilerDiario.TipoVehiculoId);
                comando.Parameters.AddWithValue("@pate", alquilerDiario.Patente);
                comando.Parameters.AddWithValue("@tipos", alquilerDiario.TipoSectorId);
                comando.Parameters.AddWithValue("@nro", alquilerDiario.NroId);
                comando.Parameters.AddWithValue("@fecha", alquilerDiario.FechaIngreso);
                comando.Parameters.AddWithValue("@activo", alquilerDiario.FechaIngreso);
                comando.Parameters.AddWithValue("@r", alquilerDiario.RowVersion);
                comando.Parameters.AddWithValue(@"id", alquilerDiario.AlquilerEnElDiaId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {
                    cadenaComando = "SELECT RowVersion FROM AlquileresEnElDia WHERE AlquilerEnElDiaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", alquilerDiario.AlquilerEnElDiaId);
                    alquilerDiario.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;
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
                var cadenaComando = "SELECT COUNT(*) FROM AlquileresEnElDia WHERE AlquilerEnElDiaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", alquilerDiario.AlquilerEnElDiaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(AlquilerDiario alquilerDiario)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM AlquileresEnElDia WHERE AlquilerEnElDia=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", alquilerDiario.AlquilerEnElDiaId);
                comando.Parameters.AddWithValue("@r", alquilerDiario.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
