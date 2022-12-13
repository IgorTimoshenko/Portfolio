using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Virtual_Assistant
{
    public partial class Note : Form
    {
        private readonly Main mainForm;

        DateTime DateNow = DateTime.Now;

        string format = "yyyy-MM-dd HH:mm";

        public Note(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        public string Txt
        {
            get { return heading_note.Text; }
            set { heading_note.Text = value; }
        }

        public string Txt2
        {
            get { return Text_Note.Text; }
            set { Text_Note.Text = value; }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DBWorker.ExecuteQuery($"INSERT INTO [Note] (Заголовок, Текст, Дата) VALUES (N'" + heading_note.Text + "',N'" + 
                Text_Note.Text + "','" + DateNow.ToString(format) + "')" );
            DBWorker.ShowNote(mainForm);
            Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainForm.D_Note.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(mainForm.D_Note.CurrentRow.Cells[3].Value);
                DBWorker.ExecuteQuery(@"UPDATE [Note] SET Заголовок=N'" + heading_note.Text + "', Текст=N'" + Text_Note.Text 
                    + "', Дата='" + DateNow.ToString(format) + "' WHERE Id =" + id);
                DBWorker.ShowNote(mainForm);
                Close();
            }
        }
    }
}
