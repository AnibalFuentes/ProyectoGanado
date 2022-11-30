using Datos;
using Entidad.Login;
using System.Collections.Generic;

namespace Negocio
{
    public class L_Usuario
    {   //Usuario
        private D_Usuario datosUsuario = new D_Usuario();
        public List<Usuario> Validar()
        {
            return datosUsuario.ValidarUsuarios();
        }
    }
}
