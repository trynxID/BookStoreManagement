using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerCheckout
    {
        Model.ModelCheckout modelCheckout;
        View.ViewCheckout viewCheckout;

        public ControllerCheckout(View.ViewCheckout viewCheckout)
        {
            modelCheckout = new Model.ModelCheckout();
            this.viewCheckout = viewCheckout;
        }
        public void reqId()
        {
            modelCheckout.updateIdCheckout();
            viewCheckout.txtNoInvoice.Text = modelCheckout.noTemp;
        }
        public void reqFill()
        {
            modelCheckout.loadDataCusname();
            modelCheckout.loadDataBooktitle();
            viewCheckout.txtNameCustomer.Items.AddRange(modelCheckout.objName);
            viewCheckout.txtTitleBook.Items.AddRange(modelCheckout.objTitle);
        }
        public void reqData()
        {
            modelCheckout.updateDataCheckout();
            viewCheckout.dataCart.AutoGenerateColumns = false;
            viewCheckout.dataCart.DataSource = modelCheckout.dataTempCheckout;
        }
        public void reqClearBook()
        {
            viewCheckout.txtTitleBook.ResetText();
            viewCheckout.txtPriceBook.Text = "";
            viewCheckout.txtQuantityBook.Text = "";
        }
        public void reqClearAll()
        {
            viewCheckout.dataCart.DataSource = null;
            viewCheckout.txtGrandTotal.Clear();
            viewCheckout.txtPriceTotal.Clear();
            viewCheckout.txtQuantityBook.Clear();
            viewCheckout.txtPriceBook.Clear();
            viewCheckout.txtTitleBook.ResetText();
            viewCheckout.txtAddressCustomer.Clear();
            viewCheckout.txtContactCustomer.Clear();
            viewCheckout.txtNameCustomer.ResetText();
            viewCheckout.txtNoInvoice.Clear();
        }
        public void reqGrandTotal()
        {
            modelCheckout.tempDataCheckout = viewCheckout.dataCart;
            modelCheckout.addGrandTotal();
            viewCheckout.txtGrandTotal.Text = modelCheckout.totalGrandTemp;
        }
        public void reqAddToCart()
        {
            modelCheckout.noInvoiceTemp = viewCheckout.txtNoInvoice.Text;
            modelCheckout.idCustomerTemp = viewCheckout.txtIdCustomer.Text;
            modelCheckout.nameCustomerTemp = viewCheckout.txtNameCustomer.Text;
            modelCheckout.idBookTemp = viewCheckout.txtIdBook.Text;
            modelCheckout.titleBookTemp = viewCheckout.txtTitleBook.Text;
            modelCheckout.priceBookTemp = viewCheckout.txtPriceBook.Text;
            modelCheckout.quantityBookTemp = viewCheckout.txtQuantityBook.Text;
            modelCheckout.priceTotalTemp = viewCheckout.txtPriceTotal.Text;
            modelCheckout.addDataCheckout();
            this.reqData();
            this.reqGrandTotal();
            this.reqClearBook();
        }
        public void reqDeleteData()
        {
            modelCheckout.idBookTemp = viewCheckout.txtIdBook.Text;
            modelCheckout.titleBookTemp = viewCheckout.txtTitleBook.Text;
            modelCheckout.priceBookTemp = viewCheckout.txtPriceBook.Text;
            modelCheckout.quantityBookTemp = viewCheckout.txtQuantityBook.Text;
            modelCheckout.deleteDataCheckout();
            this.reqData();
            this.reqGrandTotal();
            this.reqClearBook();
        }
        public void reqContentCustomer()
        {
            modelCheckout.nameCustomerTemp = viewCheckout.txtNameCustomer.Text;
            modelCheckout.updateContentCustomer();
            viewCheckout.txtIdCustomer.Text = modelCheckout.idCustomerTemp;
            viewCheckout.txtNameCustomer.Text = modelCheckout.nameCustomerTemp;
            viewCheckout.txtContactCustomer.Text = modelCheckout.contactCustomerTemp;
            viewCheckout.txtAddressCustomer.Text = modelCheckout.addressCustomerTemp;
        }
        public void reqContentBook()
        {
            modelCheckout.nameCustomerTemp = viewCheckout.txtNameCustomer.Text;
            modelCheckout.addressCustomerTemp = viewCheckout.txtAddressCustomer.Text;
            modelCheckout.contactCustomerTemp = viewCheckout.txtContactCustomer.Text;
            modelCheckout.titleBookTemp = viewCheckout.txtTitleBook.Text;
            modelCheckout.updateContentBook();
            viewCheckout.txtIdBook.Text = modelCheckout.idBookTemp;
            viewCheckout.txtTitleBook.Text = modelCheckout.titleBookTemp;
            viewCheckout.txtPriceBook.Text = modelCheckout.priceBookTemp;
        }
        public void reqContentQuantity()
        {
            modelCheckout.quantityBookTemp = viewCheckout.txtQuantityBook.Text;
            modelCheckout.priceBookTemp = viewCheckout.txtPriceBook.Text;
            modelCheckout.updateContentQuantity();
            viewCheckout.txtPriceTotal.Text = modelCheckout.priceTotalTemp;
        }
        public void reqSaveData()
        {
            modelCheckout.dateInvoiceTemp = viewCheckout.txtDateInvoice.Text;
            modelCheckout.noInvoiceTemp = viewCheckout.txtNoInvoice.Text;
            modelCheckout.idCustomerTemp = viewCheckout.txtIdCustomer.Text;
            modelCheckout.nameCustomerTemp = viewCheckout.txtNameCustomer.Text;
            modelCheckout.contactCustomerTemp = viewCheckout.txtContactCustomer.Text;
            modelCheckout.addressCustomerTemp = viewCheckout.txtAddressCustomer.Text;
            modelCheckout.totalGrandTemp = viewCheckout.txtGrandTotal.Text;
            modelCheckout.saveDataCheckout();
            this.reqClearAll();
            this.reqId();
        }
        public void reqEditData()
        {
            modelCheckout.dateInvoiceTemp = viewCheckout.txtDateInvoice.Text;
            modelCheckout.noInvoiceTemp = viewCheckout.txtNoInvoice.Text;
            modelCheckout.idCustomerTemp = viewCheckout.txtIdCustomer.Text;
            modelCheckout.nameCustomerTemp = viewCheckout.txtNameCustomer.Text;
            modelCheckout.contactCustomerTemp = viewCheckout.txtContactCustomer.Text;
            modelCheckout.addressCustomerTemp = viewCheckout.txtAddressCustomer.Text;
            modelCheckout.totalGrandTemp = viewCheckout.txtGrandTotal.Text;
            modelCheckout.editDataCheckout();
            this.reqClearAll();
            this.reqId();
        }
        public void reqRemoveData()
        {
            modelCheckout.noInvoiceTemp = viewCheckout.txtNoInvoice.Text;
            modelCheckout.nameCustomerTemp = viewCheckout.txtNameCustomer.Text;
            modelCheckout.removeDataCheckout();
            this.reqDeleteData();
            this.reqClearAll();
            this.reqId();
        }
        public void reqSearchData()
        {
            modelCheckout.noInvoiceTemp = viewCheckout.txtNoInvoice.Text;
            modelCheckout.searchDataCheckout();
            viewCheckout.txtDateInvoice.Text = modelCheckout.dateInvoiceTemp;
            viewCheckout.txtIdCustomer.Text = modelCheckout.idCustomerTemp;
            viewCheckout.txtNameCustomer.Text = modelCheckout.nameCustomerTemp;
            viewCheckout.txtContactCustomer.Text = modelCheckout.contactCustomerTemp;
            viewCheckout.txtAddressCustomer.Text = modelCheckout.addressCustomerTemp;
            viewCheckout.txtGrandTotal.Text = modelCheckout.totalGrandTemp;
            this.reqData();
            this.reqCellBook();
        }
        public void reqCellBook()
        {
            modelCheckout.tempDataCheckout = viewCheckout.dataCart;
            modelCheckout.indexCheckout = viewCheckout.tempIndex;
            modelCheckout.cellDataCheckout();
            viewCheckout.txtTitleBook.Text = modelCheckout.titleBookTemp;
            viewCheckout.txtPriceBook.Text = modelCheckout.priceBookTemp;
            viewCheckout.txtQuantityBook.Text = modelCheckout.quantityBookTemp;
        }
    }
}
