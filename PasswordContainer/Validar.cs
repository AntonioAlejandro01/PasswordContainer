using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public static class Validar
    {
        public static bool cerrarSesion { get; set; } 
        public static bool validarCuentaApp(CuentaApp cuenta)
        {
            return (!cuenta.GetPassword().Equals("")  && !cuenta.GetUsuario().Equals("") && !cuenta.NombreCuenta.Equals("") && !cuenta.GetPassword().Equals("")) ;
        }




    }
}
