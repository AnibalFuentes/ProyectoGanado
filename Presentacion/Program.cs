﻿using System;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// hola como estas
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Formularios.FrmGanado());
            
        }
    }
}
