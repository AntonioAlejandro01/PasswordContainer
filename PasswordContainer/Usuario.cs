using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    [Serializable]
    public class Usuario
    {
        private string nombreUsuario;

        public Usuario(string usuario)
        {
            setNombreUsuario(usuario);
            
        }


        public string getNombreUsuario()
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(nombreUsuario));
        }
        public void setNombreUsuario(string value)
        {
            nombreUsuario = Convert.ToBase64String(Encoding.Unicode.GetBytes(value));
        }


        public override bool Equals(object obj)
        {
            if (!(obj is Usuario)) return false;

            Usuario usuario = (Usuario)obj;
            return usuario.Equals(getNombreUsuario());
        }







    }
}
