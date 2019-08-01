using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    [Serializable]
    public abstract class Password
    {
        private string passwordEncript;//la password solo se desencripta para verla

      
        public Password(string password)
        {
            passwordEncript = encriptar(password);
        }

        public virtual string getPassword()
        {
            return passwordEncript;
        }






        protected string encriptar(string password)
        {
             return Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(password));
        }



        protected string desencriptar(string passwordEncript)
        {         
            return System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(passwordEncript));

        }






    }
}
