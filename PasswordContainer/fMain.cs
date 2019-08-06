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
    public partial class fMain : Form
    {

        private ContenedorCuentas cuentas;
        private CuentaLoginApp cuenta;


        public fMain(CuentaLoginApp cuenta)
        {
            this.cuenta = cuenta;
            cuentas = ManejoFicheros.CargarCuentasApp(cuenta);
            InitializeComponent();
            
        }

        private void BtnAniadir_Click(object sender, EventArgs e)
        {
            fAniadir fAniadir = new fAniadir();
            fAniadir.ShowDialog();
            if (!BufferCuentaApp.HayCuenta)
            { 
                return;
            }
            CuentaApp cuenta = BufferCuentaApp.extraerCuentaApp();
            if (cuentas.contains(cuenta))
            {
                MessageBox.Show("Error la cuenta ya existe");
                return;
            }
            cuentas.Add(cuenta);
            MessageBox.Show("Cuenta añadida con exito");

        }

        private void FMain_Load(object sender, EventArgs e)
        {
            lblVisor.Text += " de " + cuenta.GetUsuario().User;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
        }
       
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            if (cuentas.size() == 0)
            {
                MessageBox.Show("No hay ninguna cuenta guardada");
                return;
            }
            CuentaApp cuenta = cuentaSeleccionada();
            mostrarCuenta(cuenta);
            if (cuentas.remove(cuenta))
            {
                MessageBox.Show("Cuenta eliminada.\nSe muestra a continuacion");
            }
            else
            {
                MessageBox.Show("Cuenta No eliminada.");
            }


        }

       

        private void BtnDocumento_Click(object sender, EventArgs e)
        {
            if (sFileDial.ShowDialog() == DialogResult.OK)
            {
                ManejoFicheros.generartxtCuentas(cuentas, sFileDial.FileName);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

            
            if (cuentas.size() == 0)
            {
                MessageBox.Show("No hay ninguna cuenta guardada");
                return;
            }
            mostrarCuenta(cuentaSeleccionada());
            
            
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = !textPassword.UseSystemPasswordChar;
            if (textPassword.UseSystemPasswordChar)
            {
                btnVer.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btnVer.FlatAppearance.BorderSize = 1;
            }
        }

        private CuentaApp cuentaSeleccionada()
        {
            if (cuentas.size() == 0)
            {
               
                return null;
            }
            fSeleccionar fSelect = new fSeleccionar(cuentas.GetCuentaApps());
            fSelect.ShowDialog();
            return BufferCuentaApp.extraerCuentaApp();
        }

        private void mostrarCuenta(CuentaApp cuenta)
        {
            if (cuenta == null) return;
            lblNombreCuenta.Text = "Cuenta " + cuenta.NombreCuenta;
            textUser.Text = cuenta.GetUsuario().User;
            textPassword.Text = cuenta.GetPassword();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Validar.cerrarSesion = true;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ManejoFicheros.GuardarCuentaApp(cuentas, cuenta))
            {
                MessageBox.Show("Se guardo con exito");
            }
            else
            {
                MessageBox.Show("ERROR.Hubo un problema al guardar los datos");
            }
        }
    }
}
