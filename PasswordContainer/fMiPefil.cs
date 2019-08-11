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
        private bool isDelete;
        public fMiPefil(CuentaLoginApp cuenta)
        {
            this.cuenta = cuenta;
            verificado = false;
            isDelete = false;
            InitializeComponent();
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            txtPassword.Enabled = false;
            txtUser.Enabled = false;

        }

        private void BtnRevelar_Click(object sender, EventArgs e)
        {
            fPassword fPassword = new fPassword();
            fPassword.ShowDialog();
            if (cuenta.GetPassword().Equals(fPassword.GetPasswordLogin()))
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                txtUser.Text = cuenta.GetUsuario().getNombreUsuario();
                txtPassword.Text = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(cuenta.GetPassword().getPassword()));
                verificado = true;
                btnDelete.Enabled = true;
                btnDelete.Visible = true;
                
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
                if (ManejoFicheros.saveChangesOnLoginAccount(cuenta))
                {
                    BufferCuentaLogin.aniadirCuenta(cuenta);
                    MessageBox.Show("Datos actualizados");
                }
                else
                {
                    MessageBox.Show("Los datos no se ha actualizado");
                }
                Close();
            }
            else
            {
                MessageBox.Show("No se ha actualizado porque no has introducido la contraseña.\nPulsa el botón de \"Mostrar Datos\"");
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Esta seguro de eliminar la cuenta?\nTambién se borrarán todos las cuentas registradas a esta.", "Borrado permanente de la cuenta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ManejoFicheros.eliminarCuenta(cuenta))
                {
                    MessageBox.Show("Se ha borrado correctamente.\nSe cerrará la sesión");
                    System.IO.File.Delete(cuenta.getFichero());
                    isDelete = true;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Se canceló la operación");
            }
        }

        public bool borradoCuenta() { return isDelete; }
    }
}
