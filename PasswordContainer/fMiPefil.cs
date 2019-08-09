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
    public partial class fMiPefil : Form
    {
        private CuentaLoginApp cuenta;
        private bool verificado;
        public fMiPefil(CuentaLoginApp cuenta)
        {
            this.cuenta = cuenta;
            verificado = false;
            InitializeComponent();

        }

        private void BtnRevelar_Click(object sender, EventArgs e)
        {
            fPassword fPassword = new fPassword();
            fPassword.ShowDialog();
            if (cuenta.GetPassword().Equals(fPassword.GetPasswordLogin()))
            {
                txtUser.Text = cuenta.GetUsuario().getNombreUsuario();
                txtPassword.Text = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(cuenta.GetPassword().getPassword()));
                verificado = true;
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void BtnCambios_Click(object sender, EventArgs e)
        {
            if (verificado)
            {
                cuenta.GetUsuario().setNombreUsuario(txtUser.Text);
                cuenta.SetPassword(txtPassword.Text, cuenta.GetPassword());
                Close();
            }
            else
            {
                MessageBox.Show("No se cambiado nada porque no has introducido la contraseña.Pulsa el botón de \"Mostrar Datos\"");
            }

        }
    }
}
