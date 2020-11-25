using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using capaPresentacion;

namespace POS_TZA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(frmPrincipal.GetInstancia());
            Application.Run(frmVentas.GetInstancia());
            //Application.Run(new frmConfig());
        }
    }
}
