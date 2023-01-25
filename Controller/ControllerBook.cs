using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerBook
    {
        Model.ModelBook modelBook;
        View.ViewBook viewBook;

        public ControllerBook(View.ViewBook viewBook)
        {
            modelBook = new Model.ModelBook();
            this.viewBook = viewBook;
        }
        public void reqId()
        {
            modelBook.updateIdBook();
            viewBook.txtIdBook.Text = modelBook.idTemp;
        }
        public void reqData()
        {
            modelBook.updateDataBook();
            modelBook.loadDataCategory();
            modelBook.loadDataPublisher();
            viewBook.dataBook.AutoGenerateColumns = false;
            viewBook.dataBook.DataSource = modelBook.dataTempBook;
            viewBook.txtCategoryBook.Items.AddRange(modelBook.objCat);
            viewBook.txtPublisherBook.Items.AddRange(modelBook.objPub);
        }
        public void reqSaveData()
        {
            modelBook.idBookTemp = viewBook.txtIdBook.Text;
            modelBook.nameBookTemp = viewBook.txtTitleBook.Text;
            modelBook.priceBookTemp = viewBook.txtPriceBook.Text;
            modelBook.writerBookTemp = viewBook.txtWriterBook.Text;
            modelBook.quantityBookTemp = viewBook.txtQuantityBook.Text;
            modelBook.categoryBookTemp = viewBook.txtCategoryBook.Text;
            modelBook.publicationBookTemp = viewBook.txtPublicationBook.Text;
            modelBook.publisherBookTemp = viewBook.txtPublisherBook.Text;
            modelBook.saveDataBook();
        }
        public void reqUpdateData()
        {
            modelBook.idBookTemp = viewBook.txtIdBook.Text;
            modelBook.nameBookTemp = viewBook.txtTitleBook.Text;
            modelBook.priceBookTemp = viewBook.txtPriceBook.Text;
            modelBook.writerBookTemp = viewBook.txtWriterBook.Text;
            modelBook.quantityBookTemp = viewBook.txtQuantityBook.Text;
            modelBook.categoryBookTemp = viewBook.txtCategoryBook.Text;
            modelBook.publicationBookTemp = viewBook.txtPublicationBook.Text;
            modelBook.publisherBookTemp = viewBook.txtPublisherBook.Text;
            modelBook.editDataBook();
        }
        public void reqRemoveData()
        {
            modelBook.idBookTemp = viewBook.txtIdBook.Text;
            modelBook.nameBookTemp = viewBook.txtTitleBook.Text;
            modelBook.priceBookTemp = viewBook.txtPriceBook.Text;
            modelBook.writerBookTemp = viewBook.txtWriterBook.Text;
            modelBook.quantityBookTemp = viewBook.txtQuantityBook.Text;
            modelBook.categoryBookTemp = viewBook.txtCategoryBook.Text;
            modelBook.publicationBookTemp = viewBook.txtPublicationBook.Text;
            modelBook.publisherBookTemp = viewBook.txtPublisherBook.Text;
            modelBook.removeDataBook();
        }
        public void reqClearData()
        {
            viewBook.txtIdBook.Text = "";
            viewBook.txtTitleBook.Text = "";
            viewBook.txtPriceBook.Text = "";
            viewBook.txtWriterBook.Text = "";
            viewBook.txtQuantityBook.Text = "";
            viewBook.txtCategoryBook.Text = "";
            viewBook.txtPublicationBook.Text = "";
            viewBook.txtPublisherBook.Text = "";
        }
        public void reqSearchId()
        {
            modelBook.idBookTemp = viewBook.txtIdBook.Text;
            modelBook.searchIdBook();
            viewBook.txtIdBook.Text = modelBook.idBookTemp;
            viewBook.txtTitleBook.Text = modelBook.nameBookTemp;
            viewBook.txtPriceBook.Text = modelBook.priceBookTemp;
            viewBook.txtWriterBook.Text = modelBook.writerBookTemp;
            viewBook.txtQuantityBook.Text = modelBook.quantityBookTemp;
            viewBook.txtCategoryBook.Text = modelBook.categoryBookTemp;
            viewBook.txtPublicationBook.Text = modelBook.publicationBookTemp;
            viewBook.txtPublisherBook.Text = modelBook.publisherBookTemp;
        }
        public void reqSearchName()
        {
            modelBook.nameBookTemp = viewBook.txtTitleBook.Text;
            modelBook.searchNameBook();
            viewBook.txtIdBook.Text = modelBook.idBookTemp;
            viewBook.txtTitleBook.Text = modelBook.nameBookTemp;
            viewBook.txtPriceBook.Text = modelBook.priceBookTemp;
            viewBook.txtWriterBook.Text = modelBook.writerBookTemp;
            viewBook.txtQuantityBook.Text = modelBook.quantityBookTemp;
            viewBook.txtCategoryBook.Text = modelBook.categoryBookTemp;
            viewBook.txtPublicationBook.Text = modelBook.publicationBookTemp;
            viewBook.txtPublisherBook.Text = modelBook.publisherBookTemp;
        }
        public void reqCellBook()
        {
            modelBook.tempDataBook = viewBook.dataBook;
            modelBook.indexBook = viewBook.tempIndex;
            modelBook.cellDataBook();
            viewBook.txtIdBook.Text = modelBook.idBookTemp;
            viewBook.txtTitleBook.Text = modelBook.nameBookTemp;
            viewBook.txtPriceBook.Text = modelBook.priceBookTemp;
            viewBook.txtWriterBook.Text = modelBook.writerBookTemp;
            viewBook.txtQuantityBook.Text = modelBook.quantityBookTemp;
            viewBook.txtCategoryBook.Text = modelBook.categoryBookTemp;
            viewBook.txtPublicationBook.Text = modelBook.publicationBookTemp;
            viewBook.txtPublisherBook.Text = modelBook.publisherBookTemp;

        }
        public void reqClear()
        {
            viewBook.txtIdBook.Clear();
            viewBook.txtTitleBook.Clear();
            viewBook.txtPriceBook.Clear();
            viewBook.txtWriterBook.Clear();
            viewBook.txtQuantityBook.Clear();
            viewBook.txtCategoryBook.ResetText();
            viewBook.txtPublicationBook.Clear();
            viewBook.txtPublisherBook.ResetText();
            this.reqId();
        }
    }
}
