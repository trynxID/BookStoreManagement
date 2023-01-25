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
    class ModelBook
    {
        ModelConnection db = new ModelConnection();
        public DataGridView tempDataBook;
        public ComboBox tempCbCat = new ComboBox();
        public ComboBox tempCbPub = new ComboBox();
        public object[] objCat;
        public object[] objPub;
        public string idTemp { get; set; }
        public string idBookTemp { get; set; }
        public string nameBookTemp { get; set; }
        public string priceBookTemp { get; set; }
        public string writerBookTemp { get; set; }
        public string quantityBookTemp { get; set; }
        public string categoryBookTemp { get; set; }
        public string publicationBookTemp { get; set; }
        public string publisherBookTemp { get; set; }
        public int indexBook { get; set; }
        public DataTable dataTempBook = new DataTable();
        public void updateIdBook()
        {
            long id;
            string temp;
            db.openCon();
            MySqlDataReader dr;
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select bookid from db_books where bookid in(select max(bookid) from db_books) order by bookid desc";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = Convert.ToInt64(dr[0].ToString().Substring(dr["bookid"].ToString().Length - 4, 4)) + 1;
                string idTemp = "0000" + id;
                temp = "BOK" + idTemp.Substring(idTemp.Length - 4, 4);
            }
            else
            {
                temp = "BOK0001";
            }
            dr.Close();
            idTemp = temp;
            db.closeCon();
        }
        public void loadDataCategory()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select catname From db_categories";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tempCbCat.Items.Add(dr["catname"].ToString());
            }
            objCat = new object[tempCbCat.Items.Count];
            tempCbCat.Items.CopyTo(objCat, 0);
        }
        public void loadDataPublisher()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select pubname From db_publisher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tempCbPub.Items.Add(dr["pubname"].ToString());
            }
            objPub = new object[tempCbPub.Items.Count];
            tempCbPub.Items.CopyTo(objPub, 0);
            db.closeCon();
        }
        public void updateDataBook()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From db_books";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataTempBook = dt;
            db.closeCon();
        }
        public void saveDataBook()
        {
            try
            {
                if (idBookTemp == "" || nameBookTemp == "" || priceBookTemp == "" || writerBookTemp == "" || quantityBookTemp == "" || categoryBookTemp == "" || publicationBookTemp == "" || publisherBookTemp == "")
                {
                    MessageBox.Show("Please Insert All Information ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_books (bookid,name,price,writer,quantity,category,publication_year,publisher)Values('" + idBookTemp + "','" + nameBookTemp + "','" + priceBookTemp + "','" + writerBookTemp + "','" + quantityBookTemp + "','" + categoryBookTemp + "','" + publicationBookTemp + "','" + publisherBookTemp + "')";
                    String str2 = "Select max(bookid) From db_books";
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
                        MessageBox.Show("Book has been entered", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editDataBook()
        {
            try
            {
                if (idBookTemp == "" || nameBookTemp == "" || priceBookTemp == "" || writerBookTemp == "" || quantityBookTemp == "" || categoryBookTemp == "" || publicationBookTemp == "" || publisherBookTemp == "")
                {
                    MessageBox.Show("Please Insert All Information ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Update db_books Set name = '" + nameBookTemp + "', price = '" + priceBookTemp + "', writer = '" + writerBookTemp + "', quantity = '" + quantityBookTemp + "', category = '" + categoryBookTemp + "', publication_year = '" + publicationBookTemp + "', publisher = '" + publisherBookTemp + "' Where bookid = '" + idBookTemp + "'";
                    String str2 = "Select max(bookid) From db_books";
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
                        MessageBox.Show("Book has been updated", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void removeDataBook()
        {
            try
            {
                if (idBookTemp == "" || nameBookTemp == "" || priceBookTemp == "" || writerBookTemp == "" || quantityBookTemp == "" || categoryBookTemp == "" || publicationBookTemp == "" || publisherBookTemp == "")
                {
                    MessageBox.Show("Please Insert All Information ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_books Where bookid = '" + idBookTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book has been deleted", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchIdBook()
        {
            try
            {
                db.openCon();
                String str = "Select bookid,name,price,writer,quantity,category,publication_year,publisher From db_books Where bookid = '" + idBookTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idBookTemp = dr.GetValue(0).ToString();
                    nameBookTemp = dr.GetValue(1).ToString();
                    priceBookTemp = dr.GetValue(2).ToString();
                    writerBookTemp = dr.GetValue(3).ToString();
                    quantityBookTemp = dr.GetValue(4).ToString();
                    categoryBookTemp = dr.GetValue(5).ToString();
                    publicationBookTemp = dr.GetValue(6).ToString();
                    publisherBookTemp = dr.GetValue(7).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchNameBook()
        {
            try
            {
                db.openCon();
                String str = "Select bookid,name,price,writer,quantity,category,publication_year,publisher From db_books Where name = '" + nameBookTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idBookTemp = dr.GetValue(0).ToString();
                    nameBookTemp = dr.GetValue(1).ToString();
                    priceBookTemp = dr.GetValue(2).ToString();
                    writerBookTemp = dr.GetValue(3).ToString();
                    quantityBookTemp = dr.GetValue(4).ToString();
                    categoryBookTemp = dr.GetValue(5).ToString();
                    publicationBookTemp = dr.GetValue(6).ToString();
                    publisherBookTemp = dr.GetValue(7).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cellDataBook()
        {
            try
            {
                DataGridViewRow dataTemp = tempDataBook.Rows[indexBook];
                idBookTemp = dataTemp.Cells[0].Value.ToString();
                nameBookTemp = dataTemp.Cells[1].Value.ToString();
                priceBookTemp = dataTemp.Cells[2].Value.ToString();
                writerBookTemp = dataTemp.Cells[3].Value.ToString();
                quantityBookTemp = dataTemp.Cells[4].Value.ToString();
                categoryBookTemp = dataTemp.Cells[5].Value.ToString();
                publicationBookTemp = dataTemp.Cells[6].Value.ToString();
                publisherBookTemp = dataTemp.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
