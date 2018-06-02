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
    public partial class FormAddEditBook : Form
    {
        public FormAddEditBook()
        {
            InitializeComponent();
            lblWelcome.Text = "Add Book";
        }

        public FormAddEditBook(string isititle, string Year, string Genre, string Author) //Overload Constructor utk Edit
        {
            InitializeComponent();
            txtTitle.Text = isititle;
            txtAuthor.Text = Author;
            txtGenre.Text = Genre;
            txtYear.Text = Year;
            lblWelcome.Text = "Edit Book";
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

        private void FormAddEditBook_Load(object sender, EventArgs e)
        {

        }
    }
}
