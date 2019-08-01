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
        private static CuentaLoginApp user = new CuentaLoginApp(new Usuario("antonio"),new PasswordLoginApp("antonio"),"");
       

        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CrearCarpeta();
            ManejoFicheros.CrearFicheros();
            int intentos = 5;
            bool inicioSesion = false;
            while (!ObtenerUsuario() && --intentos != 0 && !inicioSesion)
            {
                user = ManejoFicheros.LoginOnApp(user);
                inicioSesion = (user == null);
                if (!inicioSesion)
                {
                    MessageBox.Show("Error. \nUsuario o contraseña incorrecta");
                }

            }
            if (intentos == 0)
            {
                MessageBox.Show("Numero de intentos de iniciar sesión cumplidos.\nAdiós.");
                return;
            }
           

            Application.Run(new fMain(user));
            
            Application.Exit();
        }

        /**
         * Método que crea la carpeta doande se van a guardar los archivos
         */
        private static void CrearCarpeta()
        {
            if (Directory.Exists(ManejoFicheros.directorioGeneral)) return;

            DirectoryInfo Dif = new DirectoryInfo(ManejoFicheros.directorioGeneral);
            Dif.Create();
            Dif.Attributes = FileAttributes.Hidden;

        }

       

        private static bool ObtenerUsuario()
        {
            fIniciarSesion fIniciar = new fIniciarSesion();
            Application.Run(fIniciar);
            if (!BufferCuentaLogin.HayCuenta)
            {
                return false;
            }
            user = BufferCuentaLogin.ExtraerCuentaLoginApp();
            return true;
        }


        




    }
}
