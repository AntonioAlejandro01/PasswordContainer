using System;
using System.Windows.Forms;

namespace PasswordContainer
{
    public partial class fRegistrarUsuario : Form
    {
        public fRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
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


        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (!ManejoFicheros.RegistrarCuenta(new CuentaLoginApp(new Usuario(txtUsuario.Text), new PasswordLoginApp(txtPassword.Text), null)))
            {
                Close();
                return;
            }
            BufferCuentaLogin.aniadirCuenta(new CuentaLoginApp(new Usuario(txtUsuario.Text), new PasswordLoginApp(txtPassword.Text), txtUsuario.Text + ".dat"));
            Close();
        }
    }
}
