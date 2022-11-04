using System.Collections.Generic;

namespace Entidad.Login
{
    public class Cliente:Persona
    { 

        public List<Ganado> ganados { get; set; }

        public override string ToString()
        {
            return $"{Nombre};{Telefono};{Correo};{Usuario};{Contraseña};";
        }

        public string MostrarGanados()
        {
            return $"{ganados}";
        }
    }
}
