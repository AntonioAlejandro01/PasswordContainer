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

        private bool sesionIniciada;
        private ContenedorCuentas cuentas;
        private CuentaLoginApp cuenta;
        private static string mensajePeligro = "La información esta a la vista.";


        public fMain(CuentaLoginApp cuenta)
        {
            this.cuenta = cuenta;
            cuentas = ManejoFicheros.CargarCuentasApp(cuenta);
            sesionIniciada = true;

            InitializeComponent();

           
            toolTip1.SetToolTip(lblPeligro,mensajePeligro);
            lblNombreCuenta.Text = "Nombre de la Cuenta";
            lblUsuario.Text = "Nombre de usuario";
            lblPassword.Text = "Contraseña";
            lblPassword.UseSystemPasswordChar = false;
            lblUsuario.UseSystemPasswordChar = false;

        }


        private void FMain_Load(object sender, EventArgs e)
        {

            recargar();
            lnklblUser.Text = cuenta.GetUsuario().getNombreUsuario();
            lblPeligro.Visible = false;
            lblPeligro2.Visible = false;
            lblUsuario.UseSystemPasswordChar = true;
            lblPassword.UseSystemPasswordChar = true;
        }

        private void ListBoxCuentasApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CuentaApp cuenta = buscarCuenta((string)listBoxCuentasApp.SelectedItem);
            mostrarCuenta(cuenta);
            lblPeligro.Visible = false;
            lblPeligro2.Visible = false;

            lblPassword.UseSystemPasswordChar = true;
            lblUsuario.UseSystemPasswordChar = true;

            lblEscudo.Visible = true;
            lblEscudo2.Visible = true;

            btnEncriptar.Enabled = false;
            btnDesencriptar.Enabled = true;
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
            btnEncriptar.Enabled = true;
            btnDesencriptar.Enabled = false;

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
            //FMain_Load(sender,e);
            recargar();
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (cuentas.size() == 0)
            {
                MessageBox.Show("No hay ninguna cuenta guardada");
                return;
            }
            fConfimarEliminar fSeleccionar = new fConfimarEliminar((string)listBoxCuentasApp.SelectedItem);
            fSeleccionar.ShowDialog();
            if (!fSeleccionar.getElimina())
            {
                MessageBox.Show("Operación cancelada");
                return;
            }
            fSeleccionar.Close();
            CuentaApp cuenta = buscarCuenta((string)listBoxCuentasApp.SelectedItem);
            if (cuentas.remove(cuenta))
            {
                MessageBox.Show("Cuenta eliminada.");
                //FMain_Load(null, null);
                recargar();
                ManejoFicheros.GuardarCuentaApp(this.cuentas, this.cuenta);
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
            if (save())
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

            btnDesencriptar.Enabled = true;
            btnEncriptar.Enabled = false;

        }

        private void Modificar(object sender, EventArgs e)
        {
            CuentaApp cuenta = buscarCuenta((string)listBoxCuentasApp.SelectedItem);
            fModificar fModificar = new fModificar(cuenta);
            bool valido = false;
            while (!valido)
            {
                fModificar.ShowDialog();
                if (!fModificar.cambiosAceptados())
                {
                    MessageBox.Show("Se cancelo la operacion");
                    return;
                }
                CuentaApp cuentaModificada = BufferCuentaApp.extraerCuentaApp();
                if (cuenta.Equals(cuentaModificada))
                {
                    cuenta.SetUsuario(cuentaModificada.GetUsuario().getNombreUsuario());
                    cuenta.SetPassword(cuentaModificada.GetPassword());
                    valido = true;
                }
                else if (buscarCuenta(cuentaModificada.NombreCuenta) == null)
                {
                    cuenta.NombreCuenta = cuentaModificada.NombreCuenta;
                    cuenta.SetUsuario(cuentaModificada.GetUsuario().getNombreUsuario());
                    cuenta.SetPassword(cuentaModificada.GetPassword());
                    valido = true;
                }
                else
                {
                    MessageBox.Show("Nombre de cuenta repetido");
                }
                //FMain_Load(null, null);
                recargar();
            }
            





        }

        private void LnklblUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fMiPefil fMiPefil = new fMiPefil(cuenta);
            fMiPefil.ShowDialog();
            if (BufferCuentaLogin.HayCuenta)
            {
                cuenta = BufferCuentaLogin.ExtraerCuentaLoginApp();
            }
            if (fMiPefil.borradoCuenta())
            {
                sesionIniciada = false;
                fMiPefil.Close();
                fMiPefil.Dispose();
                Close();

            }
            fMiPefil.Close();
            fMiPefil.Dispose();
            FMain_Load(null, null);
        }

        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
            sesionIniciada = false;
            Close();

        }

        public bool sesionEnable()
        {
            return sesionIniciada;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
            Application.Exit();
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void recargar()
        {
            listBoxCuentasApp.DataSource = cuentas.getNombresCuentas();
        }

        private bool save()
        {
            return ManejoFicheros.GuardarCuentaApp(cuentas, cuenta);
        }
    }
}
