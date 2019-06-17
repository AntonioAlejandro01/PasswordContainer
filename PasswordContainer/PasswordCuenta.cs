using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public class PasswordCuenta : Password
    {

        public PasswordCuenta(string password) : base(password){ }

        public override string getPassword()
        {
            return desencriptar(base.getPassword());
        }
    }
}
