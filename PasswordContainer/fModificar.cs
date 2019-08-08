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
            txtNombreCuenta.Text = cuenta.NombreCuenta;
            txtUser.Text = cuenta.GetUsuario().getNombreUsuario();
            txtPssword.Text = cuenta.GetPassword();
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            aceptarCambios = true;
            cuentaCambiar = new CuentaApp(txtNombreCuenta.Text,new Usuario(txtUser.Text),new PasswordCuenta(txtPssword.Text));
            BufferCuentaApp.aniadirCuentaApp(cuentaCambiar);
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
