using System;
using System.Collections.Generic;
using System.Configuration;
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

        public double GetRecaudado()
        {
            double recaudado;
            try
            {
                using (var c=ConexionBd.GetInstancia().AbrirConexion())
                {
                    var cadenaComando = "SELECT SUM(Monto) FROM RecaudacionDiaria WHERE Fecha=CONVERT(DATE,GETDATE())";
                    SqlCommand comando = new SqlCommand(cadenaComando, c);
                    return recaudado=(double)(decimal)comando.ExecuteScalar();                    
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Recaudacion ConstruirRecaudacion(SqlDataReader reader)
        {
            return new Recaudacion()
            {
                RecaudacionId = reader.GetInt32(0),
                Monto = reader.GetDecimal(1),
                Fecha = reader.GetDateTime(2),
                RowVersion = (byte[])reader[3]
            };
        }

        public int Agregar(Recaudacion recaudacion)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO RecaudacionDiaria (Monto, Fecha) VALUES(@monto, @fecha)");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@monto", recaudacion.Monto);
                comando.Parameters.AddWithValue("@fecha", recaudacion.Fecha);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    recaudacion.RecaudacionId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM RecaudacionDiaria WHERE RecaudacionId=@Id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", recaudacion.RecaudacionId);
                    recaudacion.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
