using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerDashboard
    {
        Model.ModelDashboard modelDashboard;
        View.ViewDashboard viewDashboard;

        public ControllerDashboard(View.ViewDashboard viewDashboard)
        {
            modelDashboard = new Model.ModelDashboard();
            this.viewDashboard = viewDashboard;
        }
        public void reqIncome()
        {
            modelDashboard.incomeTotal();
            viewDashboard.lblTotalIncome.Text = modelDashboard.incomeTemp;
        }
        public void reqOrder()
        {
            modelDashboard.orderCount();
            viewDashboard.lblTotalOrder.Text = modelDashboard.orderTemp;
        }
        public void reqBook()
        {
            modelDashboard.bookCount();
            viewDashboard.lblTotalBook.Text = modelDashboard.bookTemp;
        }
        public void reqCustomer()
        {
            modelDashboard.customerCount();
            viewDashboard.lblTotalCustomer.Text = modelDashboard.customerTemp;
        }
        public void reqEmployee()
        {
            modelDashboard.employeeCount();
            viewDashboard.lblTotalEmployee.Text = modelDashboard.employeeTemp;
        }
    }
}
