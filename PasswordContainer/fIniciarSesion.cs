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

        private bool finApp;
        public fIniciarSesion()
        {
            InitializeComponent();
            finApp = true;
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
            finApp = false;
            CuentaLoginApp cuentaSesion = new CuentaLoginApp(new Usuario(txtUser.Text), new PasswordLoginApp(txtPassword.Text));
            cuentaSesion = ManejoFicheros.LoginOnApp(cuentaSesion);

            if (cuentaSesion == null)
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
            finApp = false;
            fRegistrarUsuario fRegistrarUsuario = new fRegistrarUsuario();
            fRegistrarUsuario.Show();
            CuentaLoginApp cuentaNueva = BufferCuentaLogin.ExtraerCuentaLoginApp();
            if(cuentaNueva == null|| cuentaNueva.getFichero() == null)
            {
                Close();
                return;
            }
            BufferCuentaLogin.aniadirCuenta(cuentaNueva);
            Close();


        }

        private void FIniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (finApp) Application.Exit();
        }

        private void FIniciarSesion_Load(object sender, EventArgs e)
        {
            finApp = true;
        }
    }
}
