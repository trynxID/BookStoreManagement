using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace BookStoreManagement.Model
{
    class ModelConnection
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        public string data = "server=localhost;port=3306;username=root;password=;database=bookstore";
        public MySqlConnection konek()
        {
            return conn;
        }
        public ModelConnection()
        {
            conn = new MySqlConnection(data);
            konek();
        }

        public void openCon()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeCon()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataSet Select(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new MySqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                if(kondisi == null)
                {
                    command.CommandText = "select * from " + tabel;
                }
                else
                {
                    command.CommandText = "select * from " + tabel + " where " + kondisi;
                }
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.Fill(ds, tabel);

            }
            catch(MySqlException)
            {
                ds = null;
            }
            conn.Close();
            return ds;
        }
        

    }
}
