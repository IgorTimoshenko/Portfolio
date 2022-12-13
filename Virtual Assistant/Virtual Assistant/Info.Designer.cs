
namespace Virtual_Assistant
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_Info = new System.Windows.Forms.Button();
            this.Info_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Добавление записи",
            "Изменение записи",
            "Удаление записи",
            "Экспорт",
            "Импорт",
            "Контроль рабочего времени"});
            this.listBox1.Location = new System.Drawing.Point(15, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 132);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Чтобы узнать, как воспользоваться той или иной функцией программы, \r\nвыберите инт" +
    "ересующую вас функцию.";
            // 
            // Close_Info
            // 
            this.Close_Info.BackColor = System.Drawing.Color.Beige;
            this.Close_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Info.Location = new System.Drawing.Point(389, 282);
            this.Close_Info.Name = "Close_Info";
            this.Close_Info.Size = new System.Drawing.Size(105, 45);
            this.Close_Info.TabIndex = 4;
            this.Close_Info.Text = "Закрыть";
            this.Close_Info.UseVisualStyleBackColor = false;
            this.Close_Info.Click += new System.EventHandler(this.Close_Info_Click);
            // 
            // Info_text
            // 
            this.Info_text.BackColor = System.Drawing.Color.White;
            this.Info_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_text.Location = new System.Drawing.Point(245, 59);
            this.Info_text.Multiline = true;
            this.Info_text.Name = "Info_text";
            this.Info_text.ReadOnly = true;
            this.Info_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Info_text.Size = new System.Drawing.Size(249, 203);
            this.Info_text.TabIndex = 5;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(516, 339);
            this.Controls.Add(this.Info_text);
            this.Controls.Add(this.Close_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_Info;
        private System.Windows.Forms.TextBox Info_text;
    }
}