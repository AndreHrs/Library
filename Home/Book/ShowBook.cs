using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home
{
    public partial class ShowBookForm : Form
    {
        string[] listGambar;
        int indeks;
        ControlForm kontrol = new ControlForm();
        Utility utilitas = new Utility();
        public ShowBookForm()
        {
            InitializeComponent();
        }
        
        public ShowBookForm(string idbuku)
        {
            buku currentBook = new buku();
            koneksiSql sql = new koneksiSql();
            currentBook = sql.returnBuku(idbuku);

            InitializeComponent();

            txtTitle.Text = currentBook.title;
            txtAuthor.Text = currentBook.author;
            string[] temp = currentBook.path.Split('|');
            
            for(int i=0; i<temp.Count();i++)
            {
                temp[i] = utilitas.strukturFolder("buku") + temp[i];
            }

            listGambar = temp;

            kontrol.setFoto(pboxGambar, listGambar[0]);
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indeks -= 1;
            indeks %= listGambar.Count();
            kontrol.setFoto(pboxGambar, listGambar[indeks]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indeks += 1;
            indeks %= listGambar.Count();
            kontrol.setFoto(pboxGambar, listGambar[indeks]);
        }
    }
}
