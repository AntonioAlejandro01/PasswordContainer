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
        public string DominioCuenta { get; set; }
        public string NombreCuenta { get; set; }

        private PasswordCuenta password;
        

        public CuentaApp(string nombreCuenta,string dominioCuenta,Usuario usuario, PasswordCuenta password) : base(usuario)
        {
            NombreCuenta = nombreCuenta;
            DominioCuenta = dominioCuenta;
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
            GetUsuario().User = usuario;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CuentaApp)) return false;

            CuentaApp cuentaApp = (CuentaApp)obj;

            return cuentaApp.GetUsuario().User.ToUpper().Equals(GetUsuario().User.ToUpper()) && cuentaApp.DominioCuenta.Equals(DominioCuenta);
        }

        public override int GetHashCode()
        {
            return (DominioCuenta.ToUpper() + GetUsuario().User).GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return DominioCuenta.CompareTo(obj);
        }
    }
}
