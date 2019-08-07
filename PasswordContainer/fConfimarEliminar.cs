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
    public partial class fConfimarEliminar : Form
    {
        private bool eliminar;
        public fConfimarEliminar(string cuenta)
        {            
            InitializeComponent();
            lblNombreCuenta.Text = cuenta;
            eliminar = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            eliminar = true;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        { 
            Close();

        }
        public bool getElimina()
        {
            return eliminar;
        }

        private void FSeleccionar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void FSeleccionar_Load(object sender, EventArgs e)
        {

        }
    }
}
