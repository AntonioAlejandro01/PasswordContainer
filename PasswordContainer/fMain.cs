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


        public fMain(CuentaLoginApp cuenta)
        {
            cuentas = ManejoFicheros.CargarCuentasApp(cuenta);
            InitializeComponent();
            
        }

        private void BtnAniadir_Click(object sender, EventArgs e)
        {
            fAniadir fAniadir = new fAniadir();
            Application.Run(fAniadir);
        }

        
    }
}
