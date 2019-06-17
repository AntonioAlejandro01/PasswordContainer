using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public class Usuario
    {
        public string User { get; set; }

        public Usuario(string usuario)
        {
            User = usuario;
        }



        public override bool Equals(object obj)
        {
            if (!(obj is Usuario)) return false;

            Usuario usuario = (Usuario)obj;
            return usuario.Equals(User);
        }







    }
}
