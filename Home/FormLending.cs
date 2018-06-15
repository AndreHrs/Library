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
    public partial class FormLending : Form
    {
        bool fined;
        private void isiBuku(buku buku1)
        {
            txtBookTitle.Text = buku1.title;
            txtAuthor.Text = buku1.author;
            txtGenre.Text = buku1.genre;
        }

        private void isiPeminjaman(Peminjaman pinjam)
        {
            txtLendDate.Text = pinjam.strLendDate;
            txtDeadline.Text = pinjam.strDueDate;
            lblFineAmount.Text = "Rp. "+pinjam.fine.ToString();
        }
        private void isiDgv(string username)
        {
            dgvBooks.Rows.Clear();
            koneksiSql koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * from Lendings where Username = '{username}'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Lendings");
            try
            {
                for (int i = 0; i < ds.Tables["Lendings"].Rows.Count; i++)
                {
                    string lendId = ds.Tables["Lendings"].Rows[i][0].ToString();
                    string user = ds.Tables["Lendings"].Rows[i][1].ToString();
                    string idBuku = ds.Tables["Lendings"].Rows[i][2].ToString();
                    string lend = ds.Tables["Lendings"].Rows[i][3].ToString();
                    string due = ds.Tables["Lendings"].Rows[i][4].ToString();
                    dgvBooks.Rows.Add(lendId, user, "0", idBuku, lend, due);
                }
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public FormLending()
        {
            InitializeComponent();
        }

        public FormLending(string username)
        {
            InitializeComponent();
            isiDgv(username);
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

        private void FormLending_Load(object sender, EventArgs e)
        {
            isiDgv(Program.userSekarang.user);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idBuku = dgvBooks.SelectedCells[3].Value.ToString();
            koneksiSql koneksi = new koneksiSql();
            buku bukuTerpilih = koneksi.returnBuku(idBuku);
            isiBuku(bukuTerpilih);

            Peminjaman pinjam = koneksi.returnLend(dgvBooks.SelectedCells[1].Value.ToString(), dgvBooks.SelectedCells[0].Value.ToString());
            isiPeminjaman(pinjam);

            if (pinjam.fine > 0)
            {
                fined = true;
            }
            btnReturnBook.Enabled = true;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            koneksiSql koneksi = new koneksiSql();
            buku temp = new buku();
            temp = koneksi.returnBuku(dgvBooks.SelectedCells[3].Value.ToString());
            string fine = lblFineAmount.Text.Substring(4,lblFineAmount.Text.Length-4);
            bool yes = koneksi.finishLend(dgvBooks.SelectedCells[0].Value.ToString());    
            if (fined && yes)
            {
                DialogNormal denda = new DialogNormal($"Returned", $"You have been Fined {fine}", 43, 85);
                denda.ShowDialog();
                koneksi.updateFine(Program.userSekarang.user, fine);
                koneksi.updateStock(temp.bookId, temp.stock, "add");
            }
            isiDgv(Program.userSekarang.user);
        }
    }
}
