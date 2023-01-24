using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookStoreManagement.View
{
    public partial class ViewEmployee : UserControl
    {
        Model.ModelConnection db = new Model.ModelConnection();
        Controller.ControllerEmployee controllerEmployee;
        public int tempIndex;
        public ViewEmployee()
        {
            InitializeComponent();
            controllerEmployee = new Controller.ControllerEmployee(this);
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            controllerEmployee.reqId();
            controllerEmployee.reqData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controllerEmployee.reqSaveData();
            controllerEmployee.reqData();
            controllerEmployee.reqClearData();
            controllerEmployee.reqId();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            controllerEmployee.reqUpdateData();
            controllerEmployee.reqData();
            controllerEmployee.reqClearData();
            controllerEmployee.reqId();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            controllerEmployee.reqRemoveData();
            controllerEmployee.reqData();
            controllerEmployee.reqClearData();
            controllerEmployee.reqId();
        }


        private void dataEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            controllerEmployee.reqCellEmployee();
        }

        private void employeeIdSearch_Click(object sender, EventArgs e)
        {
            controllerEmployee.reqSearchId();
        }

        private void employeeNameSearch_Click(object sender, EventArgs e)
        {
            controllerEmployee.reqSearchName();
        }
    }
}
