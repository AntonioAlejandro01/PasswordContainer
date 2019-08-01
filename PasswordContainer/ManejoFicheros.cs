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
        public static string directorio = Environment.GetEnvironmentVariable("HOMEPATH") + "/PasswordContainer";
        private static string fCuentasApp = directorio + "/appsCounts.datw";
        private static string fCuentasLoginApp = directorio + "/loginCounts.pswd";


        public static void CrearFicheros()
        {
            if (!File.Exists(fCuentasApp)) File.Create(fCuentasApp);
            if (!File.Exists(fCuentasLoginApp)) File.Create(fCuentasLoginApp);
        }


        public static ContenedorCuentas CargarCuentasApp()
        {
            ContenedorCuentas cuentas;
            try
            {
                using (Stream st = File.Open(fCuentasApp, FileMode.Open))
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



        public static bool GuardarCuentaApp(ContenedorCuentas cuentas)
        {
            if (cuentas == null)
            {
                return false;
            }
            using (Stream st = File.Open(fCuentasApp, FileMode.Create))
            {
                var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
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



        public static bool GuardarCuentaLogin(CuentaLoginApp cuenta)
        {
            if (existeCuenta(cuenta) != null) return false;
            var cuentas = CargarCuentasLogin();
            cuentas.Add(cuenta);
            using (Stream st = File.Open(fCuentasLoginApp, FileMode.Create))
            {
                var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binfor.Serialize(st, cuentas);
                return true;
            }
        }


        private static List<CuentaLoginApp> CargarCuentasLogin()
        {
            List<CuentaLoginApp> cuentasLogin = null;
            using (Stream st = File.Open(fCuentasLoginApp, FileMode.Open))
            {
                var binform = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
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
            return cuenta.NombreCuenta + "\t\t\t\t\t" + cuenta.GetUsuario().User + "\t\t\t\t\t" + cuenta.GetPassword();
        }




    }
}
