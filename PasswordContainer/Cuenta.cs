using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public abstract class Cuenta
    {
        private Usuario usuario;



        public Cuenta(Usuario usuario) => this.usuario = usuario;




        public Usuario GetUsuario()
        {
            return usuario;
        }

        











    }
}
