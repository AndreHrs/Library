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
        DataSet ds;
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

        private void isiDgv()
        {
            dgvBooks.Rows.Clear();
            koneksiSql koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * from Lendings", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Lendings");
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void isiDgv(string username)
        {
            dgvBooks.Rows.Clear();
            koneksiSql koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * from Lendings where Username = '{username}'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
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
            isiDgv(Program.userSekarang.user);
            txtBookTitle.Focus();
            if (Program.userSekarang.tipe == "Admin")
            {
                button1.Visible = true;
                button2.Visible = true;
            }
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
            else
            {
                koneksi.updateFine(Program.userSekarang.user, fine);
                koneksi.updateStock(temp.bookId, temp.stock, "add");
            }
            isiDgv(Program.userSekarang.user);
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            try
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
            }
            catch(Exception)
            {

            }
           

           
            btnReturnBook.Enabled = true;
        }

        private void ViewMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printMenu.Show(PointToScreen(DroplocPrint.Location));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewMenu.Show(PointToScreen(DroplocView.Location));
        }

        private void ViewThis_Click(object sender, EventArgs e)
        {
            isiDgv(Program.userSekarang.user);
            dgvBooks.Columns[1].Visible = false;
            dgvBooks.Columns[3].Width = 300;
            dgvBooks.Columns[4].Width = 300;
            dgvBooks.Columns[5].Width = 300;
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            isiDgv();
            dgvBooks.Columns[1].Visible = true;
            dgvBooks.Columns[1].Width = 225;
            dgvBooks.Columns[3].Width = 225;
            dgvBooks.Columns[4].Width = 225;
            dgvBooks.Columns[5].Width = 225;
        }

        private void PrintThis_Click(object sender, EventArgs e)
        {
            ViewThis_Click(null,null);
            Blank_Borderless1 form = new Blank_Borderless1(ds);
            form.ShowDialog();
        }

        private void PrintAll_Click(object sender, EventArgs e)
        {
            ViewAll_Click(null, null);
            Blank_Borderless1 form = new Blank_Borderless1(ds);
            form.ShowDialog();
        }
    }
}
