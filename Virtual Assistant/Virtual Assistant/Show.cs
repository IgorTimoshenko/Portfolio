using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Virtual_Assistant
{
    class Show
    {
       // public SqlConnection sqlConnection;
       // public string connectionStirng = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Diplom\Virtual Assistant\Virtual Assistant\DB.mdf;Integrated Security=True";


      /*  public void ShowNote(Main m)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM Note", m.sqlConnection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            m.D_Note.DataSource = dataset.Tables[0];
            m.D_Note.Columns[3].Visible = false;
        }

        public void ShowTask(Main m)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM Task", m.sqlConnection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            m.D_Task.DataSource = dataset.Tables[0];
            m.D_Task.Columns[0].Visible = false;
        }*/
    }
}
