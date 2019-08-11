using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PasswordContainer
{
    static class Program
    {
        private static CuentaLoginApp user;
       

        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CrearCarpeta();
            
            ManejoFicheros.CrearFicheros();
            int intentos;
            bool inicioSesion;
            bool sesioniniciada = false;
            while (!sesioniniciada)
            {
                user = null;
                inicioSesion = false;
                intentos = 5;
                for (int i = 0; i < intentos && !inicioSesion; i++)
                {

                    if (ObtenerUsuario())
                    {
                        ManejoFicheros.LoginOnApp(user);
                        inicioSesion = true;
                        MessageBox.Show("Sesion iniciada");

                    }
                    else
                    {
                        MessageBox.Show("Datos no validos");
                    }
                }

                if (!inicioSesion)
                {
                    MessageBox.Show("Numero de intentos de iniciar sesión cumplidos.\nAdiós.");
                    return;
                }
                fMain fMain = new fMain(user);
                Application.Run(fMain);
                sesioniniciada = fMain.sesionEnable();
            }
            
            Application.Exit();
        }

        /**
         * Método que crea la carpeta donde se van a guardar los archivos
         */
        private static void CrearCarpeta()
        {
            if (Directory.Exists(ManejoFicheros.GetDirectorioGeneral())) return;

            DirectoryInfo Dif = new DirectoryInfo(ManejoFicheros.GetDirectorioGeneral());
            Dif.Create();
            Dif.Attributes = FileAttributes.Hidden;
            using (FileStream fs = File.Create(ManejoFicheros.getPathFicheroCuentasLogin()))
            {
                fs.Close();
            }

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
