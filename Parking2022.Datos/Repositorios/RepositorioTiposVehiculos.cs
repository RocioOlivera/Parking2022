using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioTiposVehiculos
    {
        private SqlConnection cn;

        public RepositorioTiposVehiculos(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<TipoDeVehiculo> GetLista()
        {
            List<TipoDeVehiculo> lista = new List<TipoDeVehiculo>();
            try
            {
                var cadenaComando = "SELECT TipoVehiculoId, TipoVehiculo, RowVersion FROM TiposDeVehiculos ORDER BY TipoVehiculo";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoDeVehiculo  = ConstruirTipoDeVehiculo(reader);
                        lista.Add(tipoDeVehiculo);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error a leer los datos de Tipos de Vehiculos.");
            }
        }

        private TipoDeVehiculo ConstruirTipoDeVehiculo(SqlDataReader reader)
        {
            return new TipoDeVehiculo()
            {
                TipoVehiculoId = reader.GetInt32(0),
                TipoVehiculo = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public bool Existe(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM TiposDeVehiculos WHERE TipoVehiculo=@tipo";
                if (tipoDeVehiculo.TipoVehiculoId!=0)
                {
                    cadenaComando += " AND TipoVehiculoId<>@tipoVehiculoId";
                }

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeVehiculo.TipoVehiculo);
                if (tipoDeVehiculo.TipoVehiculoId != 0)
                {
                    comando.Parameters.AddWithValue("@tipoVehiculoId", tipoDeVehiculo.TipoVehiculoId);
                }
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoDeVehiculo tipoDeVehiculo)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando= "UPDATE TiposDeVehiculos SET TipoVehiculo=@tipo WHERE TipoVehiculoId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeVehiculo.TipoVehiculo);
                comando.Parameters.AddWithValue("@id", tipoDeVehiculo.TipoVehiculoId);
                comando.Parameters.AddWithValue("@r", tipoDeVehiculo.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    cadenaComando = "SELECT RowVersion FROM TiposDeVehiculos WHERE TipoVehiculoId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tipoDeVehiculo.TipoVehiculoId);
                    tipoDeVehiculo.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message); ;
            }
        }

        public int Borrar(TipoDeVehiculo tipoDeVehiculo)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM TiposDeVehiculos WHERE TipoVehiculoId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipoDeVehiculo.TipoVehiculoId);
                comando.Parameters.AddWithValue("@r", tipoDeVehiculo.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeVehiculo tipoDeVehiculo)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Tarifas WHERE TipoDeVehiculoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipoDeVehiculo.TipoVehiculoId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoDeVehiculo GetTipoDeVehiculoPorId(int id)
        {
            try
            {
                TipoDeVehiculo tipoDeVehiculo = null;
                var cadenaComando = "SELECT TipoVehiculoId, TipoVehiculo, RowVersion FROM TiposDeVehiculos WHERE TipoVehiculoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tipoDeVehiculo = ConstruirTipoDeVehiculo(reader);
                    }
                }
                return tipoDeVehiculo;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int Agregar(TipoDeVehiculo tipoDeVehiculo)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando= "INSERT INTO TiposDeVehiculos (TipoVehiculo) VALUES (@tipo)";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeVehiculo.TipoVehiculo);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados > 0)
                { 
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    tipoDeVehiculo.TipoVehiculoId = (int)(decimal)comando.ExecuteScalar();
                    cadenaComando = "SELECT RowVersion FROM TiposDeVehiculos WHERE TipoVehiculoId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tipoDeVehiculo.TipoVehiculoId);
                    tipoDeVehiculo.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
