using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioNrosSectores
    {
        private SqlConnection cn;

        public RepositorioNrosSectores(SqlConnection cn)
        {
            this.cn = cn;
        }
        public List<NrosSectores> GetLista(TipoDeSector tipoDeSector=null)
        {
            List<NrosSectores> lista = new List<NrosSectores>();
            try
            {
                StringBuilder sb = 
                    new StringBuilder("SELECT NroId, TipoSectorId, Nro, Ocupado, RowVersion FROM NrosSectores ");
                if (tipoDeSector!=null)
                {
                    sb.Append("WHERE TipoSectorId=@id ORDER BY Nro");
                }
                else
                {
                    sb.Append(" ORDER BY Nro");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (tipoDeSector!=null)
                {
                    comando.Parameters.AddWithValue("@id", tipoDeSector.TipoSectorId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NrosSectores nrosSectores = ConstruirNroSectores(reader);
                        lista.Add(nrosSectores);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Agregar(NrosSectores nrosSectores)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "INSERT INTO NrosSectores (NroId, TipoSectorId, Nro, Ocupado, VALUES (@id, @tipo, @nro, @ocu)";
                var comando=new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", nrosSectores.TipoSectorId);
                comando.Parameters.AddWithValue("@tipo", nrosSectores.TipoSectorId);
                comando.Parameters.AddWithValue("@nro", nrosSectores.Nro);
                comando.Parameters.AddWithValue("@ocu", nrosSectores.Ocupado);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    nrosSectores.NroId = (int) (decimal) comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM NrosSectores WHERE NroId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", nrosSectores.NroId);
                    nrosSectores.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(NrosSectores nrosSectores)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM DetallesAlquileresDia WHERE NroId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", nrosSectores.NroId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(NrosSectores nrosSectores)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM NrosSectores WHERE NroId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", nrosSectores.NroId);
                comando.Parameters.AddWithValue("@r", nrosSectores.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(NrosSectores nrosSectores)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE NrosSectores SET TipoSectorId=@tipo, Nro=@nro, Ocupado=@ocupa WHERE NroId=@id AND RowVersion=@r");
                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipo", nrosSectores.TipoSectorId);
                comando.Parameters.AddWithValue("@nro", nrosSectores.Nro);
                comando.Parameters.AddWithValue("@ocupa", nrosSectores.Ocupado);

                comando.Parameters.AddWithValue("@r", nrosSectores.RowVersion);
                comando.Parameters.AddWithValue(@"id", nrosSectores.NroId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {
                    cadenaComando = "SELECT RowVersion FROM NrosSectores WHERE NroId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", nrosSectores.NroId);
                    nrosSectores.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private NrosSectores ConstruirNroSectores(SqlDataReader reader)
        {
            return new NrosSectores()
            {
                NroId = reader.GetInt32(0),
                TipoSectorId = reader.GetInt32(1),
                Nro = reader.GetString(2),
                Ocupado = reader.GetBoolean(3),
                RowVersion = (byte[])reader[4]
            };
        }
        public NrosSectores GetNroPorId(int id)
        {
            try
            {
                NrosSectores nrosSectores = null;
                var cadenaComando = "SELECT NroId, TipoSectorId, Nro, Ocupado, RowVersion FROM NrosSectores WHERE NroId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nrosSectores = ConstruirNroSectores(reader);
                    }
                }

                return nrosSectores;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
