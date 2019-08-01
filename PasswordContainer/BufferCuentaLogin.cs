using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public static class BufferCuentaLogin
    {

        private static CuentaLoginApp cuentaLogin;
        public static bool HayCuenta {get; private set;}


        public static void aniadirCuenta(CuentaLoginApp cuenta)
        {
            cuentaLogin = cuenta;
            HayCuenta = true;

        }

        public static CuentaLoginApp ExtraerCuentaLoginApp()
        {
            if (!HayCuenta)
            {
                return null;
            }
            CuentaLoginApp tmp = cuentaLogin;
            cuentaLogin = null;
            HayCuenta = false;
            return tmp;
            
        }

       


    }
}
