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
    class ModelEmployee
    {
        ModelConnection db = new ModelConnection();
        public DataGridView tempDataEmployee;
        public string idTemp { get; set; }
        public string idEmployeeTemp { get; set; }
        public string usernameEmployeeTemp { get; set; }
        public string fullnameEmployeeTemp { get; set; }
        public string passwordEmployeeTemp { get; set; }
        public string contactEmployeeTemp { get; set; }
        public string emailEmployeeTemp { get; set; }

        public int indexEmployee { get; set; }
        public DataTable dataTempEmployee = new DataTable();
        public void updateIdEmployee()
        {
            long id;
            string temp;
            db.openCon();
            MySqlDataReader dr;
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select empid from db_employee where empid in(select max(empid) from db_employee) order by empid desc";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = Convert.ToInt64(dr[0].ToString().Substring(dr["empid"].ToString().Length - 4, 4)) + 1;
                string idTemp = "0000" + id;
                temp = "EMP" + idTemp.Substring(idTemp.Length - 4, 4);
            }
            else
            {
                temp = "EMP0001";
            }
            dr.Close();
            idTemp = temp;
            db.closeCon();
        }
        public void updateDataEmployee()
        {
            db.openCon();
            MySqlCommand cmd = db.konek().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From db_employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataTempEmployee = dt;
            db.closeCon();
        }
        public void saveDataEmployee()
        {
            try
            {
                if (idEmployeeTemp == "" || usernameEmployeeTemp == "" || fullnameEmployeeTemp == "" || passwordEmployeeTemp == "" || contactEmployeeTemp == "" || emailEmployeeTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Insert Into db_employee (empid,empuname,empfname,emppassword,empcontact,empemail)Values('" + idEmployeeTemp + "','" + usernameEmployeeTemp + "','" + fullnameEmployeeTemp + "','" + passwordEmployeeTemp + "','" + contactEmployeeTemp + "','" + emailEmployeeTemp + "')";
                    String str2 = "Select max(empid) From db_employee";
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
                        MessageBox.Show("Karyawan berhasil ditambahkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editDataEmployee()
        {
            try
            {
                if (idEmployeeTemp == "" || usernameEmployeeTemp == "" || fullnameEmployeeTemp == "" || passwordEmployeeTemp == "" || contactEmployeeTemp == "" || emailEmployeeTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Update db_employee Set empuname = '" + usernameEmployeeTemp + "', empfname = '" + fullnameEmployeeTemp + "', emppassword = '" + passwordEmployeeTemp + "', empcontact = '" + contactEmployeeTemp + "', empemail = '" + emailEmployeeTemp + "' Where empid = '" + idEmployeeTemp + "'";
                    String str2 = "Select max(empid) From db_employee";
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
                        MessageBox.Show("Karyawan telah diperbaharui", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void removeDataEmployee()
        {
            try
            {
                if (idEmployeeTemp == "" || usernameEmployeeTemp == "" || fullnameEmployeeTemp == "" || passwordEmployeeTemp == "" || contactEmployeeTemp == "" || emailEmployeeTemp == "")
                {
                    MessageBox.Show("Silahkan isi data terlebih dahulu ", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    db.openCon();
                    String str = "Delete From db_employee Where empid = '" + idEmployeeTemp + "'";
                    MySqlCommand cmd = db.konek().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Karyawan telah dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchIdEmployee()
        {
            try
            {
                db.openCon();
                String str = "Select empid,empuname,empfname,emppassword,empcontact,empemail From db_employee Where empid = '" + idEmployeeTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idEmployeeTemp = dr.GetValue(0).ToString();
                    usernameEmployeeTemp = dr.GetValue(1).ToString();
                    fullnameEmployeeTemp = dr.GetValue(2).ToString();
                    passwordEmployeeTemp = dr.GetValue(3).ToString();
                    contactEmployeeTemp = dr.GetValue(4).ToString();
                    emailEmployeeTemp = dr.GetValue(5).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchNameEmployee()
        {
            try
            {
                db.openCon();
                String str = "Select empid,empuname,empfname,emppassword,empcontact,empemail From db_employee Where empuname = '" + usernameEmployeeTemp + "'";
                MySqlCommand cmd = db.konek().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idEmployeeTemp = dr.GetValue(0).ToString();
                    usernameEmployeeTemp = dr.GetValue(1).ToString();
                    fullnameEmployeeTemp = dr.GetValue(2).ToString();
                    passwordEmployeeTemp = dr.GetValue(3).ToString();
                    contactEmployeeTemp = dr.GetValue(4).ToString();
                    emailEmployeeTemp = dr.GetValue(5).ToString();
                }
                db.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cellDataEmployee()
        {
            try
            {
                DataGridViewRow dataTemp = tempDataEmployee.Rows[indexEmployee];
                idEmployeeTemp = dataTemp.Cells[0].Value.ToString();
                usernameEmployeeTemp = dataTemp.Cells[1].Value.ToString();
                fullnameEmployeeTemp = dataTemp.Cells[2].Value.ToString();
                passwordEmployeeTemp = dataTemp.Cells[3].Value.ToString();
                contactEmployeeTemp = dataTemp.Cells[4].Value.ToString();
                emailEmployeeTemp = dataTemp.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
