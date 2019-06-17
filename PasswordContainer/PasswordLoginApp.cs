using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    public class PasswordLoginApp : Password
    {

        public PasswordLoginApp(string password) : base(password) { }


        public override bool Equals(object obj)
        {
            if (!(obj is PasswordLoginApp)) return false;
            PasswordLoginApp pssLoApp = (PasswordLoginApp)obj;
            return pssLoApp.getPassword().Equals(getPassword());
        }

    }
}
