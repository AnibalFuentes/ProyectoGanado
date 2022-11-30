using Entidad.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Usuario
    {   
        public List<Usuario> ValidarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.Append("select IdUsuario, Nombre, Correo, Telefono,TipoUsuario, usuario, Contraseña from Usuario");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                Nombre = reader["Nombre"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                TipoUsuario = Convert.ToBoolean(reader["TipoUsuario"].ToString()),
                                User = reader["usuario"].ToString(),
                                Contraseña = reader["Contraseña"].ToString()
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    usuarios = new List<Usuario>();
                    connection.Close();
                    throw ex;
                }
            }
            return usuarios;
        }
    }
}
