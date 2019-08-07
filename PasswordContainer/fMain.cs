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
        private static string mensajePeligro = "La información esta a la vista.";


        public fMain(CuentaLoginApp cuenta)
        {
            this.cuenta = cuenta;
            cuentas = ManejoFicheros.CargarCuentasApp(cuenta);

            InitializeComponent();
            lblListado.Text += cuenta.GetUsuario().getNombreUsuario();
            toolTip1.SetToolTip(lblPeligro,mensajePeligro);

        }


        private void FMain_Load(object sender, EventArgs e)
        {
            
            listBoxCuentasApp.DataSource = cuentas.getNombresCuentas();
            lblPeligro.Visible = false;
            lblPeligro2.Visible = false;
            lblUsuario.Clear();
            lblPassword.Clear();
            lblUsuario.UseSystemPasswordChar = true;
            lblPassword.UseSystemPasswordChar = true;
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

        private void BtnRecogerCuenta_Click(object sender, EventArgs e)
        {
            CuentaApp cuenta = buscarCuenta((string)listBoxCuentasApp.SelectedItem);
            mostrarCuenta(cuenta);
            lblPeligro.Visible = false;
            lblPeligro2.Visible = false;

            lblPassword.UseSystemPasswordChar = true;
            lblUsuario.UseSystemPasswordChar = true;

            lblEscudo.Visible = true;
            lblEscudo2.Visible = true;

        }

        private void mostrarCuenta(CuentaApp cuenta)
        {
            lblNombreCuenta.Text = cuenta.NombreCuenta;
            lblUsuario.Text = cuenta.GetUsuario().getNombreUsuario();
            lblPassword.Text = cuenta.GetPassword();

        }

        

        private CuentaApp buscarCuenta(string nombreCuenta)
        {
            var cuentas = this.cuentas.GetCuentaApps();
            foreach (CuentaApp cuenta in cuentas)
            {
                if (nombreCuenta.Equals(cuenta.NombreCuenta))
                {
                    return cuenta;
                }

            }
            return null;
        }

        private void BtnDesencriptar_Click(object sender, EventArgs e)
        {
            lblUsuario.UseSystemPasswordChar = false;
            lblPassword.UseSystemPasswordChar = false;
            lblPeligro.Visible = true;
            lblPeligro2.Visible = true;
            lblEscudo.Visible = false;
            lblEscudo2.Visible = false;

        }

        private void Aniadir(object sender, EventArgs e)
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
            FMain_Load(sender,e);

        }

        private void Eliminar(object sender, EventArgs e)
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

        private void MenStMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SavesChanges(object sender, EventArgs e)
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

        private void generateTxt(object sender, EventArgs e)
        {
            if (sFileDial.ShowDialog() == DialogResult.OK)
            {
                ManejoFicheros.generartxtCuentas(cuentas, sFileDial.FileName);
            }

        }

        private void LblPeligro_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void BtnEncriptar_Click(object sender, EventArgs e)
        {
            lblUsuario.UseSystemPasswordChar = true;
            lblPassword.UseSystemPasswordChar = true;
            lblPeligro.Visible = false;
            lblPeligro2.Visible = false;
            lblEscudo.Visible = true;
            lblEscudo2.Visible = true;

        }
    }
}
