using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StreamWriter ganados = new StreamWriter("ganado.txt",true);
            ganados.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Formularios.FrmGanado());
            
        }
    }
}
