using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerCustomer
    {
        Model.ModelCustomer modelCustomer;
        View.ViewCustomer viewCustomer;

        public ControllerCustomer(View.ViewCustomer viewCustomer)
        {
            modelCustomer = new Model.ModelCustomer();
            this.viewCustomer = viewCustomer;
        }
        public void reqId()
        {
            modelCustomer.updateIdCustomer();
            viewCustomer.txtIdCustomer.Text = modelCustomer.idTemp;
        }
        public void reqData()
        {
            modelCustomer.updateDataCustomer();
            viewCustomer.dataCustomer.AutoGenerateColumns = false;
            viewCustomer.dataCustomer.DataSource = modelCustomer.dataTempCustomer;
        }
        public void reqSaveData()
        {
            modelCustomer.idCustomerTemp = viewCustomer.txtIdCustomer.Text;
            modelCustomer.nameCustomerTemp = viewCustomer.txtNameCustomer.Text;
            modelCustomer.contactCustomerTemp = viewCustomer.txtContactCustomer.Text;
            modelCustomer.addressCustomerTemp = viewCustomer.txtAddressCustomer.Text;
            modelCustomer.saveDataCustomer();
        }
        public void reqUpdateData()
        {
            modelCustomer.idCustomerTemp = viewCustomer.txtIdCustomer.Text;
            modelCustomer.nameCustomerTemp = viewCustomer.txtNameCustomer.Text;
            modelCustomer.contactCustomerTemp = viewCustomer.txtContactCustomer.Text;
            modelCustomer.addressCustomerTemp = viewCustomer.txtAddressCustomer.Text;
            modelCustomer.editDataCustomer();
        }
        public void reqRemoveData()
        {
            modelCustomer.idCustomerTemp = viewCustomer.txtIdCustomer.Text;
            modelCustomer.nameCustomerTemp = viewCustomer.txtNameCustomer.Text;
            modelCustomer.contactCustomerTemp = viewCustomer.txtContactCustomer.Text;
            modelCustomer.addressCustomerTemp = viewCustomer.txtAddressCustomer.Text;
            modelCustomer.removeDataCustomer();
        }
        public void reqClearData()
        {
            viewCustomer.txtIdCustomer.Text = "";
            viewCustomer.txtNameCustomer.Text = "";
            viewCustomer.txtContactCustomer.Text = "";
            viewCustomer.txtAddressCustomer.Text = "";
        }
        public void reqSearchId()
        {
            modelCustomer.idCustomerTemp = viewCustomer.txtIdCustomer.Text;
            modelCustomer.searchIdCustomer();
            viewCustomer.txtIdCustomer.Text = modelCustomer.idCustomerTemp;
            viewCustomer.txtNameCustomer.Text = modelCustomer.nameCustomerTemp;
            viewCustomer.txtContactCustomer.Text = modelCustomer.contactCustomerTemp;
            viewCustomer.txtAddressCustomer.Text = modelCustomer.addressCustomerTemp;
        }
        public void reqSearchName()
        {
            modelCustomer.nameCustomerTemp = viewCustomer.txtNameCustomer.Text;
            modelCustomer.searchNameCustomer();
            viewCustomer.txtIdCustomer.Text = modelCustomer.idCustomerTemp;
            viewCustomer.txtNameCustomer.Text = modelCustomer.nameCustomerTemp;
            viewCustomer.txtContactCustomer.Text = modelCustomer.contactCustomerTemp;
            viewCustomer.txtAddressCustomer.Text = modelCustomer.addressCustomerTemp;
        }
        public void reqCellCustomer()
        {
            modelCustomer.tempDataCustomer = viewCustomer.dataCustomer;
            modelCustomer.indexCustomer = viewCustomer.tempIndex;
            modelCustomer.cellDataCustomer();
            viewCustomer.txtIdCustomer.Text = modelCustomer.idCustomerTemp;
            viewCustomer.txtNameCustomer.Text = modelCustomer.nameCustomerTemp;
            viewCustomer.txtContactCustomer.Text = modelCustomer.contactCustomerTemp;
            viewCustomer.txtAddressCustomer.Text = modelCustomer.addressCustomerTemp;
        }
    }
}
