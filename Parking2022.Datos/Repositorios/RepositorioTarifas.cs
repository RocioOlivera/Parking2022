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

        public List<TipoDeTarifa> GetLista(TipoDeVehiculo tipoDeVehiculo=null)
        {
            List<TipoDeTarifa> lista = new List<TipoDeTarifa>();
            try
            {
                StringBuilder sb = 
                    new StringBuilder(
                    "SELECT TipoTarifaId, TipoVehiculoId, Hora, MediaEstadia, Estadia, Noche, RowVersion FROM Tarifas ");
                if (tipoDeVehiculo!=null)
                {
                    sb.Append("WHERE TipoVehiculoId=@id ORDER BY TipoVehiculoId");
                }
                else
                {
                    sb.Append(" ORDER BY TipoVehiculoId");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (tipoDeVehiculo!=null)
                {
                    comando.Parameters.AddWithValue("@id", tipoDeVehiculo.TipoVehiculoId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoDeTarifa tipoDeTarifa = ConstruirTipoDeTarifa(reader);
                        lista.Add(tipoDeTarifa);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private TipoDeTarifa ConstruirTipoDeTarifa (SqlDataReader reader)
        {
            return new TipoDeTarifa()
            {
                TipoTarifaId = reader.GetInt32(0),
                TipoVehiculoId = reader.GetInt32(1),
                Hora = reader.GetDecimal(2),
                MediaEstadia = reader.GetInt32(3),
                Estadia = reader.GetInt32(4),
                Noche = reader.GetDecimal(5),
                RowVersion = (byte[])reader[6]
            };
        }

        public int Agregar(TipoDeTarifa tipoDeTarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "INSERT INTO Tarifas (TipoVehiculoId, Hora, MediaEstadia, Estadia, Noche)" +
                                    " VALUES (@vehi, @hr, @media, @est, @noc)";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@vehi", tipoDeTarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@hr", tipoDeTarifa.Hora);
                comando.Parameters.AddWithValue("@media", tipoDeTarifa.MediaEstadia);
                comando.Parameters.AddWithValue("@est", tipoDeTarifa.Estadia);
                comando.Parameters.AddWithValue("@noc", tipoDeTarifa.Noche);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                { 
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    tipoDeTarifa.TipoTarifaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TipoTarifaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tipoDeTarifa.TipoTarifaId);
                    tipoDeTarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;

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
                var cadenaComando = "SELECT COUNT(*) FROM AlquileresConAbono WHERE TipoTarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipoDeTarifa.TipoTarifaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoDeTarifa tipoDeTarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Tarifas WHERE TipoTarifaId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipoDeTarifa.TipoTarifaId);
                comando.Parameters.AddWithValue("@r", tipoDeTarifa.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoDeTarifa tipoDeTarifa)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Tarifas SET TipoVehiculoId=@vehi, Hora=@hr, MediaEstadia=@media, Estadia=@est, Noche=@noc WHERE TipoTarifaId=@id");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@vehi", tipoDeTarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@hr", tipoDeTarifa.Hora);
                comando.Parameters.AddWithValue("@media", tipoDeTarifa.MediaEstadia);
                comando.Parameters.AddWithValue("@est", tipoDeTarifa.Estadia);
                comando.Parameters.AddWithValue("@noc", tipoDeTarifa.Noche);
                //comando.Parameters.AddWithValue("@sem", tipoDeTarifa.Semana);
                //comando.Parameters.AddWithValue("@quin", tipoDeTarifa.Quincena);
                //comando.Parameters.AddWithValue("@mes", tipoDeTarifa.Mes);
                comando.Parameters.AddWithValue(@"id", tipoDeTarifa.TipoTarifaId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {
                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TipoTarifaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tipoDeTarifa.TipoTarifaId);
                    tipoDeTarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoDeTarifa GetTipoDeTarifaPorId(int id)
        {
            try
            {
                TipoDeTarifa tipoDeTarifa = null;
                var cadenaComando = "SELECT TipoTarifaId, TipoVehiculoId, Hora, MediaEstadia, Estadia, Noche, RowVersion " +
                                    "FROM Tarifas WHERE TipoTarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tipoDeTarifa = ConstruirTipoDeTarifa(reader);
                    }
                }

                return tipoDeTarifa;
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
                var cadenaComando = "SELECT COUNT(*) FROM Tarifas WHERE TipoVehiculoId=@tipo";
                if (tipoDeTarifa.TipoTarifaId != 0)
                {
                    cadenaComando += " AND TipoTarifaId<>@tipoTarifaId";
                }
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeTarifa.Hora);

                if (tipoDeTarifa.TipoTarifaId != 0)
                {
                    comando.Parameters.AddWithValue("@tipoTarifaId", tipoDeTarifa.TipoTarifaId);
                }

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

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
