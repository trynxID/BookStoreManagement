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
    public partial class ViewBook : UserControl
    {
        Controller.ControllerBook controllerBook;
        public int tempIndex;
        public ViewBook()
        {
            InitializeComponent();
            controllerBook = new Controller.ControllerBook(this);
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            controllerBook.reqId();
            controllerBook.reqData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controllerBook.reqSaveData();
            controllerBook.reqData();
            controllerBook.reqClearData();
            controllerBook.reqId();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controllerBook.reqUpdateData();
            controllerBook.reqData();
            controllerBook.reqClearData();
            controllerBook.reqId();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            controllerBook.reqRemoveData();
            controllerBook.reqData();
            controllerBook.reqClearData();
            controllerBook.reqId();
        }

        private void bookIdSearch_Click(object sender, EventArgs e)
        {
            controllerBook.reqSearchId();
        }

        private void bookTitleSearch_Click(object sender, EventArgs e)
        {
            controllerBook.reqSearchName();
        }

        private void dataBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            controllerBook.reqCellBook();
        }
    }
}
