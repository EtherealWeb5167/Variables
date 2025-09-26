using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        private int count = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //new FrmPrincipal().Show()
                //this.Hide();
            }
            else
            {
                count += 1;
                MessageBox.Show("Contrasena invalida");
            }
            if (count >= 3)
            {
                MessageBox.Show("Se bloqueo el usuario", "Bloqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }
    }
}
