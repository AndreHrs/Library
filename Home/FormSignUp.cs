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
        private void loadFoto(string filepath)
        {
            Image loadFoto = new Bitmap(filepath);
            pictBoxPhoto.BackgroundImage = loadFoto;
        }
        string pathFoto ="";
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
            string path = "", filepath;
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileName;
                if ((path.EndsWith(".jpg")) || path.EndsWith(".png") || path.EndsWith(".gif"))
                {
                    pathFoto = path;
                    loadFoto(pathFoto);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text, pass = txtPassword.Text, tipe = "User", nama = txtName.Text,
                alamat = rtbAddress.Text, telp = mtbTelephone.Text.Replace("+62","0"), gender = cBoxGender.Text, path = pathFoto;
            koneksiSql koneksi = new koneksiSql();
            if (koneksi.InsertIntoUser(user, pass, tipe, nama, alamat, telp, gender, path))
                this.Close();
            else
                txtUsername.Focus();

        }
    }
}
