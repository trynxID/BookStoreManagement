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
    public partial class ViewOrder : UserControl
    {
        Controller.ControllerOrder controllerOrder;
        public ViewOrder()
        {
            InitializeComponent();
            controllerOrder = new Controller.ControllerOrder(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            controllerOrder.resetData();
            controllerOrder.reqDataOrder();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            controllerOrder.reqDataOrder();
        }
    }
}
