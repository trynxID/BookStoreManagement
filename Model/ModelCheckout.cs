using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace BookStoreManagement.Model
{
    class ModelCheckout
    {
        ModelConnection db = new ModelConnection();
        public DataGridView tempDataCheckout;
        public ComboBox tempCbName = new ComboBox();
        public ComboBox tempCbTitle = new ComboBox();
        public object[] objName;
        public object[] objTitle;
        public string noTemp { get; set; }
        public string dateInvoiceTemp { get; set; }
        public string noInvoiceTemp { get; set; }
        public string idCustomerTemp { get; set; }
        public string nameCustomerTemp { get; set; }
        public string contactCustomerTemp { get; set; }
        public string addressCustomerTemp { get; set; }
        public string idBookTemp { get; set; }
        public string titleBookTemp { get; set; }
        public string priceBookTemp { get; set; }
        public string quantityBookTemp { get; set; }
        public string priceTotalTemp { get; set; }
        public string totalGrandTemp { get; set; }
        public int indexCheckout { get; set; }
        public DataTable dataTempCheckout = new DataTable();
        public void updateIdCheckout()
        {
            long id;
            string temp;
            db.openCon();
            MySqlDataReader dr;
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select invoiceid from db_checkout where invoiceid in(select max(invoiceid) from db_checkout) order by invoiceid desc";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = Convert.ToInt64(dr[0].ToString().Substring(dr["invoiceid"].ToString().Length - 4, 4)) + 1;
                string idTemp = "0000" + id;
                temp = "INV" + idTemp.Substring(idTemp.Length - 4, 4);
            }
            else
            {
                temp = "INV0001";
            }
            dr.Close();
            noTemp = temp;
            db.closeCon();
        }
        public void loadDataCusname()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select cusname From db_customers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tempCbName.Items.Add(dr["cusname"].ToString());
            }
            objName = new object[tempCbName.Items.Count];
            tempCbName.Items.CopyTo(objName, 0);
        }
        public void loadDataBooktitle()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select name From db_books";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tempCbTitle.Items.Add(dr["name"].ToString());
            }
            objTitle = new object[tempCbTitle.Items.Count];
            tempCbTitle.Items.CopyTo(objTitle, 0);
            db.closeCon();
        }
        public void updateDataCheckout()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From db_checkout where invoiceid = '" + noInvoiceTemp + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataTempCheckout = dt;
            db.closeCon();
        }
        public void addGrandTotal()
        {
            int A = 0, B = 0;
            for (A = 0; A < tempDataCheckout.Rows.Count; ++A)
            {
                B += Convert.ToInt32(tempDataCheckout.Rows[A].Cells["totalprice"].Value);
            }
            totalGrandTemp = B.ToString();
        }
        public void updateContentCustomer()
        {
            if (nameCustomerTemp == "")
            {
                contactCustomerTemp = "";
                addressCustomerTemp = "";
            }
            else
            {
                db.openCon();
                String str = "Select cusid,cusname,cuscontact,cusaddress From db_customers Where cusname = '" + nameCustomerTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idCustomerTemp = dr.GetValue(0).ToString();
                    nameCustomerTemp = dr.GetValue(1).ToString();
                    contactCustomerTemp = dr.GetValue(2).ToString();
                    addressCustomerTemp = dr.GetValue(3).ToString();
                }
                db.closeCon();
            }
        }
        public void updateContentBook()
        {
            if (nameCustomerTemp == "" || addressCustomerTemp == "" || contactCustomerTemp == "")
            {
                MessageBox.Show("Please , Enter Customer Details", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                View.ViewCheckout viewCheckout = new View.ViewCheckout();
                viewCheckout.txtNameCustomer.Focus();
            }
            else if (titleBookTemp == "")
            {
                priceBookTemp = "";
                quantityBookTemp = "";
            }
            else
            {
                db.openCon();
                String str = "Select bookid,name,price From db_books Where name = '" + titleBookTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idBookTemp = dr.GetValue(0).ToString();
                    titleBookTemp = dr.GetValue(1).ToString();
                    priceBookTemp = dr.GetValue(2).ToString();
                }
                db.closeCon();
            }
        }
        public void updateContentQuantity()
        {
            try
            {
                if (quantityBookTemp == "")
                {
                    priceTotalTemp = "";
                }
                else if (titleBookTemp == "")
                {
                    MessageBox.Show("Please , Enter Product Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtTitleBook.Focus();
                }
                else
                {
                    double totalprice;
                    totalprice = double.Parse(priceBookTemp) * double.Parse(quantityBookTemp);
                    priceTotalTemp = totalprice.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addDataCheckout()
        {
            try
            {
                if (noInvoiceTemp == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNoInvoice.Focus();

                }
                else if (nameCustomerTemp == "") {
                    MessageBox.Show("Please , Enter Name Customer", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNameCustomer.Focus();
                }
                else if (titleBookTemp == "")
                {
                    MessageBox.Show("Please , Enter Title Book ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtTitleBook.Focus();

                }
                else if (quantityBookTemp == "")
                {
                    MessageBox.Show("Please , Enter Quantity", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtQuantityBook.Focus();
                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_checkout (invoiceid,cusid,bookid,name,quantity,price,totalprice)Values('" + noInvoiceTemp + "','" + idCustomerTemp + "','" + idBookTemp + "','" + titleBookTemp + "','" + quantityBookTemp + "','" + priceBookTemp + "','" + priceTotalTemp + "')";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    String str2 = "Select max(invoiceid) From db_checkout";
                    MySqlCommand cmd2 = db.konek().CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = str2;
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Order has been add to cart", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.closeCon();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteDataCheckout()
        {
            try
            {
                if (titleBookTemp == "")
                {
                    MessageBox.Show("Please , Enter Product Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtTitleBook.Focus();

                }
                else if (priceBookTemp == "")
                {
                    MessageBox.Show("Please , Enter Product Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtPriceBook.Focus();

                }
                else if (quantityBookTemp == "")
                {
                    MessageBox.Show("Please , Enter Product Quantity", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtQuantityBook.Focus();
                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_checkout Where name = '" + titleBookTemp + "' and invoiceid = '" + noInvoiceTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order has been deleted from cart", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void saveDataCheckout()
        {
            try
            {
                if (noInvoiceTemp== "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNoInvoice.Focus();

                }
                else if (nameCustomerTemp == "")
                {
                    MessageBox.Show("Please , Enter Name Customer", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNameCustomer.Focus();
                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_orders (invoicedate,invoiceid,cusid,cusname,cuscontact,cusaddress,grandtotal)Values('" + dateInvoiceTemp + "','" + noInvoiceTemp + "','" + idCustomerTemp + "','" + nameCustomerTemp + "','" + contactCustomerTemp + "','" + addressCustomerTemp + "','" + totalGrandTemp + "')";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    String str2 = "Select max(invoiceid) From db_orders";
                    MySqlCommand cmd2 = db.konek().CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = str2;
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Invoice Saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editDataCheckout()
        {
            try
            {
                if (noInvoiceTemp == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNoInvoice.Focus();

                }
                else if (nameCustomerTemp == "")
                {
                    MessageBox.Show("Please , Enter Customer Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNameCustomer.Focus();
                }
                else
                {
                    db.openCon();
                    String str = "Update db_orders Set invoicedate = '" + dateInvoiceTemp + "',cusname = '" + nameCustomerTemp + "',cuscontact = '" + contactCustomerTemp + "',cusaddress = '" + addressCustomerTemp + "',grandtotal = '" + totalGrandTemp + "' Where invoiceid = '" + noInvoiceTemp + "' and cusid = '" + idCustomerTemp + "' ";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    String str2 = "Select max(invoiceid) From db_orders";
                    MySqlCommand cmd2 = db.konek().CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = str2;
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Invoice Updated", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void removeDataCheckout()
        {
            try
            {
                if (noInvoiceTemp == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNoInvoice.Focus();

                }
                else
                    if (nameCustomerTemp == "")
                {
                    MessageBox.Show("Please , Enter Name Customer", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNameCustomer.Focus();
                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_orders Where invoiceid = '" + noInvoiceTemp + "' ";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    String str2 = "Select max(invoiceid) From db_orders";
                    MySqlCommand cmd2 = db.konek().CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = str2;
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Invoice Deleted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchDataCheckout()
        {
            try
            {
                if (noInvoiceTemp == "")
                {
                    MessageBox.Show("Please , Enter Invoice No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    View.ViewCheckout viewCheckout = new View.ViewCheckout();
                    viewCheckout.txtNoInvoice.Focus();

                }
                else
                {
                    db.openCon();
                    String str = "Select invoicedate,cusid,cusname,cuscontact,cusaddress,grandtotal From db_orders Where invoiceid = '" + noInvoiceTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dateInvoiceTemp = dr.GetValue(0).ToString();
                        idCustomerTemp = dr.GetValue(1).ToString();
                        nameCustomerTemp = dr.GetValue(2).ToString();
                        contactCustomerTemp = dr.GetValue(3).ToString();
                        addressCustomerTemp = dr.GetValue(4).ToString();
                        totalGrandTemp = dr.GetValue(5).ToString();
                    }
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cellDataCheckout()
        {
            try
            {
                DataGridViewRow dataTemp = tempDataCheckout.Rows[indexCheckout];
                titleBookTemp = dataTemp.Cells[3].Value.ToString();
                priceBookTemp = dataTemp.Cells[4].Value.ToString();
                quantityBookTemp = dataTemp.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
