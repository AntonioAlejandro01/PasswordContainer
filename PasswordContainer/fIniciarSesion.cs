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

        public bool InicioCorrecto { get; private set; }
        public string FilePath { get; private set; }

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
            CuentaLoginApp cuentaSesion = new CuentaLoginApp(new Usuario(txtUser.Text), new PasswordLoginApp(txtPassword.Text));
            string file = ManejoFicheros.LoginOnApp(cuentaSesion);

            if (file == null)
            {
                InicioCorrecto = false;
                FilePath = file;
                return;
            }
            InicioCorrecto = true;
            FilePath = file;
        }

        private void mostrarError()
        {
            throw new NotImplementedException();

        }

        private void LnkPassOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LnkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
