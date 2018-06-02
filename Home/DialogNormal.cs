﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class DialogNormal : Form
    {
        public DialogNormal()
        {
            InitializeComponent();
        }

        public DialogNormal(string title, string text, int x, int y)
        {
            InitializeComponent();
            lblNotice.Text = title;
            lblText.Location = new Point(x, y);
            lblText.Text = text;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
