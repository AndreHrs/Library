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

namespace Home
{
    public partial class formMain : Form
    {
        //Methods//
        private void setFoto(string pathFoto)
        {
            Image loadFoto = new Bitmap(pathFoto);
            pBoxProfile.BackgroundImage = loadFoto;
        }

        private void validasiAkun(string tipeAkun, string NamaAkun, string pathFoto)
        {
            lblAccountName.Text = NamaAkun;
            lblWelcome.Text = "Welcome " + NamaAkun+" ("+tipeAkun+")";
            if (tipeAkun != "Guest")
            {
                btnLend.Enabled = true;
                btnLend.BackgroundImage = Properties.Resources.lend;
                btnProfile.Enabled = true;
                btnProfile.BackgroundImage = Properties.Resources.profile;
            }
            if (tipeAkun == "Admin")
            {
                btnManage.Visible = true;
            }

            if (!String.IsNullOrEmpty(pathFoto))
            {
                setFoto(pathFoto);
            }
        }
        //End Methods


        public formMain(string tipeAkun, string NamaAkun, string pathFoto)
        { 
            InitializeComponent();
            validasiAkun(tipeAkun, NamaAkun, pathFoto);                   
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            menuBooks.Show(PointToScreen(booksDropdownLocation.Location));
        }

        private void btnManage_MouseClick(object sender, MouseEventArgs e)
        {
            menuManage.Show(PointToScreen(manageDropdownLocation.Location));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
