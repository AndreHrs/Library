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


    public partial class FormBookList : Form
    {
        private void isiData(string title, string author, string year, string genre)
        {
            txtTitle.Text = title;
            txtAuthor.Text = author;
            txtYear.Text = year;
            txtGenre.Text = genre;
        }

        private string randomDigit()
        {
            Random rand = new Random();
            string temp= Program.userSekarang.user.Substring(0, 3);
            for(int i = 0; i<5;i++)
            {
                temp += rand.Next(0, 9).ToString();
            }
            return temp;
        }
        private void isiDgv(string teks)
        {
            dgvBooks.Rows.Clear();
            koneksiSql koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Booklist Where Title LIKE '%{teks}%' or Author LIKE '%{teks}%' or Genre LIKE '%{teks}%' or YearReleased LIKE '%{teks}%'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Booklist");

            for (int i = 0; i < ds.Tables["Booklist"].Rows.Count; i++)
            {
                string idBuku = ds.Tables["Booklist"].Rows[i][0].ToString();
                string title = ds.Tables["Booklist"].Rows[i][1].ToString();
                string author = ds.Tables["Booklist"].Rows[i][2].ToString();
                string year = ds.Tables["Booklist"].Rows[i][3].ToString();
                string genre = ds.Tables["Booklist"].Rows[i][4].ToString();
                string stock = ds.Tables["Booklist"].Rows[i][6].ToString();
                dgvBooks.Rows.Add(idBuku, title, author, year, genre, stock);
            }
            conn.Close();
        }

        public FormBookList()
        {
            InitializeComponent();
            if (Program.userSekarang.tipe == "Guest")
            {
                btnLend.Enabled = false;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnView.Enabled = true;
            btnLend.Enabled = true;
        }

        private void FormBookList_Load(object sender, EventArgs e)
        {
            isiDgv(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isiDgv(txtSearch.Text);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = dgvBooks.SelectedCells[1].Value.ToString(),
                author = dgvBooks.SelectedCells[2].Value.ToString(),
                year = dgvBooks.SelectedCells[3].Value.ToString(),
                genre = dgvBooks.SelectedCells[4].Value.ToString();
            isiData(title, author, year, genre);
            btnView.Enabled = true;
            if (Program.userSekarang.tipe != "Guest")
                btnLend.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ShowBookForm showBook = new ShowBookForm(dgvBooks.SelectedCells[0].Value.ToString());
            showBook.ShowDialog();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(Program.userSekarang.fine) <= 0))
            {
                if((Convert.ToInt32(dgvBooks.SelectedCells[5].Value) > 0))
                {
                    Peminjaman lend = new Peminjaman();
                    Random rand = new Random();
                    string user = Program.userSekarang.user,
                        idBuku = dgvBooks.SelectedCells[0].Value.ToString();
                    bool success = false;
                    lend.lendId = randomDigit();
                    lend.username = user;
                    lend.bookId = idBuku;
                    lend.addLendDate();
                    lend.addDueDate();
                    lend.convertToString();
                    koneksiSql koneksi = new koneksiSql();
                    do
                    {
                        try
                        {
                            koneksi.makeLend(lend.lendId, lend.username, lend.bookId, lend.strLendDate, lend.strDueDate);
                            koneksi.updateStock(idBuku, dgvBooks.SelectedCells[5].Value.ToString(), "remove");
                            success = true;
                        }
                        catch
                        {
                            lend.lendId = randomDigit();
                        }
                    } while (!success);
                }
                else
                {
                    DialogNormal dialog = new DialogNormal("Notice", "The stock currently Empty", 70, 85);
                    dialog.ShowDialog();
                }
                
            }
            else
            {
                DialogNormal dialog = new DialogNormal("Notice", "You have unpaid Fine \n Please pay your fine first!", 70, 65);
                dialog.ShowDialog();
            }
            isiDgv(txtSearch.Text);

        }
    }
}
