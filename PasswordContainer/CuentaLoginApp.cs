using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public class CuentaLoginApp : Cuenta 
    {
        private PasswordLoginApp password;
        public string Fichero { get; private set; }



        public CuentaLoginApp(Usuario usuario, PasswordLoginApp password, string fichero) : base(usuario)
        {
            this.password = password;
            Fichero = fichero;
        }






    }
}
