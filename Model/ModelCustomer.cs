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
    class ModelCustomer
    {
        ModelConnection db = new ModelConnection();
        public DataGridView tempDataCustomer;
        public string idTemp { get; set; }
        public string idCustomerTemp { get; set; }
        public string nameCustomerTemp { get; set; }
        public string contactCustomerTemp { get; set; }
        public string addressCustomerTemp { get; set; }

        public int indexCustomer { get; set; }
        public DataTable dataTempCustomer = new DataTable();
        public void updateIdCustomer()
        {
            long id;
            string temp;
            db.openCon();
            MySqlDataReader dr;
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cusid from db_customers where cusid in(select max(cusid) from db_customers) order by cusid desc";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = Convert.ToInt64(dr[0].ToString().Substring(dr["cusid"].ToString().Length - 4, 4)) + 1;
                string idTemp = "0000" + id;
                temp = "CUS" + idTemp.Substring(idTemp.Length - 4, 4);
            }
            else
            {
                temp = "CUS0001";
            }
            dr.Close();
            idTemp = temp;
            db.closeCon();
        }
        public void updateDataCustomer()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From db_customers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataTempCustomer = dt;
            db.closeCon();
        }
        public void saveDataCustomer()
        {
            try
            {
                if (idCustomerTemp == "" || nameCustomerTemp == "" || contactCustomerTemp == "" || addressCustomerTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_customers (cusid,cusname,cuscontact,cusaddress)Values('" + idCustomerTemp + "','" + nameCustomerTemp + "','" + contactCustomerTemp + "','" + addressCustomerTemp + "')";
                    String str2 = "Select max(cusid) From db_customers";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd2 = db.konek().CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = str2;
                    cmd2.ExecuteNonQuery();
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Customer berhasil ditambahkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editDataCustomer()
        {
            try
            {
                if (idCustomerTemp == "" || nameCustomerTemp == "" || contactCustomerTemp == "" || addressCustomerTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Update db_customers Set cusname = '" + nameCustomerTemp + "', cuscontact = '" + contactCustomerTemp + "', cusaddress = '" + addressCustomerTemp + "' Where cusid = '" + idCustomerTemp + "'";
                    String str2 = "Select max(cusid) From db_customers";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd2 = db.konek().CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = str2;
                    cmd2.ExecuteNonQuery();
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Customer telah diperbaharui", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void removeDataCustomer()
        {
            try
            {
                if (idCustomerTemp == "" || nameCustomerTemp == "" || contactCustomerTemp == "" || addressCustomerTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_customers Where cusid = '" + idCustomerTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer telah dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchIdCustomer()
        {
            try
            {
                db.openCon();
                String str = "Select cusid,cusname,cuscontact,cusaddress From db_customers Where cusid = '" + idCustomerTemp + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchNameCustomer()
        {
            try
            {
                db.openCon();
                String str = "Select cusid,cusname From db_customers Where cusname = '" + nameCustomerTemp + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cellDataCustomer()
        {
            try
            {
                DataGridViewRow dataTemp = tempDataCustomer.Rows[indexCustomer];
                idCustomerTemp = dataTemp.Cells[0].Value.ToString();
                nameCustomerTemp = dataTemp.Cells[1].Value.ToString();
                contactCustomerTemp = dataTemp.Cells[2].Value.ToString();
                addressCustomerTemp = dataTemp.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
