
namespace Virtual_Assistant
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.D_Note = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.D_Task = new System.Windows.Forms.DataGridView();
            this.Add_Note = new System.Windows.Forms.Button();
            this.Add_Task = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.control = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_Note)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_Task)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьЗаписьToolStripMenuItem,
            this.удалитьЗадачуToolStripMenuItem,
            this.удалитьВсёToolStripMenuItem,
            this.изменитьЗаметкуToolStripMenuItem,
            this.изменитьЗадачуToolStripMenuItem,
            this.экспортироватьToolStripMenuItem,
            this.импортироватьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить заметку";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаметкуToolStripMenuItem_Click);
            // 
            // удалитьЗадачуToolStripMenuItem
            // 
            this.удалитьЗадачуToolStripMenuItem.Name = "удалитьЗадачуToolStripMenuItem";
            this.удалитьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.удалитьЗадачуToolStripMenuItem.Text = "Удалить задачу";
            this.удалитьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗадачуToolStripMenuItem_Click);
            // 
            // удалитьВсёToolStripMenuItem
            // 
            this.удалитьВсёToolStripMenuItem.Name = "удалитьВсёToolStripMenuItem";
            this.удалитьВсёToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.удалитьВсёToolStripMenuItem.Text = "Удалить всё";
            this.удалитьВсёToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсёToolStripMenuItem_Click);
            // 
            // изменитьЗаметкуToolStripMenuItem
            // 
            this.изменитьЗаметкуToolStripMenuItem.Name = "изменитьЗаметкуToolStripMenuItem";
            this.изменитьЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.изменитьЗаметкуToolStripMenuItem.Text = "Изменить заметку";
            this.изменитьЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.изменитьЗаметкуToolStripMenuItem_Click);
            // 
            // изменитьЗадачуToolStripMenuItem
            // 
            this.изменитьЗадачуToolStripMenuItem.Name = "изменитьЗадачуToolStripMenuItem";
            this.изменитьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.изменитьЗадачуToolStripMenuItem.Text = "Изменить задачу";
            this.изменитьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.изменитьЗадачуToolStripMenuItem_Click);
            // 
            // экспортироватьToolStripMenuItem
            // 
            this.экспортироватьToolStripMenuItem.Name = "экспортироватьToolStripMenuItem";
            this.экспортироватьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.экспортироватьToolStripMenuItem.Text = "Экспортировать";
            this.экспортироватьToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьToolStripMenuItem_Click);
            // 
            // импортироватьToolStripMenuItem
            // 
            this.импортироватьToolStripMenuItem.Name = "импортироватьToolStripMenuItem";
            this.импортироватьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.импортироватьToolStripMenuItem.Text = "Импортировать";
            this.импортироватьToolStripMenuItem.Click += new System.EventHandler(this.импортироватьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.руководствоПользователяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(204, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 427);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.D_Note);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заметки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // D_Note
            // 
            this.D_Note.AllowUserToAddRows = false;
            this.D_Note.AllowUserToDeleteRows = false;
            this.D_Note.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D_Note.BackgroundColor = System.Drawing.SystemColors.Window;
            this.D_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D_Note.Location = new System.Drawing.Point(3, 3);
            this.D_Note.Name = "D_Note";
            this.D_Note.RowHeadersVisible = false;
            this.D_Note.Size = new System.Drawing.Size(587, 395);
            this.D_Note.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.D_Task);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // D_Task
            // 
            this.D_Task.AllowUserToAddRows = false;
            this.D_Task.AllowUserToDeleteRows = false;
            this.D_Task.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D_Task.BackgroundColor = System.Drawing.SystemColors.Window;
            this.D_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D_Task.Location = new System.Drawing.Point(3, 3);
            this.D_Task.Name = "D_Task";
            this.D_Task.RowHeadersVisible = false;
            this.D_Task.Size = new System.Drawing.Size(587, 395);
            this.D_Task.TabIndex = 0;
            // 
            // Add_Note
            // 
            this.Add_Note.BackColor = System.Drawing.Color.Beige;
            this.Add_Note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Note.Location = new System.Drawing.Point(6, 241);
            this.Add_Note.Name = "Add_Note";
            this.Add_Note.Size = new System.Drawing.Size(182, 45);
            this.Add_Note.TabIndex = 3;
            this.Add_Note.Text = "Добавить заметку";
            this.Add_Note.UseVisualStyleBackColor = false;
            this.Add_Note.Click += new System.EventHandler(this.Add_Note_Click);
            // 
            // Add_Task
            // 
            this.Add_Task.BackColor = System.Drawing.Color.Beige;
            this.Add_Task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Task.Location = new System.Drawing.Point(6, 305);
            this.Add_Task.Name = "Add_Task";
            this.Add_Task.Size = new System.Drawing.Size(182, 45);
            this.Add_Task.TabIndex = 4;
            this.Add_Task.Text = "Добавить задачу";
            this.Add_Task.UseVisualStyleBackColor = false;
            this.Add_Task.Click += new System.EventHandler(this.Add_Task_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(194, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 429);
            this.label1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.Color.Beige;
            this.control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.control.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control.Location = new System.Drawing.Point(6, 368);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(182, 49);
            this.control.TabIndex = 6;
            this.control.Text = "Включить контроль рабочего времени";
            this.control.UseVisualStyleBackColor = false;
            this.control.Click += new System.EventHandler(this.control_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Task);
            this.Controls.Add(this.Add_Note);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Virtual Assistant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.D_Note)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.D_Task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Add_Note;
        private System.Windows.Forms.Button Add_Task;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView D_Note;
        public System.Windows.Forms.DataGridView D_Task;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортироватьToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсёToolStripMenuItem;
        private System.Windows.Forms.Button control;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
    }
}

