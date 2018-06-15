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
    public partial class FormManageBooks : Form
    {
        public FormManageBooks()
        {
            InitializeComponent();
            isiDgv(txtSearch.Text);
        }

        private void isiDgv(string teks)
        {
            dgvBooks.Rows.Clear();
            koneksiSql koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Booklist Where Title LIKE '%{teks}%' or Author LIKE '%{teks}%' or Genre LIKE '%{teks}%' or YearReleased LIKE '%{teks}%'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Booklist");

            for (int i = 0; i < ds.Tables["Booklist"].Rows.Count; i++)
            {
                string idBuku = ds.Tables["Booklist"].Rows[i][0].ToString();
                string title = ds.Tables["Booklist"].Rows[i][1].ToString();
                string author = ds.Tables["Booklist"].Rows[i][2].ToString();
                string year = ds.Tables["Booklist"].Rows[i][3].ToString();
                string genre = ds.Tables["Booklist"].Rows[i][4].ToString();
                dgvBooks.Rows.Add(idBuku, title, author, year, genre);
            }
            conn.Close();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dgvBooks.CurrentRow.Index;
            FormAddEditBook editBook = new FormAddEditBook(dgvBooks.SelectedCells[0].Value.ToString());
            editBook.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            koneksiSql koneksi = new koneksiSql();
            try
            {
                koneksi.removeBook(dgvBooks.SelectedCells[0].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditBook addbook = new FormAddEditBook();
            addbook.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isiDgv(txtSearch.Text);
        }
    }
}
