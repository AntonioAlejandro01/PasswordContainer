using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordContainer
{
    public partial class fAniadir : Form
    {
        public fAniadir()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string nombreCuenta = txtNombreCuenta.Text;
            string dominio = txtDominio.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            CuentaApp cuenta = new CuentaApp(nombreCuenta, dominio, new Usuario(usuario), new PasswordCuenta(password));

            if (!Validar.validarCuentaApp(cuenta))
            {
                txtPassword.Clear();
                Application.Run(new fErrorAniadir());
            }
            else
            {
               

            }


        }

       
    }
}
