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
using Tulpep.NotificationWindow;

namespace Home
{
    public partial class formMain : Form
    {
        //Methods//
        ControlForm kontrol = new ControlForm();

        private void notification()
        {

            
            //Check if user have unreturned book
            /*
            if true
            {
                //Send popup message
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Notification";
                popup.ContentText = "You have a book in lending which already passed deadline";
                popup.Popup();
            }
            */

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
            Program.resetLogin();
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
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
