using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BookStoreManagement.Model
{
    class ModelLogin
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool userLogin()
        {
            ModelConnection con = new ModelConnection();
            con.konek();
            con.openCon();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `db_user` WHERE `username` =@usn AND `upassword` =@pass", con.konek());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            bool result;
            if (table.Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            con.closeCon();
            return result;
        }
        public bool adminLogin()
        {
            bool result;
            if (username == "admin" && password=="admin")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
