using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Login
{
    public class Administrador:Persona
    {

        public string IdAdmin { get; set; }

        public override string ToString()
        {
            return $"{IdAdmin};{Nombre};{Telefono};{Correo};{Usuario};{Contraseña};";
        }
    }
}
