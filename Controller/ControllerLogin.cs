using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.Controller
{
    class ControllerLogin
    {
        Model.ModelLogin modelLogin;
        View.ViewLogin viewLogin;
        public string pesanLogin;

        public ControllerLogin(View.ViewLogin viewLogin)
        {
            modelLogin = new Model.ModelLogin();
            this.viewLogin = viewLogin;
        }
        public void userReqLogin()
        {
            modelLogin.username = viewLogin.txtUsername.Text;
            modelLogin.password = viewLogin.txtPassword.Text;
            bool hasilReqLogin = modelLogin.userLogin();
            if (hasilReqLogin)
            {
                    pesanLogin = "";
                    View.ViewHome homeLanding = new View.ViewHome();
                    homeLanding.Show();
                    this.viewLogin.Hide();
            }
            else
            {
                pesanLogin = "Username / Password Salah";
                viewLogin.txtUsername.Text = "";
                viewLogin.txtPassword.Text = "";
                viewLogin.txtUsername.Focus();
            }           
        }
        public void AdminReqLogin()
        {
            modelLogin.username = viewLogin.txtUsername.Text;
            modelLogin.password = viewLogin.txtPassword.Text;
            bool hasilReqLogin = modelLogin.adminLogin();
            if (hasilReqLogin)
            {
                pesanLogin = "";
                View.ViewHome homeLanding = new View.ViewHome();
                homeLanding.Show();
                this.viewLogin.Hide();
            }
            else
            {
                pesanLogin = "Username / Password Salah";
                viewLogin.txtUsername.Text = "";
                viewLogin.txtPassword.Text = "";
                viewLogin.txtUsername.Focus();
            }
        }
    }
}
