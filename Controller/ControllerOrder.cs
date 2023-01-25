using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerOrder
    {
        Model.ModelOrder modelOrder;
        View.ViewOrder viewOrder;

        public ControllerOrder(View.ViewOrder viewOrder)
        {
            modelOrder = new Model.ModelOrder();
            this.viewOrder = viewOrder;
        }
        public void reqDataOrder()
        {
            modelOrder.reqDataOrder();
            viewOrder.dataOrder.DataSource = modelOrder.dataTempOrder;
            viewOrder.dataOrder.AutoGenerateColumns = false;
        }
        public void resetData()
        {
            viewOrder.dataOrder.DataSource = null;
        }
    }
}
