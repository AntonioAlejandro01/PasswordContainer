using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    [Serializable]
    public class CuentaLoginApp : Cuenta 
    {
        private PasswordLoginApp password;
        public string fichero; 
        

        public CuentaLoginApp(Usuario usuario, PasswordLoginApp password) : base(usuario)
        {
            this.password = password;
            setFichero(ManejoFicheros.crearNombreFichero());
        }

        public PasswordLoginApp GetPassword()
        {
            return password;
        }
        public bool SetPassword(string newPassword,PasswordLoginApp oldPassword)
        {
            if (GetPassword().Equals(oldPassword))
            {
                GetPassword().SetPassword(newPassword);
                return true;
            }
            return false;

        }
        

        public string getFichero()
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(fichero));
        }
        public void setFichero(string value)
        {
            fichero = Convert.ToBase64String(Encoding.Unicode.GetBytes(value));
        }
        public bool mismoFichero(CuentaLoginApp cuenta)
        {
            return cuenta.getFichero().Equals(getFichero());
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CuentaLoginApp)) return false;
            CuentaLoginApp cuenta = (CuentaLoginApp)obj;
            return cuenta.GetUsuario().getNombreUsuario().Equals(GetUsuario().getNombreUsuario());

        }






    }
}
