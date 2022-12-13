using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Assistant
{
    static class DBWorker
    {
        public static string connectionStrings; //в этом поле хранится строка подключения к БД

        static SqlConnection sqlConnection; //ссылка на объект SqlConnection

        static SqlDataAdapter adapter;

        static DataSet dataset;


        public static void OpenConnection() //метод, устанавливающий соединение с БД
        {
            connectionStrings = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Virtual Assistant\\Virtual Assistant\\DB.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionStrings);
            sqlConnection.Open();
        }

        public static void ExecuteQuery(string query) // метод для команд INSERT, UPDATE, DELETE
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
        }

        public static void CloseConnection() //метод, закрывающий соединение с БД
        {
            sqlConnection.Close();
        }

        public static void Execute(string query) // метод для команды SELECT
        {
            adapter = new SqlDataAdapter(query, sqlConnection);
            dataset = new DataSet();
            adapter.Fill(dataset);
        }

        public static void ShowNote(Main m)
        {
            Execute(@"SELECT * FROM Note");
            m.D_Note.DataSource = dataset.Tables[0];
            m.D_Note.Columns[3].Visible = false;
        }

        public static void ShowTask(Main m)
        {
            Execute(@"SELECT * FROM Task ");
            m.D_Task.DataSource = dataset.Tables[0];
            m.D_Task.Columns[4].DefaultCellStyle.Format = "HH:mm";
            m.D_Task.Columns[7].Visible = false;
        }
    }
}
