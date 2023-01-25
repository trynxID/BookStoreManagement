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
    class ModelPublisher
    {
        ModelConnection db = new ModelConnection();
        public DataGridView tempDataPublisher;
        public string idTemp { get; set; }
        public string idPublisherTemp { get; set; }
        public string namePublisherTemp { get; set; }
        public int indexPublisher { get; set; }
        public DataTable dataTempPublisher = new DataTable();
        public void updateIdPublisher()
        {
            long id;
            string temp;
            db.openCon();
            MySqlDataReader dr;
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select pubid from db_publisher where pubid in(select max(pubid) from db_publisher) order by pubid desc";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = Convert.ToInt64(dr[0].ToString().Substring(dr["pubid"].ToString().Length - 4, 4)) + 1;
                string idTemp = "0000" + id;
                temp = "PUB" + idTemp.Substring(idTemp.Length - 4, 4);
            }
            else
            {
                temp = "PUB0001";
            }
            dr.Close();
            idTemp = temp;
            db.closeCon();
        }
        public void updateDataPublisher()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From db_publisher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataTempPublisher = dt;
            db.closeCon();
        }
        public void saveDataPublisher()
        {
            try
            {
                if (idPublisherTemp == "" || namePublisherTemp == "")
                {
                    MessageBox.Show("Please Insert All Information ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_publisher (pubid,pubname)Values('" + idPublisherTemp + "','" + namePublisherTemp + "')";
                    String str2 = "Select max(pubid) From db_publisher";
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
                        MessageBox.Show("Publisher has been entered", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editDataPublisher()
        {
            try
            {
                if (idPublisherTemp == "" || namePublisherTemp == "")
                {
                    MessageBox.Show("Please Insert All Information ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Update db_publisher Set pubname = '" + namePublisherTemp + "' Where pubid = '" + idPublisherTemp + "'";
                    String str2 = "Select max(pubid) From db_publisher";
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
                        MessageBox.Show("Publisher has been updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void removeDataPublisher()
        {
            try
            {
                if (idPublisherTemp == "" || namePublisherTemp == "")
                {
                    MessageBox.Show("Please Insert All Information ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_publisher Where pubid = '" + idPublisherTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Publisher has been deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchIdPublisher()
        {
            try
            {
                db.openCon();
                String str = "Select pubid,pubname From db_publisher Where pubid = '" + idPublisherTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idPublisherTemp = dr.GetValue(0).ToString();
                    namePublisherTemp = dr.GetValue(1).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchNamePublisher()
        {
            try
            {
                db.openCon();
                String str = "Select pubid,pubname From db_publisher Where pubname = '" + namePublisherTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idPublisherTemp = dr.GetValue(0).ToString();
                    namePublisherTemp = dr.GetValue(1).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cellDataPublisher()
        {
            try
            {
                DataGridViewRow dataTemp = tempDataPublisher.Rows[indexPublisher];
                idPublisherTemp = dataTemp.Cells[0].Value.ToString();
                namePublisherTemp = dataTemp.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
