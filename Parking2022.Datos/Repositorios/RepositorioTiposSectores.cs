using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioTiposSectores
    {
        private SqlConnection cn;

        public RepositorioTiposSectores(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<TipoDeSector> GetLista()
        {
            List<TipoDeSector> lista = new List<TipoDeSector>();
            try
            {
                var cadenaComando = "SELECT TipoSectorId, TipoSector, RowVersion FROM TiposDeSectores";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoDeSector tipoDeSector = ConstruirTipoSector(reader);
                        lista.Add(tipoDeSector);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error a leer los datos de Tipos de Sector.");
            }
        }

        private TipoDeSector ConstruirTipoSector(SqlDataReader reader)
        {
            return new TipoDeSector()
            {
                TipoSectorId = reader.GetInt32(0),
                TipoSector = reader.GetString(1),
                RowVersion = (byte[]) reader[2]
            };        
        }

        public TipoDeSector GetTipoSectorPorId(int id)
        {
            try
            {
                TipoDeSector tipoDeSector = null;
                var cadenaComando = "SELECT TipoSectorId, TipoSector, RowVersion FROM TiposDeSectores WHERE TipoSectorId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tipoDeSector = ConstruirTipoSector(reader);
                    }
                }

                return tipoDeSector;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Agregar(TipoDeSector tipoDeSector)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "INSERT INTO TiposDeSectores (TipoSector) VALUES (@tipo)";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeSector.TipoSector);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    tipoDeSector.TipoSectorId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM TiposDeSectores WHERE TipoSectorId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tipoDeSector.TipoSectorId);
                    tipoDeSector.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Existe(TipoDeSector tipoDeSector)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM TiposDeSectores WHERE TipoSector=@tipo";
                if (tipoDeSector.TipoSectorId != 0)
                {
                    cadenaComando += " AND TipoSectorId<>@TipoSectorId";
                }

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeSector.TipoSector);
                if (tipoDeSector.TipoSectorId != 0)
                {
                    comando.Parameters.AddWithValue("@TipoSectorId", tipoDeSector.TipoSectorId);
                }
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Editar(TipoDeSector tipoDeSector)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "UPDATE TiposDeSectores SET TipoSector=@tipo WHERE TipoSectorId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", tipoDeSector.TipoSector);
                comando.Parameters.AddWithValue("@id", tipoDeSector.TipoSectorId);
                comando.Parameters.AddWithValue("@r", tipoDeSector.RowVersion);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    cadenaComando = "SELECT RowVersion FROM TiposDeSectores WHERE TipoSectorId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tipoDeSector.TipoSectorId);
                    tipoDeSector.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Borrar(TipoDeSector tipoDeSector)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM TiposDeSectores WHERE TipoSectorId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipoDeSector.TipoSectorId);
                comando.Parameters.AddWithValue("@r", tipoDeSector.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(TipoDeSector tipoDeSector)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM AlquileresEnElDia WHERE TipoSectorId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipoDeSector.TipoSectorId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
