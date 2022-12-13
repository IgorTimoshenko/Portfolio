using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Assistant
{
    public partial class Task : Form
    {
        private readonly Main mainForm;

        

        public Task(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        public string headT
        {
            get { return heading_task.Text; }
            set { heading_task.Text = value; }
        }

        public string execT
        {
            get { return executor.Text; }
            set { executor.Text = value; }
        }

        public string textT
        {
            get { return Text_Task.Text; }
            set { Text_Task.Text = value; }
        }

        public DateTime date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public string time
        {
            get { return T_Time.Text; }
            set { T_Time.Text = value; }
        }

        public bool check1
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

        public bool check2
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked == true)
            {
                L_Time.Visible = true;
                T_Time.Visible = true;
            }
        }

       private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBWorker.ExecuteQuery($"INSERT INTO [Task] (Заголовок, Исполнитель, Текст, Дата, Время, Выполнено, Уведомить) VALUES (N'" + heading_task.Text + "',N'" +
                executor.Text + "',N'" + Text_Task.Text + "',N'" + dateTimePicker1.Text + "',N'" +
                T_Time.Text + "','" + checkBox2.Checked + "','" + checkBox1.Checked + "')");
            DBWorker.ShowTask(mainForm);
            Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainForm.D_Task.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(mainForm.D_Task.CurrentRow.Cells[7].Value);
                DBWorker.ExecuteQuery(@"UPDATE [Task] SET Заголовок=N'" + heading_task.Text + "', Исполнитель=N'" + executor.Text + "', Текст =N'" + Text_Task.Text
                    + "', Дата='" + dateTimePicker1.Text + "', Время=N'" + T_Time.Text + "', Выполнено=N'" + checkBox2.Checked + 
                    "', Уведомить=N'" + checkBox1.Checked + "' WHERE Id =" + id);
                DBWorker.ShowTask(mainForm);
                Close();
            }
        }
    }
}
