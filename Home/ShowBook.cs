using System;
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
    public partial class ShowBookForm : Form
    {
        public ShowBookForm()
        {
            InitializeComponent();
        }

        public ShowBookForm(String Title, String Author, List<String> listPathPhoto)
        {
            txtAuthor.Text = Author;
            txtTitle.Text = Title;
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
            FormBookList booklist = new FormBookList();
            booklist.Show();
        }
    }
}
