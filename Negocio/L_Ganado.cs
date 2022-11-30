using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class L_Ganado
    {
        D_Ganado Datos_ganados = new D_Ganado();

        public List<Ganado> Listar()
        {
            return Datos_ganados.ListarGanados();
        }
        public int Registrar(Ganado Ganado, out string mensaje)
        {
            return Datos_ganados.RegistrarGanado(Ganado, out mensaje);
        }
        public bool Editar(Ganado Ganado, out string mensaje)
        {
            return Datos_ganados.EditarGanado(Ganado, out mensaje);
        }
        public bool Eliminar(Ganado Ganado, out string mensaje)
        {
            return Datos_ganados.EliminarGanado(Ganado ,out mensaje);
        }
    }
}
