using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordContainer
{
    static class Program
    {
        private static List<CuentaApp> cuentas;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fIniciarSesion fIniciar = new fIniciarSesion();
            int cont = 0;
            do {
                Application.Run(fIniciar);
                cont++;
            }
            while (!fIniciar.InicioCorrecto && cont < 6);
            if (!fIniciar.InicioCorrecto)
            {
                //TO DO window with error message
                return;
            }

            fMain fmain = new fMain(fIniciar.FilePath);
            //crear fMain
            


        }




    }
}
