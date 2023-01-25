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
    public partial class ViewCheckout : UserControl
    {
        Controller.ControllerCheckout controllerCheckout;

        public int tempIndex;
        public ViewCheckout()
        {
            InitializeComponent();
            controllerCheckout = new Controller.ControllerCheckout(this);
        }

        private void ViewCheckout_Load(object sender, EventArgs e)
        {
            controllerCheckout.reqId();
            controllerCheckout.reqFill();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqAddToCart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqSaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqDeleteData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqEditData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqRemoveData();
        }

        private void searchNoInvoice_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqSearchData();
        }

        private void txtNameCustomer_TextChanged(object sender, EventArgs e)
        {
            controllerCheckout.reqContentCustomer();
        }

        private void txtTitleBook_TextChanged(object sender, EventArgs e)
        {
            controllerCheckout.reqContentBook();
        }

        private void txtQuantityBook_TextChanged(object sender, EventArgs e)
        {
            controllerCheckout.reqContentQuantity();
        }

        private void dataCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            controllerCheckout.reqCellBook();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            controllerCheckout.reqClearAll();
            controllerCheckout.reqId();
        }
    }
}
