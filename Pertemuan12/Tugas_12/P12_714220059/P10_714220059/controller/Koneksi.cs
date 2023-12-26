using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace P10_714220059
{
    internal class Koneksi
    {
        private string connectionString = "Server=localhost;Database=ulbi;Uid=root;Pwd=";
        private MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionString);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public Object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet data = new DataSet();


            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }
        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

    }
}
