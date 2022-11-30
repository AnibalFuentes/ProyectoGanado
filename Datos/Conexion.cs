using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{   
    public class Conexion
    {

        //public static SqlConnection ObtenerConexion()
        //{
        //    SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProyectoGanado;Data Source=LAPTOP-7SE5NEVI\\SQLEXPRESS");
        //    conexion.Open();    
        //    return conexion;
        //}
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexión"].ToString();
    }
}
