using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagement.Model
{
    class ModelDashboard
    {
        ModelConnection db = new ModelConnection();
        public string incomeTemp { get; set; }
        public string orderTemp { get; set; }
        public string customerTemp { get; set; }
        public string bookTemp { get; set; }
        public string employeeTemp { get; set; }
        public void incomeTotal()
        {
            try
            {
                db.openCon();
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select sum(grandtotal) From db_orders";
                incomeTemp = Convert.ToString(cmd.ExecuteScalar());
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        public void orderCount()
        {
            try
            {
                db.openCon();
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Count(invoiceid)From db_orders";
                orderTemp = Convert.ToString(cmd.ExecuteScalar());
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void customerCount()
        {
            try
            {
                db.openCon();
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Count(cusid)From db_customers";
                customerTemp = Convert.ToString(cmd.ExecuteScalar());
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void bookCount()
        {
            try
            {
                db.openCon();
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Count(bookid)From db_books";
                bookTemp = Convert.ToString(cmd.ExecuteScalar());
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void employeeCount()
        {
            try
            {
                db.openCon();
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Count(empid)From db_employee";
                employeeTemp = Convert.ToString(cmd.ExecuteScalar());
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
