using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BookStoreManagement.Model
{
    class ModelCategory
    {
        ModelConnection db = new ModelConnection();
        public DataGridView tempDataCategory;
        public string idTemp { get; set; }
        public string idCategoryTemp { get; set; }
        public string nameCategoryTemp { get; set; }
        public int indexCategory { get; set; }
        public DataTable dataTempCategory = new DataTable();
        public void updateIdCategory()
        {
            int id;
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
                id = Convert.ToInt32(dr[0]) + 1;
                temp = "" + id;
            }
            else
            {
                temp = "1";
            }
            dr.Close();
            idTemp = temp;
            db.closeCon();
        }
        public void updateDataCategory()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From db_categories";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataTempCategory = dt;
            db.closeCon();
        }
        public void saveDataCategory()
        {
            try
            {
                if (idCategoryTemp == "" || nameCategoryTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_categories (catid,catname)Values('" + idCategoryTemp + "','" + nameCategoryTemp + "')";
                    String str2 = "Select max(catid) From db_categories";
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
                        MessageBox.Show("Kategori berhasil dibuat", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editDataCategory()
        {
            try
            {
                if (idCategoryTemp == "" || nameCategoryTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Update db_categories Set catname = '" + idCategoryTemp + "' Where catid = '" + nameCategoryTemp + "'";
                    String str2 = "Select max(catid) From db_categories";
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
                        MessageBox.Show("Kategori telah diperbaharui", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void removeDataCategory()
        {
            try
            {
                if (idCategoryTemp == "" || nameCategoryTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_categories Where catid = '" + idCategoryTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori telah dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchIdCategory()
        {
            try
            {
                db.openCon();
                String str = "Select catid,catname From db_categories Where catid = '" + idCategoryTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idCategoryTemp = dr.GetValue(0).ToString();
                    nameCategoryTemp = dr.GetValue(1).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchNameCategory()
        {
            try
            {
                db.openCon();
                String str = "Select catid,catname From db_categories Where catname = '" + nameCategoryTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idCategoryTemp = dr.GetValue(0).ToString();
                    nameCategoryTemp = dr.GetValue(1).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cellDataCategory()
        {
            try
            {
                DataGridViewRow dataTemp = tempDataCategory.Rows[indexCategory];
                idCategoryTemp = dataTemp.Cells[0].Value.ToString();
                nameCategoryTemp = dataTemp.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
