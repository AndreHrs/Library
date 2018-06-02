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
    public partial class FormManageBooks : Form
    {
        public FormManageBooks()
        {
            InitializeComponent();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain main = new formMain(Program.TipeAkun, Program.Nama, Program.PathFoto);
            main.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormAddEditBook addbook = new FormAddEditBook("Title", "Year", "Genre", "Author");
            this.Hide();
            addbook.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditBook addbook = new FormAddEditBook();
            this.Hide();
            addbook.Show();
        }
    }
}
