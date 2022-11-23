using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioCtasCtes
    {
        private SqlConnection cn;
        private SqlTransaction tran;
        public RepositorioCtasCtes (SqlConnection cn)
        {
            this.cn = cn;
        }

        public RepositorioCtasCtes(SqlConnection sqlConnection, SqlTransaction tran)
        {
            this.cn = sqlConnection;
            this.tran = tran;
        }

        public List<CtaCte> GetSaldos()
        {
            try
            {
                var lista = new List<CtaCte>();

                string strComando = "SELECT ClienteId, SUM(Debe-Haber) as Saldo FROM CtasCtes GROUP BY  ClienteId";
                using (var comando = new SqlCommand(strComando, cn))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cta = new CtaCte
                            {
                                ClienteId = reader.GetInt32(0),
                                Saldo = reader.GetDecimal(1)
                            };
                            lista.Add(cta);
                        }
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Agregar(CtaCte cta)
        {

            try
            {

                string strComando = "INSERT INTO CtasCtes (ClienteId, FechaMovimiento, Debe, Haber, Saldo) " +
                                    "VALUES(@cli, @fecha, @debe, @haber, @saldo)";
                SqlCommand comando = new SqlCommand(strComando, cn);
                comando.Parameters.AddWithValue("@cli", cta.ClienteId);
                comando.Parameters.AddWithValue("@fecha", cta.FechaMovimiento);
                comando.Parameters.AddWithValue("@debe", cta.Debe);
                comando.Parameters.AddWithValue("@haber", cta.Haber);
                comando.Parameters.AddWithValue("@saldo", cta.Saldo);

                comando.ExecuteNonQuery();

                strComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(strComando, cn);
                cta.CtaCteId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(CtaCte ctaCte, SqlConnection cn, SqlTransaction tran)
        {
            try
            {
                string strComando = "INSERT INTO CtasCtes (ClienteId, FechaMovimiento, Debe, Haber, Saldo) VALUES" +
                                    "(@cli, @fecha, @debe, @haber, @saldo)";
                SqlCommand comando = new SqlCommand(strComando, cn, tran);
                comando.Parameters.AddWithValue("@cli", ctaCte.ClienteId);
                comando.Parameters.AddWithValue("@fecha", ctaCte.FechaMovimiento);
                comando.Parameters.AddWithValue("@debe", ctaCte.Debe);
                comando.Parameters.AddWithValue("@haber", ctaCte.Haber);
                comando.Parameters.AddWithValue("@saldo", ctaCte.Saldo);

                comando.ExecuteNonQuery();

                strComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(strComando, cn, tran);
                ctaCte.CtaCteId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CtaCte> GetLista(int clienteId)
        {
            try
            {
                var lista = new List<CtaCte>();

                string strComando = "SELECT ClienteId, FechaMovimiento, Debe, Haber, Saldo FROM " +
                                    "CtasCtes WHERE ClienteId=@id ORDER BY FechaMovimiento ";
                using (var comando = new SqlCommand(strComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", clienteId);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CtaCte cta = ConstruirCtaCte(reader);
                            lista.Add(cta);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CtaCte ConstruirCtaCte(SqlDataReader reader)
        {
            return new CtaCte
            {
                ClienteId = reader.GetInt32(0),
                FechaMovimiento = reader.GetDateTime(1),
                Debe = reader.GetDecimal(2),
                Haber = reader.GetDecimal(3),
                Saldo = reader.GetDecimal(4)
            };
        }

        public decimal GetSaldo(int clienteId, SqlConnection cnn, SqlTransaction tran)
        {
            try
            {
                string strComando = "SELECT Saldo FROM CtasCtes WHERE ClienteId=@id AND CtaCteId=(" +
                                    "SELECT MAX(CtaCteId) FROM CtasCtes WHERE ClienteId=@id)";
                SqlCommand comando = new SqlCommand(strComando, cnn, tran);
                comando.Parameters.AddWithValue("@id", clienteId);
                decimal saldo = comando.ExecuteScalar() == null ? 0 : (decimal)comando.ExecuteScalar();
                return saldo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal GetSaldo(Cliente cliente)
        {
            try
            {
                string strComando = "SELECT Saldo FROM CtasCtes WHERE ClienteId=@id AND CtaCteId=(" +
                                    "SELECT MAX(CtaCteId) FROM CtasCtes WHERE ClienteId=@id)";
                SqlCommand comando = new SqlCommand(strComando, cn);
                comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                decimal saldo = comando.ExecuteScalar() == null ? 0 : (decimal)comando.ExecuteScalar();
                return saldo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
