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
        public static string directorioGeneral = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ "/PasswordContainer";
         private static string fCuentasLoginApp = directorioGeneral + "/loginAccounts.pswd";

        private static string extFicheroApp = ".datw";
       

        public static void CrearFicheros()
        { 
            if (!File.Exists(fCuentasLoginApp)) File.Create(fCuentasLoginApp);
        }


        public static ContenedorCuentas CargarCuentasApp(CuentaLoginApp cuenta)
        {
            try
            {
                using (Stream st = File.Open(cuenta.getFichero(), FileMode.OpenOrCreate))
                {
                    var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    try
                    {
                        return (ContenedorCuentas)binfor.Deserialize(st);
                    }
                    catch (System.Runtime.Serialization.SerializationException)
                    {
                        return new ContenedorCuentas();

                    }
                    

                }
            }catch(FileNotFoundException)
            {
                return null;
            }
            
            

        }



        public static bool GuardarCuentaApp(ContenedorCuentas cuentas, CuentaLoginApp cuenta)
        {
            if (cuentas == null)
            {
                return false;
            }
            using (Stream st = File.Open(cuenta.getFichero(), FileMode.Create))
            {
                var binfor = new BinaryFormatter();
                binfor.Serialize(st,cuentas);
                return true;

            }
            

        }

        /**
         *returns string con el nombre del fichero donde estan guardadas las cuentas de cada usuario y null si no existe el usuario o no es valida la password 
         */
        public static CuentaLoginApp LoginOnApp(CuentaLoginApp cuentaSesion)
        {
            if (cuentaSesion == null) return null;

            return existeCuenta(cuentaSesion);

        }

        private static  CuentaLoginApp existeCuenta(CuentaLoginApp cuentaSesion)
        {
            var cuentasLogin = CargarCuentasLogin();
            foreach (CuentaLoginApp cuenta in cuentasLogin)
            {
                if (cuenta.Equals(cuentaSesion))
                {
                    cuentasLogin = null;
                    return cuenta;
                }
            }
            return null;
        }



        public static bool RegistrarCuentaLogin(CuentaLoginApp cuenta)
        {
            if (existeCuenta(cuenta) != null) return false;
            var cuentas = CargarCuentasLogin();
            cuentas.Add(cuenta);
            using (Stream st = File.Open(fCuentasLoginApp, FileMode.OpenOrCreate))
            {
                var binfor = new BinaryFormatter();
                binfor.Serialize(st, cuentas);
                return true;
            }
        }


        private static List<CuentaLoginApp> CargarCuentasLogin()
        {
            using (Stream st = File.Open(fCuentasLoginApp, FileMode.Open))
            {
                var binform = new BinaryFormatter();
                try
                {
                    return (List<CuentaLoginApp>)binform.Deserialize(st);
                    
                }
                catch (System.Runtime.Serialization.SerializationException)
                {
                    return new List<CuentaLoginApp>();

                }

            }
            



        }

        public static string crearNombreFichero()
        {
            string fichero = directorioGeneral + "/" + NombreAleatorio() + extFicheroApp;
            if (File.Exists(fichero))
            {
                crearNombreFichero();
            }
            return fichero;

        }

        private static string NombreAleatorio()
        {
            Random random = new Random();
            var num = random.Next(4, 20);
            StringBuilder sbNombre = new StringBuilder(num);
            for (int i = 0; i < num; i++)
            {
                sbNombre.Append((char)random.Next(97, 122));
            }
            return sbNombre.ToString();
        }



       

        public static void generartxtCuentas(ContenedorCuentas cuentas,string file)
        {
            using (StreamWriter writter = new StreamWriter(file))
            {
                writter.WriteLine("Cuentas\n-----------------------------------------------------------------\nNombre\t\t\t\t\tUsuario\t\t\t\t\tContraseña");
                foreach (CuentaApp cuenta in cuentas.GetCuentaApps())
                {
                    writter.WriteLine(formatoCuentaApp(cuenta) +"\n");


                }

            }
        }
        private static string formatoCuentaApp(CuentaApp cuenta)
        {
            return cuenta.NombreCuenta + "\t\t\t\t\t" + cuenta.GetUsuario().getNombreUsuario() + "\t\t\t\t\t" + cuenta.GetPassword();
        }




    }
}
