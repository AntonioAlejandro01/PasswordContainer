using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public static class Validar
    {
        public static bool validarCuentaApp(CuentaApp cuenta)
        {
            return (cuenta.GetPassword() == null || cuenta.DominioCuenta == null || cuenta.GetUsuario() == null) ;
        }



    }
}
