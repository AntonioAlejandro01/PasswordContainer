using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    [Serializable]
    public class CuentaApp : Cuenta , IComparable
    {
        public string NombreCuenta { get; set; }

        private PasswordCuenta password;
        

        public CuentaApp(string nombreCuenta,Usuario usuario, PasswordCuenta password) : base(usuario)
        {
            NombreCuenta = nombreCuenta;
            this.password = password;
        }



        public string GetPassword()
        {
            return password.getPassword();
        }

        public void SetPassword(string password)
        {
            this.password = new PasswordCuenta(password);
        }

        public void SetUsuario(string usuario)
        {
            GetUsuario().setNombreUsuario(usuario);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CuentaApp)) return false;

            CuentaApp cuentaApp = (CuentaApp)obj;

            return cuentaApp.GetUsuario().getNombreUsuario().ToUpper().Equals(GetUsuario().getNombreUsuario().ToUpper()) && cuentaApp.NombreCuenta.ToUpper().Equals(NombreCuenta.ToUpper());
        }

        public override int GetHashCode()
        {
            return (NombreCuenta.ToUpper() + GetUsuario().getNombreUsuario()).GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return NombreCuenta.CompareTo(obj);
        }

        public override string ToString()
        {
            return NombreCuenta.ToUpper() + "\n"+GetUsuario().getNombreUsuario() + "\n" + GetPassword();
        }
    }
}
