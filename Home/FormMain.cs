using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace Home
{
    public partial class formMain : Form
    {
        //Methods//
        ControlForm kontrol = new ControlForm();
        koneksiSql koneksi;
        DataSet dsOverdue = new DataSet();
        private void loadLowStock()
        {
            koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT BookId, PicturePath, Stock FROM Booklist ORDER BY Stock", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dsOverdue, "LowStock");
            panelSupport.Controls.Add(new NoOverdue(dsOverdue));
        }

        private void loadHotList()
        {
            koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand("SELECT Booklist.BookId, Booklist.PicturePath, Stock ,count(Lendings.BookID) AS jumlah FROM Booklist left join Lendings ON Booklist.BookId = Lendings.BookID GROUP BY Booklist.BookId, PicturePath, Stock ORDER BY jumlah DESC", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dsOverdue, "Hotlist");
            panelHotlist.Controls.Add(new hotBook(dsOverdue));
        }

        private bool checkOverdue()
        {
            bool overdue = false;
            koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * from Lendings INNER JOIN Booklist on Lendings.BookId = Booklist.BookID where Username = '{Program.userSekarang.user}'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dsOverdue, "Lendings");
            try
            {
                for (int i = 0; i < dsOverdue.Tables["Lendings"].Rows.Count; i++)
                {
                    Peminjaman temp = new Peminjaman();
                    temp.username = dsOverdue.Tables["Lendings"].Rows[i]["Username"].ToString();
                    temp.bookId = dsOverdue.Tables["Lendings"].Rows[i]["BookId"].ToString();
                    temp.lendId = dsOverdue.Tables["Lendings"].Rows[i]["LendId"].ToString();
                    temp.strLendDate = dsOverdue.Tables["Lendings"].Rows[i]["LendDate"].ToString();
                    temp.strDueDate = dsOverdue.Tables["Lendings"].Rows[i]["DueDate"].ToString();
                    temp.fineCount();
                    if (temp.fine > 0)
                    {
                        overdue = true;
                        break;
                    }
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return overdue;
        }
        private void notification()
        {

            bool overdue = checkOverdue();
            if (overdue)
            {
                //Send popup message
                PopupNotifier popup = new PopupNotifier();
                popup.BodyColor = Color.AliceBlue;
                popup.ButtonHoverColor = Color.Red;
                popup.HeaderColor = Color.Aqua;
                popup.TitleText = "Notification";
                popup.ContentText = "You have a book in lending which already passed deadline";
                popup.ContentHoverColor = Color.Black;
                popup.Popup();
                panelSupport.Controls.Add(new OverdueBooks(dsOverdue));
            }
            else
            {
                loadLowStock();
            }

        }

        private void validasiAkun(CurrentUser akun)
        {
            lblAccountName.Text = akun.nama;
            lblWelcome.Text = "Welcome " + akun.nama+" ("+akun.tipe+")";
            if (akun.tipe != "Guest")
            {
                btnLend.Enabled = true;
                btnLend.BackgroundImage = Properties.Resources.lend;
                btnProfile.Enabled = true;
                btnProfile.BackgroundImage = Properties.Resources.profile;
            }
            if (akun.tipe == "Admin")
            {
                btnManage.Visible = true;
            }

            if (!String.IsNullOrEmpty(akun.path))
            {
                kontrol.setFotoProfil(pBoxProfile, akun.path);
            }
            notification();
        }
        //End Methods

        public formMain(CurrentUser user)
        {
            InitializeComponent();
            validasiAkun(user);
            loadHotList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnManage_MouseClick(object sender, MouseEventArgs e)
        {
            menuManage.Show(PointToScreen(manageDropdownLocation.Location));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogYesNo yesno = new DialogYesNo();
            yesno.ShowDialog();
            if (yesno.getresult())
            {
                Program.resetLogin();
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void manageBook_Click(object sender, EventArgs e)
        {
            FormManageBooks formManageB = new FormManageBooks();
            formManageB.ShowDialog();
        }

        private void manageAccount_Click(object sender, EventArgs e)
        {
            FormManageAccounts formManageAcc = new FormManageAccounts();
            formManageAcc.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile(Program.userSekarang.user);
            profile.fromMain = true;
            this.Hide();
            profile.Show();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            FormLending lend = new FormLending();
            lend.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBookList booklist = new FormBookList();
            booklist.ShowDialog();
        }
    }
}
