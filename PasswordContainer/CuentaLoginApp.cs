using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    class CuentaLoginApp : Cuenta 
    {
        private PasswordLoginApp password;



        public CuentaLoginApp(Usuario usuario, PasswordLoginApp password) : base(usuario)
        {
            this.password = password;
        }


        public bool login(Usuario usuario , string password)
        {
            return (GetUsuario().Equals(usuario) && this.password.Equals(new PasswordLoginApp(password)));
        }




    }
}
