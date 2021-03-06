﻿using System;
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
            if (txtPassword.Text == null || txtPassword.Text.Equals("") || txtUsuario.Text == null || txtUsuario.Text.Equals("")) 
            {
                MessageBox.Show("Uno o los dos campos estan vacios");
                txtPassword.Clear();
                txtUsuario.Clear();
                return;
            }
            if (!ManejoFicheros.RegistrarCuentaLogin(new CuentaLoginApp(new Usuario(txtUsuario.Text), new PasswordLoginApp(txtPassword.Text))))
            {
                Close();
                return;
            }
            else
            {
                BufferCuentaLogin.aniadirCuenta(new CuentaLoginApp(new Usuario(txtUsuario.Text), new PasswordLoginApp(txtPassword.Text)));
                Close();
            }
            Close();
        }
    }
}
