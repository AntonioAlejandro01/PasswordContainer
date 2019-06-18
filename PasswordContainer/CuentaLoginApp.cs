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





    }
}
