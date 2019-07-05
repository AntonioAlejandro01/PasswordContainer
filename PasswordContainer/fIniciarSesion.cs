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
    public partial class fIniciarSesion : Form
    {


        public fIniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if (txtPassword.UseSystemPasswordChar)
            {
                btnVer.FlatAppearance.BorderSize = 0 ;
            }
            else
            {
                btnVer.FlatAppearance.BorderSize = 1;
            }
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            
            CuentaLoginApp cuentaSesion = new CuentaLoginApp(new Usuario(txtUser.Text), new PasswordLoginApp(txtPassword.Text), null);
            cuentaSesion = ManejoFicheros.LoginOnApp(cuentaSesion);


            if (cuentaSesion == null || cuentaSesion.Fichero == null)
            { 
                Close();
                return;
            }
            BufferCuentaLogin.aniadirCuenta(cuentaSesion);
            Close();
            
        }


        private void LnkPassOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LnkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fRegistrarUsuario fRegistrarUsuario = new fRegistrarUsuario();
            fRegistrarUsuario.ShowDialog();
            CuentaLoginApp cuentaNueva = BufferCuentaLogin.ExtraerCuentaLoginApp();
            if(cuentaNueva == null|| cuentaNueva.Fichero == null)
            {
                Close();
                return;
            }
            BufferCuentaLogin.aniadirCuenta(cuentaNueva);
            Close();


        }
    }
}
