﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Assistant
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
