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
            return (!cuenta.GetPassword().Equals("")  && !cuenta.DominioCuenta.Equals("") && !cuenta.GetUsuario().Equals("") && !cuenta.NombreCuenta.Equals("")) ;
        }




    }
}
