using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordContainer
{
    static class Program
    {
        private static CuentaLoginApp user;


        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CrearCarpeta();
            int intentos = 5;
            while (!ObtenerUsuario() && --intentos != 0) ;
            if (intentos == 0)
            {
                MessageBox.Show("Numero de intentos de iniciar sesión cumplidos.\nAdiós.");
                //return;
            }
           

            Application.Run(new fMain(user));
            Application.Exit();
        }

        /**
         * Método que crea la carpeta doande se van a guardar los archivos
         */
        private static void CrearCarpeta()
        {
            if (Directory.Exists(ManejoFicheros.carpetaUsuariosLogin))
            {
                return;
            }
            Directory.CreateDirectory("C:\\Users\\anton\\Desktop");
        }

        private static bool ObtenerUsuario()
        {
            fIniciarSesion fIniciar = new fIniciarSesion();
            Application.Run(fIniciar);
            if (!BufferCuentaLogin.HayCuenta)
            {
                MessageBox.Show("Error en el inicio de sesión.");
                return false;
            }
            user = BufferCuentaLogin.ExtraerCuentaLoginApp();
            return true;
        }


        




    }
}
