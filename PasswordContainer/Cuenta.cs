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

        public override bool Equals(object obj)
        {
            if (!(obj is Cuenta)) return false;

            Cuenta cuenta = (Cuenta)obj;
            return usuario.User.Equals(cuenta.GetUsuario());
        }











    }
}
