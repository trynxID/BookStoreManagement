using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerEmployee
    {
        Model.ModelEmployee modelEmployee;
        View.ViewEmployee viewEmployee;

        public ControllerEmployee(View.ViewEmployee viewEmployee)
        {
            modelEmployee = new Model.ModelEmployee();
            this.viewEmployee = viewEmployee;
        }
        public void reqId()
        {
            modelEmployee.updateIdEmployee();
            viewEmployee.txtIdEmployee.Text = modelEmployee.idTemp;
        }
        public void reqData()
        {
            modelEmployee.updateDataEmployee();
            viewEmployee.dataEmployee.AutoGenerateColumns = false;
            viewEmployee.dataEmployee.DataSource = modelEmployee.dataTempEmployee;            
        }
        public void reqSaveData()
        {
            modelEmployee.idEmployeeTemp = viewEmployee.txtIdEmployee.Text;
            modelEmployee.usernameEmployeeTemp = viewEmployee.txtUsernameEmployee.Text;
            modelEmployee.passwordEmployeeTemp = viewEmployee.txtPasswordEmployee.Text;
            modelEmployee.fullnameEmployeeTemp = viewEmployee.txtFullnameEmployee.Text;
            modelEmployee.contactEmployeeTemp = viewEmployee.txtContactEmployee.Text;
            modelEmployee.emailEmployeeTemp = viewEmployee.txtEmailEmployee.Text;
            modelEmployee.saveDataEmployee();
        }
        public void reqUpdateData()
        {
            modelEmployee.idEmployeeTemp = viewEmployee.txtIdEmployee.Text;
            modelEmployee.usernameEmployeeTemp = viewEmployee.txtUsernameEmployee.Text;
            modelEmployee.passwordEmployeeTemp = viewEmployee.txtPasswordEmployee.Text;
            modelEmployee.fullnameEmployeeTemp = viewEmployee.txtFullnameEmployee.Text;
            modelEmployee.contactEmployeeTemp = viewEmployee.txtContactEmployee.Text;
            modelEmployee.emailEmployeeTemp = viewEmployee.txtEmailEmployee.Text;
            modelEmployee.editDataEmployee();
        }
        public void reqRemoveData()
        {
            modelEmployee.idEmployeeTemp = viewEmployee.txtIdEmployee.Text;
            modelEmployee.usernameEmployeeTemp = viewEmployee.txtUsernameEmployee.Text;
            modelEmployee.passwordEmployeeTemp = viewEmployee.txtPasswordEmployee.Text;
            modelEmployee.fullnameEmployeeTemp = viewEmployee.txtFullnameEmployee.Text;
            modelEmployee.contactEmployeeTemp = viewEmployee.txtContactEmployee.Text;
            modelEmployee.emailEmployeeTemp = viewEmployee.txtEmailEmployee.Text;
            modelEmployee.removeDataEmployee();
        }
        public void reqClearData()
        {
            viewEmployee.txtIdEmployee.Text = "";
            viewEmployee.txtUsernameEmployee.Text = "";
            viewEmployee.txtFullnameEmployee.Text = "";
            viewEmployee.txtPasswordEmployee.Text = "";
            viewEmployee.txtContactEmployee.Text = "";
            viewEmployee.txtEmailEmployee.Text = "";
        }
        public void reqSearchId()
        {
            modelEmployee.idEmployeeTemp = viewEmployee.txtIdEmployee.Text;
            modelEmployee.searchIdEmployee();
            viewEmployee.txtIdEmployee.Text = modelEmployee.idEmployeeTemp;
            viewEmployee.txtUsernameEmployee.Text = modelEmployee.usernameEmployeeTemp;
            viewEmployee.txtFullnameEmployee.Text = modelEmployee.fullnameEmployeeTemp;
            viewEmployee.txtPasswordEmployee.Text = modelEmployee.passwordEmployeeTemp;
            viewEmployee.txtContactEmployee.Text = modelEmployee.contactEmployeeTemp;
            viewEmployee.txtEmailEmployee.Text = modelEmployee.emailEmployeeTemp;
        }
        public void reqSearchName()
        {
            modelEmployee.usernameEmployeeTemp = viewEmployee.txtUsernameEmployee.Text;
            modelEmployee.searchNameEmployee();
            viewEmployee.txtIdEmployee.Text = modelEmployee.idEmployeeTemp;
            viewEmployee.txtUsernameEmployee.Text = modelEmployee.usernameEmployeeTemp;
            viewEmployee.txtFullnameEmployee.Text = modelEmployee.fullnameEmployeeTemp;
            viewEmployee.txtPasswordEmployee.Text = modelEmployee.passwordEmployeeTemp;
            viewEmployee.txtContactEmployee.Text = modelEmployee.contactEmployeeTemp;
            viewEmployee.txtEmailEmployee.Text = modelEmployee.emailEmployeeTemp;
        }
        public void reqCellEmployee()
        {
            modelEmployee.tempDataEmployee = viewEmployee.dataEmployee;
            modelEmployee.indexEmployee = viewEmployee.tempIndex;
            modelEmployee.cellDataEmployee();
            viewEmployee.txtIdEmployee.Text = modelEmployee.idEmployeeTemp;
            viewEmployee.txtUsernameEmployee.Text = modelEmployee.usernameEmployeeTemp;
            viewEmployee.txtFullnameEmployee.Text = modelEmployee.fullnameEmployeeTemp;
            viewEmployee.txtPasswordEmployee.Text = modelEmployee.passwordEmployeeTemp;
            viewEmployee.txtContactEmployee.Text = modelEmployee.contactEmployeeTemp;
            viewEmployee.txtEmailEmployee.Text = modelEmployee.emailEmployeeTemp;
        }
    }
}
