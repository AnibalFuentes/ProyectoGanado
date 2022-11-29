using System.Configuration;

namespace Datos
{   //Conexion a la base de datos
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexión"].ToString();
    }
}
