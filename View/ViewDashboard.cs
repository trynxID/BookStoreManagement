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
    public partial class ViewDashboard : UserControl
    {
        private Controller.ControllerDashboard controllerDashboard;
        public ViewDashboard()
        {
            InitializeComponent();
            controllerDashboard = new Controller.ControllerDashboard(this);
        }

        private void ViewDashboard_Load(object sender, EventArgs e)
        {
            controllerDashboard.reqIncome();
            controllerDashboard.reqOrder();
            controllerDashboard.reqProduct();
            controllerDashboard.reqCustomer();
            controllerDashboard.reqEmployee();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            controllerDashboard.reqIncome();
            controllerDashboard.reqOrder();
            controllerDashboard.reqProduct();
            controllerDashboard.reqCustomer();
            controllerDashboard.reqEmployee();
        }
    }
}
