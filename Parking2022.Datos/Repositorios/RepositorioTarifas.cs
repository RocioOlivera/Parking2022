using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioTarifas
    {
        private SqlConnection cn;

        public RepositorioTarifas(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Tarifa> GetLista(TipoDeVehiculo tipoDeVehiculo=null, TiempoTarifa tiempoTarifa=null)
        {
            List<Tarifa> lista = new List<Tarifa>();
            try
            {
                StringBuilder sb =
                    new StringBuilder("SELECT TarifaId, Descripcion, TipoVehiculoId, TiempoTarifaId, Importe, RowVersion FROM Tarifas");
                if (tipoDeVehiculo != null && tiempoTarifa != null)
                {
                    sb.Append(" WHERE (TipoVehiculoId=@Vid) and (TiempoTarifaId=@Tid) ORDER BY Importe");
                }
                else
                {
                    sb.Append(" ORDER BY Importe");
                }

                //if (tiempoTarifa != null)
                //{
                //    sb.Append("WHERE TiempoTarifaId=@Tid) ORDER BY Importe");
                //}
                //else
                //{
                //    sb.Append(" ORDER BY Importe");
                //}

                var cadenaComando= sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);

                if (tipoDeVehiculo != null)
                {
                    comando.Parameters.AddWithValue("@Vid", tipoDeVehiculo.TipoVehiculoId);
                }
                if (tiempoTarifa != null)
                {
                    comando.Parameters.AddWithValue("@Tid", tiempoTarifa.TiempoTarifaId);
                }

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tarifa tarifa = ConstruirTarifa(reader);
                        lista.Add(tarifa);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Tarifa ConstruirTarifa (SqlDataReader reader)
        {
            return new Tarifa()
            {
                TarifaId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                TipoVehiculoId = reader.GetInt32(2),
                TiempoTarifaId = reader.GetInt32(3),
                Importe = reader.GetDecimal(4),
                RowVersion = (byte[])reader[5]
            };
        }

        public int Agregar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "INSERT INTO Tarifas (Descripcion, TipoVehiculoId, TiempoTarifaId, Importe) VALUES (@desc, @vehi, @tiem, @imp)" ;

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@desc", tarifa.Descripcion);
                comando.Parameters.AddWithValue("@vehi", tarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@tiem", tarifa.TiempoTarifaId);
                comando.Parameters.AddWithValue("@imp", tarifa.Importe);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                { 
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    tarifa.TarifaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TarifaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                    tarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;

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
                var cadenaComando = "SELECT COUNT(*) FROM AlquileresEnElDia WHERE TarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Tarifas WHERE TarifaId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                comando.Parameters.AddWithValue("@r", tarifa.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Tarifas SET Descripcion=@desc, TipoVehiculoId=@vehi, TiempoTarifaId=@tiem, Importe=@imp WHERE TarifaId=@id AND RowVersion=@r");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@desc", tarifa.Descripcion);
                comando.Parameters.AddWithValue("@vehi", tarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@tiem", tarifa.TiempoTarifaId);
                comando.Parameters.AddWithValue("@imp", tarifa.Importe);
                comando.Parameters.AddWithValue("@r", tarifa.RowVersion);
                comando.Parameters.AddWithValue(@"id", tarifa.TarifaId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {
                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TarifaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                    tarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Tarifa GetTarifaPorId(int id)
        {
            try
            {
                Tarifa tarifa = null;
                var cadenaComando = "SELECT TarifaId, TipoVehiculoId, TiempoTarifaId, Importe, RowVersion " +
                                    "FROM Tarifas WHERE TarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tarifa = ConstruirTarifa(reader);
                    }
                }

                return tarifa;
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
        //        var cadenaComando = "SELECT COUNT(*) FROM Tarifas WHERE TipoVehiculoId=@vehi AND TiempoTarifaId=@tiem";
        //        if (tarifa.TarifaId != 0)
        //        {
        //            cadenaComando += " AND TarifaId<>@TarifaId";
        //        }
        //        var comando = new SqlCommand(cadenaComando, cn);
        //        comando.Parameters.AddWithValue("@imp", tarifa.Importe);

        //        if (tarifa.TarifaId != 0)
        //        {
        //            comando.Parameters.AddWithValue("@tarifaId", tarifa.TarifaId);
        //        }

        //        return (int)comando.ExecuteScalar() > 0;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        //public TipoDeTarifa GetTipoDeTarifaPorId(int id)
        //{
        //    TipoDeTarifa tipoDeTarifa = null;
        //    try
        //    {
        //        var cadenaComando =
        //            "SELECT TipoTarifaId, TipoVehiculoId, Hora, MediaEstadia, Estadia, Noche, Semana, Quincena, Mes, RowVersion FROM Tarifas WHERE TipoTarifa=@id";
        //        var comando = new SqlCommand(cadenaComando, cn);
        //        comando.Parameters.AddWithValue("@id", id);
        //        using (var reader = comando.ExecuteReader())
        //        {
        //            if (reader.HasRows)
        //            {
        //                reader.Read();
        //                //tipoDeTarifa = ConstruirProductoDetalle(reader);

        //            }
        //        }

        //        return tipoDeTarifa;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }

        //}
    }
}
