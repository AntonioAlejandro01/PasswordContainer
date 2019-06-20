using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PasswordContainer
{
    public static class ManejoFicheros
    {

        public static string carpetaUsuariosLogin = "%ProgramFiles%/ContainerPassword";
        private static string nombreFicheroLogin = "UsuariosLogin.dat";


        public static ContenedorCuentas CargarCuentasApp(CuentaLoginApp user)
        {
            throw new NotImplementedException();

        }



        public static bool GuardarCuentasApp(List<CuentaApp> cuentas, string file)
        {
            return false;

        }

        /**
         *returns string con el nombre del fichero donde estan guardadas las cuentas de cada usuario y null si no existe el usuario o no es valida la password 
         */
        public static CuentaLoginApp LoginOnApp(CuentaLoginApp cuentaSesion)
        {
            return cuentaSesion;

        }

        private static List<CuentaLoginApp> CargarCuentasLogin()
        {
            FileStream fs = new FileStream(carpetaUsuariosLogin + "/" + nombreFicheroLogin, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<CuentaLoginApp> cuentas = binaryFormatter.Deserialize(fs) as List<CuentaLoginApp>;
            fs.Close();
            return cuentas;
        } 


        private static bool GuardarCuentasLogin(List<CuentaLoginApp> cuentas)
        {
            try
            {
                Stream SaveFileStream = File.Create(carpetaUsuariosLogin + "/" + nombreFicheroLogin);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, cuentas);
                SaveFileStream.Close();
                return true;
            }
            catch (Exception) { }
            return false;



        }

        public static bool RegistrarCuenta(CuentaLoginApp cuenta)
        {
            //comprobar si esta repetido el nombre de usuario en ese caso devuleve falso. Si no se reptie devuleve true
            return false;
        }




    }
}
