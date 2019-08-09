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
    public partial class fPassword : Form
    {
        private PasswordLoginApp password;

        public fPassword()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            password = new PasswordLoginApp(textBox1.Text);
            Close();
        }

        public PasswordLoginApp GetPasswordLogin()
        {
            return password;
        }

    }
}
