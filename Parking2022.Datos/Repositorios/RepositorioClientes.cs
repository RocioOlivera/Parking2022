using Parking2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Datos.Repositorios
{
    public class RepositorioClientes
    {
        private SqlConnection cn;

        public RepositorioClientes(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                var cadenaComando =
                    "SELECT ClienteId, ApellidoYNombre, NumDocumento, TelDeContacto, RowVersion FROM Clientes ORDER BY ApellidoYNombre";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = ConstruirCliente(reader);
                        lista.Add(cliente);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Cliente ConstruirCliente(SqlDataReader reader)
        {
            return new Cliente()
            {
                ClienteId = reader.GetInt32(0),
                ApellidoYNombre = reader.GetString(1),
                NumDocumento = reader.GetString(2),
                TelDeContacto = reader.GetString(3),
                RowVersion = (byte[])reader[4]
            };
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE ApellidoYNombre=@nom";
                if (cliente.ClienteId != 0)
                {
                    cadenaComando += " AND ClienteId<>@Id";
                }

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", cliente.ApellidoYNombre);
                if (cliente.ClienteId != 0)
                {
                    comando.Parameters.AddWithValue("@Id", cliente.ClienteId);
                }

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Cliente cliente)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Clientes SET ApellidoYNombre=@nom, NumDocumento=@doc, TelDeContacto=@tel WHERE ClienteId=@id");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", cliente.ApellidoYNombre);
                comando.Parameters.AddWithValue("@doc", cliente.NumDocumento);
                comando.Parameters.AddWithValue("@tel", cliente.TelDeContacto);
                comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {

                    cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                    cliente.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Cliente cliente)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Clientes WHERE ClienteId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                comando.Parameters.AddWithValue("@r", cliente.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM CtasCtes WHERE ClienteId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Cliente cliente)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Clientes (ApellidoYNombre, NumDocumento, TelDeContacto) VALUES (@nom, @doc, @tel)");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", cliente.ApellidoYNombre);
                comando.Parameters.AddWithValue("@doc", cliente.NumDocumento);
                comando.Parameters.AddWithValue("@tel", cliente.TelDeContacto);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    cliente.ClienteId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                    cliente.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCantidad()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Clientes");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);

                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cliente GetClientePorId(int id)
        {
            Cliente cliente = null;
            try
            {
                var cadenaComando =
                    "SELECT ClienteId, ApellidoYNombre, NumDocumento, TelDeContacto, RowVersion FROM Clientes WHERE ClienteId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            cliente = ConstruirCliente(reader);
                        }
                    }
                }
                return cliente;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Cliente> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ClienteId, ApellidoYNombre, NumDocumento, TelDeContacto, RowVersion FROM Clientes ");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
             
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = ConstruirCliente(reader);
                        lista.Add(cliente);
                    }

                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al leer de la tabla de Clientes");
            }

        }
    }
}
