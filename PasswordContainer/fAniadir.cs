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
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            CuentaApp cuenta = new CuentaApp(nombreCuenta, new Usuario(usuario), new PasswordCuenta(password));

            if (!Validar.validarCuentaApp(cuenta))
            {
                txtPassword.Clear();
                MessageBox.Show("Error al procesar la cuenta.\nAlgunos campos están vacios.");
                return;
            }

            BufferCuentaApp.aniadirCuentaApp(cuenta);
            Close();
        
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if (txtPassword.UseSystemPasswordChar)
            {
                btnVer.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btnVer.FlatAppearance.BorderSize = 1;
            }
        }
    }
}
