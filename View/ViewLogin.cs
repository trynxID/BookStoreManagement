using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.View
{
    public partial class ViewLogin : Form
    {
        private Controller.ControllerLogin controllerLogin;
        public ViewLogin()
        {
            InitializeComponent();
            controllerLogin = new Controller.ControllerLogin(this);
        }

        private void ViewLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblAdmin.Visible = false;
            lblUserLogin.Visible = false;
            btnAdminLogin.Visible = false;
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            controllerLogin.userReqLogin();
            if (controllerLogin.pesanLogin != "")
            {
                MessageBox.Show(controllerLogin.pesanLogin, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            controllerLogin.AdminReqLogin();
            if (controllerLogin.pesanLogin != "")
            {
                MessageBox.Show(controllerLogin.pesanLogin,"Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void lblUserLogin_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            lblUserLogin.Visible = false;
            btnAdminLogin.Visible = false;
            lblAdminLogin.Visible = true;
        }
    

        private void lblAdminLogin_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = true;
            lblUserLogin.Visible = true;
            btnAdminLogin.Visible = true;
            lblAdminLogin.Visible = false;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
