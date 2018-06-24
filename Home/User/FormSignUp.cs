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
    public partial class FormSignUp : Form
    {
        string path = "";

        Utility fungsi = new Utility();
        ControlForm kontrol = new ControlForm();

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            pnlInfo.Show();
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            pnlInfo.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnPickPhoto_Click(object sender, EventArgs e)
        {
            path = kontrol.pickFoto(pictBoxPhoto);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pathFile = "";

            if (!String.IsNullOrEmpty(this.path))
                pathFile = fungsi.returnDestPath(this.path, "profil");

            string user = txtUsername.Text, pass = txtPassword.Text, tipe = "User", nama = txtName.Text,
                alamat = rtbAddress.Text, telp = mtbTelephone.Text.Replace("+62","0"), gender = cBoxGender.Text, fine = "0";
            koneksiSql koneksi = new koneksiSql();
            if (koneksi.InsertIntoUser(user, pass, tipe, nama, alamat, telp, gender, pathFile, fine))
            {
                fungsi.copyKe(path, "profil");
                this.Close();
            }  
            else
                txtUsername.Focus();

        }

        private void pBoxShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pBoxShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pBoxShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
