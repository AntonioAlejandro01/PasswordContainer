using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer
{
    [Serializable]
    public class ContenedorCuentas
    {
        private List<CuentaApp> cuentas;




        public ContenedorCuentas()
        {
            cuentas = new List<CuentaApp>();
        }


        public bool Add(CuentaApp cuenta)
        {
            if (!Validar.validarCuentaApp(cuenta)) return false;
            if (EstaCuenta(cuenta)) return false;

            cuentas.Add(cuenta);

            return true;
        }


        public bool remove(CuentaApp cuenta)
        {
            if (!Validar.validarCuentaApp(cuenta)) return false;
            if (!EstaCuenta(cuenta)) return false;

            cuentas.Remove(cuenta);

            return true;

        

        }
        

        public CuentaApp[] GetCuentaApps()
        {
            cuentas.TrimExcess();
            CuentaApp[] cuentasTmp = cuentas.ToArray();
            return cuentasTmp;
        }

        public string[] getNombresCuentas()
        {
            var cuentas = GetCuentaApps();
            string[] nombresCuentas = new string[cuentas.Length];
            for (int i = 0; i < cuentas.Length; i++)
            {
                nombresCuentas[i] = cuentas[i].NombreCuenta;
            }
            return nombresCuentas;
        }

        private void ordenar(CuentaApp[] cuentas)
        {
            CuentaApp aux;
            for (int i = 0; i < cuentas.Length; i++)
            {
                for (int j = 0; j < cuentas.Length; j++)
                {
                    if (cuentas[i].CompareTo(cuentas[j]) > 0)
                    {
                        aux = cuentas[i];
                        cuentas[i] = cuentas[j];
                        cuentas[j] = aux;
                    }

                }
            }
        }

        public bool contains(CuentaApp cuenta)
        {
            foreach(CuentaApp cuentaApp in cuentas)
            {
                if (cuenta.Equals(cuentaApp))
                {
                    return true;
                }
            }
            return false;
        }




        private bool EstaCuenta(CuentaApp cuenta)
        {
            return cuentas.Contains(cuenta);

        }

        public int size()
        {
            return cuentas.Count;
        }

        public bool isEmpty()
        {
            return cuentas.Count == 0;
        }


       
    }
}
