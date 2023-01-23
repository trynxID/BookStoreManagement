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
    public partial class ViewCustomer : UserControl
    {
        Controller.ControllerCustomer controllerCustomer;
        public int tempIndex;
        public ViewCustomer()
        {
            InitializeComponent();
            controllerCustomer = new Controller.ControllerCustomer(this);
        }
        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            controllerCustomer.reqId();
            controllerCustomer.reqData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            controllerCustomer.reqSaveData();
            controllerCustomer.reqData();
            controllerCustomer.reqClearData();
            controllerCustomer.reqId();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controllerCustomer.reqUpdateData();
            controllerCustomer.reqData();
            controllerCustomer.reqClearData();
            controllerCustomer.reqId();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            controllerCustomer.reqRemoveData();
            controllerCustomer.reqData();
            controllerCustomer.reqClearData();
            controllerCustomer.reqId();
        }

        private void customerIdSearch_Click(object sender, EventArgs e)
        {
            controllerCustomer.reqSearchId();
        }

        private void customerNameSearch_Click(object sender, EventArgs e)
        {
            controllerCustomer.reqSearchName();
        }

        private void dataCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            controllerCustomer.reqCellCustomer();
        }
    }
}
