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
    public partial class ViewCategory : UserControl
    {
        Controller.ControllerCategory controllerCategory;
        public int tempIndex;
        public ViewCategory()
        {
            InitializeComponent();
            controllerCategory = new Controller.ControllerCategory(this);
        }
        private void ViewCategory_Load(object sender, EventArgs e)
        {
            controllerCategory.reqId();
            controllerCategory.reqData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controllerCategory.reqSaveData();
            controllerCategory.reqData();
            controllerCategory.reqClearData();
            controllerCategory.reqId();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controllerCategory.reqUpdateData();
            controllerCategory.reqData();
            controllerCategory.reqClearData();
            controllerCategory.reqId();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            controllerCategory.reqRemoveData();
            controllerCategory.reqData();
            controllerCategory.reqClearData();
            controllerCategory.reqId();
        }

        private void searchCatId_Click(object sender, EventArgs e)
        {
            controllerCategory.reqSearchId();
        }

        private void searchCatName_Click(object sender, EventArgs e)
        {
            controllerCategory.reqSearchName();
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            controllerCategory.reqCellCategory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            controllerCategory.reqClear();
        }
    }
}
