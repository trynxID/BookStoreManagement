using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerPublisher
    {
        Model.ModelPublisher modelPublisher;
        View.ViewPublisher viewPublisher;

        public ControllerPublisher(View.ViewPublisher viewPublisher)
        {
            modelPublisher = new Model.ModelPublisher();
            this.viewPublisher = viewPublisher;
        }
        public void reqId()
        {
            modelPublisher.updateIdPublisher();
            viewPublisher.txtIdPublisher.Text = modelPublisher.idTemp;
        }
        public void reqData()
        {
            modelPublisher.updateDataPublisher();
            viewPublisher.dataPublisher.AutoGenerateColumns = false;
            viewPublisher.dataPublisher.DataSource = modelPublisher.dataTempPublisher;
        }
        public void reqSaveData()
        {
            modelPublisher.idPublisherTemp = viewPublisher.txtIdPublisher.Text;
            modelPublisher.namePublisherTemp = viewPublisher.txtNamePublisher.Text;
            modelPublisher.saveDataPublisher();
        }
        public void reqUpdateData()
        {
            modelPublisher.idPublisherTemp = viewPublisher.txtIdPublisher.Text;
            modelPublisher.namePublisherTemp = viewPublisher.txtNamePublisher.Text;
            modelPublisher.editDataPublisher();
        }
        public void reqRemoveData()
        {
            modelPublisher.idPublisherTemp = viewPublisher.txtIdPublisher.Text;
            modelPublisher.namePublisherTemp = viewPublisher.txtNamePublisher.Text;
            modelPublisher.removeDataPublisher();
        }
        public void reqClearData()
        {
            viewPublisher.txtIdPublisher.Text = "";
            viewPublisher.txtNamePublisher.Text = "";
        }
        public void reqSearchId()
        {
            modelPublisher.idPublisherTemp = viewPublisher.txtIdPublisher.Text;
            modelPublisher.searchIdPublisher();
            viewPublisher.txtIdPublisher.Text = modelPublisher.idPublisherTemp;
            viewPublisher.txtNamePublisher.Text = modelPublisher.namePublisherTemp;
        }
        public void reqSearchName()
        {
            modelPublisher.namePublisherTemp = viewPublisher.txtNamePublisher.Text;
            modelPublisher.searchNamePublisher();
            viewPublisher.txtIdPublisher.Text = modelPublisher.idPublisherTemp;
            viewPublisher.txtNamePublisher.Text = modelPublisher.namePublisherTemp;
        }
        public void reqCellPublisher()
        {
            modelPublisher.tempDataPublisher = viewPublisher.dataPublisher;
            modelPublisher.indexPublisher = viewPublisher.tempIndex;
            modelPublisher.cellDataPublisher();
            viewPublisher.txtIdPublisher.Text = modelPublisher.idPublisherTemp;
            viewPublisher.txtNamePublisher.Text = modelPublisher.namePublisherTemp;

        }
        public void reqClear()
        {
            viewPublisher.txtIdPublisher.Clear();
            viewPublisher.txtNamePublisher.Clear();
            this.reqId();
        }
    }
}
