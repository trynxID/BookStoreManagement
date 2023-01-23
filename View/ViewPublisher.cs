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
    public partial class ViewPublisher : UserControl
    {
        Controller.ControllerPublisher controllerPublisher;
        public int tempIndex;
        public ViewPublisher()
        {
            InitializeComponent();
            controllerPublisher = new Controller.ControllerPublisher(this);
        }

        private void ViewPublisher_Load(object sender, EventArgs e)
        {
            controllerPublisher.reqId();
            controllerPublisher.reqData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controllerPublisher.reqSaveData();
            controllerPublisher.reqData();
            controllerPublisher.reqClearData();
            controllerPublisher.reqId();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controllerPublisher.reqUpdateData();
            controllerPublisher.reqData();
            controllerPublisher.reqClearData();
            controllerPublisher.reqId();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            controllerPublisher.reqRemoveData();
            controllerPublisher.reqData();
            controllerPublisher.reqClearData();
            controllerPublisher.reqId();
        }

        private void searchPubId_Click(object sender, EventArgs e)
        {
            controllerPublisher.reqSearchId();
        }

        private void searchPubName_Click(object sender, EventArgs e)
        {
            controllerPublisher.reqSearchName();
        }

        private void dataPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            controllerPublisher.reqCellPublisher();
        }

    }
}
