using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public static class BufferCuentaApp
    {
        private static CuentaApp cuentaBuffered;
        public static bool HayCuenta{ get; private set; }

        public static void aniadirCuentaApp(CuentaApp cuenta)
        {
            cuentaBuffered = cuenta;
            HayCuenta = true;

        }

        public static CuentaApp extraerCuentaApp()
        {
            if (HayCuenta)
            {
                HayCuenta = false;
                CuentaApp tmp = cuentaBuffered;
                cuentaBuffered = null;
                return tmp;

            }
            return null;
        }



    }
}
