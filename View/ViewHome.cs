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
    public partial class ViewHome : Form
    {
        public ViewHome()
        {
            InitializeComponent();
        }

        private void ViewHome_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            viewDashboard.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            viewDashboard.BringToFront();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCategories.Height;
            SidePanel.Top = btnCategories.Top;
            viewCategory.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProducts.Height;
            SidePanel.Top = btnProducts.Top;
            viewBook.BringToFront();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCustomers.Height;
            SidePanel.Top = btnCustomers.Top;
            viewCustomer.BringToFront();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnOrders.Height;
            SidePanel.Top = btnOrders.Top;
            viewOrder.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCheckout.Height;
            SidePanel.Top = btnCheckout.Top;
            viewCheckout.BringToFront();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            ViewLogin login = new ViewLogin();
            login.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPublisher.Height;
            SidePanel.Top = btnPublisher.Top;
            viewPublisher.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEmployee.Height;
            SidePanel.Top = btnEmployee.Top;
            viewEmployee.BringToFront();
        }
    }
}
