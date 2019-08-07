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
    public partial class fModificar : Form
    {

        private bool aceptarCambios;
        private CuentaApp cuentaCambiar;
        public fModificar(CuentaApp cuenta)
        {
            InitializeComponent();
            if (txtNombreCuenta.Text.Equals(cuenta.NombreCuenta))
            {
                txtUser.Text = cuenta.GetUsuario().getNombreUsuario();
                txtPssword.Text = cuenta.GetPassword();
                aceptarCambios = false;
                Close();
            }
            //comprobar que no esta repetido
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            aceptarCambios = true;
            cuentaCambiar.NombreCuenta = txtNombreCuenta.Text;
            cuentaCambiar.SetUsuario(txtUser.Text);
            cuentaCambiar.SetUsuario(txtPssword.Text);
            //comprobar que no este repetida
            Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        public bool cambiosAceptados()
        {
            return aceptarCambios;
        }
    }
}
