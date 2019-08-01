using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordContainer
{
    public partial class fSeleccionar : Form
    {
        private CuentaApp[] cuentas;
        private string[] nombresCuentas;
        public fSeleccionar(CuentaApp[] cuentas)
        {
            this.cuentas = cuentas;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BufferCuentaApp.aniadirCuentaApp(buscarCuenta((string)lstbNombresCuentas.Items[lstbNombresCuentas.SelectedIndex]));
            Close();
        }

        private void FSeleccionar_Load(object sender, EventArgs e)
        {
            if(cuentas == null)
            {
                MessageBox.Show("No hay cuentas disponibles para mostrar");
                Close();
                return;
            }
            nombresCuentas = cargarNombres();
            foreach (string elemento in nombresCuentas)
            {
                lstbNombresCuentas.Items.Add(elemento);
            }


        }

        private string[] cargarNombres()
        {
            string[] nombres = new string[cuentas.Length];
            for(int i = 0;i < cuentas.Length; i++)
            {
                nombres[i] = cuentas[i].NombreCuenta;
            }

            return nombres;

        }
        private CuentaApp buscarCuenta(string nombreCuenta)
        {
            foreach (CuentaApp cuenta in cuentas)
            {
                if (cuenta.NombreCuenta.Equals(nombreCuenta))
                {
                    return cuenta;
                }

            }
            return null;

        }
    }
}
