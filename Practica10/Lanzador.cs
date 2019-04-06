/*
 * Autor: Sara Blanco Muñoz
 * Fecha: 31/01/2018
 * Práctica: Aplicación Windows. Editor de texto
*/
using System;
using System.Windows.Forms;

namespace Practica10
{
    static class Lanzador
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new editor());
        }
    }
}
