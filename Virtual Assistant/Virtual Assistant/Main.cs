using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using Tulpep.NotificationWindow;
using System.Runtime.InteropServices;

namespace Virtual_Assistant
{
    public partial class Main : Form
    {
        public int Ex { get; set; } //определение какая страница tabcontrol открыта

        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DBWorker.OpenConnection();
            DBWorker.ShowNote(this);
            DBWorker.ShowTask(this);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBWorker.CloseConnection();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            About about = new About();
            about.ShowDialog();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowDialogNote() //выводит на экран форму Note
        {
            Note note = new Note(this);
            note.ShowDialog();
        }

        public void ShowDialogTask() //выводит на экран форму Task
        {
            Task task = new Task(this);
            task.ShowDialog();
        }

        private void Add_Note_Click(object sender, EventArgs e)
        {
            ShowDialogNote();
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            ShowDialogTask();
        }

        private void удалитьЗаметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (D_Note.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить эту запись? ", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(D_Note.CurrentRow.Cells[3].Value);
                    DBWorker.ExecuteQuery(@"DELETE FROM [Note] WHERE Id =" + id);
                    MessageBox.Show("Запись была успешно удалена из базы данных", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBWorker.ShowNote(this);
                }
            }
        }

        private void удалитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (D_Task.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить эту запись? ", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(D_Task.CurrentRow.Cells[7].Value);
                    DBWorker.ExecuteQuery(@"DELETE FROM [Task] WHERE Id =" + id);
                    MessageBox.Show("Запись была успешно удалена из базы данных", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBWorker.ShowTask(this);
                }
            }
        }

        public void изменитьЗаметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (D_Note.SelectedCells.Count > 0)
            {
                Note note = new Note(this);

                note.Txt = D_Note.CurrentRow.Cells[0].Value.ToString();
                note.Txt2 = D_Note.CurrentRow.Cells[1].Value.ToString();

                note.ShowDialog();
            }
        }

        private void изменитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (D_Task.SelectedCells.Count > 0)
            {
                Task task = new Task(this);

                task.headT = D_Task.CurrentRow.Cells[0].Value.ToString();
                task.execT = D_Task.CurrentRow.Cells[1].Value.ToString();
                task.textT = D_Task.CurrentRow.Cells[2].Value.ToString();
                task.date = Convert.ToDateTime(D_Task.CurrentRow.Cells[3].Value);
                task.time = DateTime.Parse(D_Task.CurrentRow.Cells[4].Value.ToString()).ToString("t");
                task.check2 = Convert.ToBoolean(D_Task.CurrentRow.Cells[5].Value);
                task.check1 = Convert.ToBoolean(D_Task.CurrentRow.Cells[6].Value);
               
                task.ShowDialog();
            }
        }

        public void Export(DataGridView grid)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();

            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= grid.RowCount - 1; i++)
            {
                for (j = 0; j < grid.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = grid.Columns[j].HeaderText.ToString();

                    if (j == 4)
                    {
                        DateTime dateTime = (DateTime)grid[j, i].Value;
                        wsh.Cells[i + 2, j + 1] = dateTime.ToString("HH:mm");
                    }
                    else
                    {
                        wsh.Cells[i + 2, j + 1] = grid[j, i].Value.ToString();
                    }
                }
            }
            exApp.Visible = true;
        }

        private void экспортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ex == 0)
            {
                Export(D_Note);
            }
            else
            {
                Export(D_Task);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ex = tabControl1.SelectedIndex;
        }

        private void импортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файл Excel|*.XLSX;*.XLS";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openDialog.FileName;

                String strConnection = DBWorker.connectionStrings;

                String excelConnString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0\"", filePath);
                //Create Connection to Excel work book 
                using (OleDbConnection excelConnection = new OleDbConnection(excelConnString))
                {
                    try
                    {
                        //Create OleDbCommand to fetch data from Excel 
                        using (OleDbCommand cmd = new OleDbCommand("Select * from [Лист1$]", excelConnection))
                        {
                            excelConnection.Open();

                            using (OleDbDataReader dReader = cmd.ExecuteReader())
                            {
                                using (SqlBulkCopy sqlBulk = new SqlBulkCopy(strConnection))
                                {

                                    //Give your Destination table name 
                                    if (Ex == 0)
                                    {
                                        sqlBulk.DestinationTableName = "Note";
                                        sqlBulk.WriteToServer(dReader);
                                        MessageBox.Show("Импорт завершен");
                                        DBWorker.ShowNote(this);
                                    }
                                    else
                                    {
                                        sqlBulk.DestinationTableName = "Task";
                                        sqlBulk.WriteToServer(dReader);
                                        MessageBox.Show("Импорт завершен");
                                        DBWorker.ShowTask(this);
                                    }
                                }


                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Проверьте, что загружаете корректную таблицу." + "\n" +
                            "Узнать как правильно сформировать таблицу можно в Руководстве пользователя.", "Ошибка загрузки");
                    }

                }
            }
        }
                

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = -1;
            string timeNow = DateTime.Now.Date.ToString();
            string curTimeShort = DateTime.Now.ToString("HH:mm");

            foreach (DataGridViewRow row in D_Task.Rows)
            {
                i += 1;
                if (Convert.ToDateTime(timeNow) == Convert.ToDateTime(row.Cells[3].Value))
                {
                    if (D_Task.Rows[i].Cells[6].Value.ToString() == "True" && D_Task.Rows[i].Cells[5].Value.ToString() == "False")
                    {
                        string format = DateTime.Parse(row.Cells[4].Value.ToString()).ToString("t");
                        if (Convert.ToString(curTimeShort) == format)
                        {
                            D_Task.Rows[i].Cells[6].Value = "False";
                            int id = Convert.ToInt32(D_Task.Rows[i].Cells[7].Value);
                            DBWorker.ExecuteQuery(@"UPDATE [Task] SET Уведомить=N'" + D_Task.Rows[i].Cells[6].Value + "' WHERE Id =" + id);

                            MessageBox.Show(D_Task.Rows[i].Cells[0].Value.ToString() + "\n" + "Исполнитель:" +
                                D_Task.Rows[i].Cells[1].Value.ToString() + "\n" + D_Task.Rows[i].Cells[2].Value.ToString(), "Не забудьте!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                          
                        }
                    }
                }
            }
        }

        private void удалитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ex == 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить все заметки? ", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBWorker.ExecuteQuery(@"DELETE FROM [Note]");
                    MessageBox.Show("Все записи успешно удалены из базы данных", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBWorker.ShowNote(this);
                }       
            }
            else
            { 
                if (MessageBox.Show("Вы точно хотите удалить все задачи? ", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBWorker.ExecuteQuery(@"DELETE FROM [Task]");
                    MessageBox.Show("Все записи успешно удалены из базы данных", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBWorker.ShowTask(this);
                }
            }
        }

        private void Popup1()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.i;
            popup.ImageSize = new Size(100,100);
            popup.HeaderColor = Color.DodgerBlue;
            popup.Delay = 15000;
            popup.TitleText = "Пора отдохнуть!";
            popup.TitleColor = Color.Red;
            popup.ContentText = "Вы уже 50 минут работаете. Сделайте перерыв 10 минут, чтобы глаза отдохнули.";
            popup.BodyColor = Color.FloralWhite;
            popup.Size = new Size(500, 120);
            popup.ContentFont = new Font("times new roman", 12);
            popup.TitleFont = new Font("times new roman", 15, FontStyle.Bold);
            popup.Popup();
        }
        
        private void control_Click(object sender, EventArgs e)
        {
            if (control.Text == "Включить контроль рабочего времени")
            {
                control.Text = "Выключить контроль рабочего времени";
                timer2.Start();
            }
            else
            {
                control.Text = "Включить контроль рабочего времени";
                timer2.Stop();
            }
        }

        static int _x, _y, lastX = 0, lastY = 0;
        public struct POINT
        {
            public int X;
            public int Y;
        }

        int work = 0;
        int no_work = 0;


        private void timer2_Tick(object sender, EventArgs e)
        {
            POINT point;
            if (GetCursorPos(out point) && point.X != _x && point.Y != _y)
            {
                _x = point.X;
                _y = point.Y;
            }
            if (lastX == point.X && lastY == point.Y)
            {
                no_work++;
                
                if (no_work > 10) work = 0; //если пропущено более 10 минут, обнуляем основной счетчик
            }
            else
            {
                work++; //основной счетчик считает минуты работы

                no_work = 0;
            }

            if (work > 50)
            {
                Popup1();
                work = 0;
            }
            lastX = point.X;
            lastY = point.Y;
        }


        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

    }
}
