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
    public partial class FormProfile : Form
    {
        koneksiSql koneksi = new koneksiSql();
        protected bool AddNewAcc = false;
        private void loadFoto(string filepath)
        {
            Image loadFoto = new Bitmap(filepath);
            pictureBox2.BackgroundImage = loadFoto;
        }

        //Form can be repurposed to add or edit user account
        private void EnableControl()
        {
            txtPassword.Enabled = true;
            txtName.Enabled = true;
            mtbTelephone.Enabled = true;
            rtbAddress.Enabled = true;
            btnChangePic.Enabled = true;
            btnSave.Enabled = true;
            cBoxGender.Enabled = true;
        }

        public void AddNew()
        {
            txtUsername.Enabled = true;
            EnableControl();
            btnEdit.Visible = false;
            AddNewAcc = true;
        }

        public FormProfile()
        {

            InitializeComponent();
            if(Program.userSekarang.tipe == "Admin")
            {
                lblAccountType.Visible = true;
                cBoxAccountType.Visible = true;
            }
        }

        public FormProfile(string username) //Overload untuk edit
        {
            CurrentUser temp = new CurrentUser();
            temp = koneksi.returnUser(username);
            InitializeComponent();
            txtUsername.Text = temp.user;
            txtPassword.Text = temp.pass;
            txtName.Text = temp.nama;
            mtbTelephone.Text = temp.telp;
            cBoxGender.Text = temp.gender;
            rtbAddress.Text = temp.alamat;
            cBoxAccountType.Text = temp.tipe; 
            if(!String.IsNullOrEmpty(temp.path))
            {
                lblPhotoPath.Text = temp.path;
                loadFoto(lblPhotoPath.Text);
            }

            if (Program.userSekarang.tipe == "Admin")
            {
                lblAccountType.Visible = true;
                cBoxAccountType.Visible = true;
            }
        }

        public FormProfile(string username, string password,
            string nama, string telepon, string gender, string address, string type, string filepath) //Overload untuk edit
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtName.Text = nama;
            mtbTelephone.Text = telepon;
            cBoxGender.Text = gender;
            rtbAddress.Text = address;
            cBoxAccountType.Text = type;
            lblPhotoPath.Text = filepath;
            loadFoto(filepath);

            if (Program.TipeAkun == "Admin")
            {
                lblAccountType.Visible = true;
                cBoxAccountType.Visible = true;
            }
        }

        public FormProfile(string username, string password,
            string nama, string telepon, string gender, string address, string type) //Overload untuk edit acc tanpa foto
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtName.Text = nama;
            mtbTelephone.Text = telepon;
            cBoxGender.Text = gender;
            rtbAddress.Text = address;
            cBoxAccountType.Text = type;

            if (Program.TipeAkun == "Admin")
            {
                lblAccountType.Visible = true;
                cBoxAccountType.Visible = true;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableControl();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBoxShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pBoxShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pBoxShow_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            string path = "", filepath;
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileName;
                if ((path.EndsWith(".jpg")) || path.EndsWith(".png") || path.EndsWith(".gif"))
                {
                    filepath = path;
                    lblPhotoPath.Text = filepath;
                    loadFoto(filepath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text, pass = txtPassword.Text, tipe = cBoxAccountType.Text, nama = txtName.Text,
                alamat = rtbAddress.Text, telp = mtbTelephone.Text.Replace("+62", "0"), gender = cBoxGender.Text, path = lblPhotoPath.Text;
            if (AddNewAcc)
            {
                if (koneksi.InsertIntoUser(user, pass, tipe, nama, alamat, telp, gender, path))
                    this.Close();
                else
                    txtUsername.Focus();
            }
            else
            {
                if (koneksi.UpdateUser(user, pass, tipe, nama, alamat, telp, gender, path))
                    this.Close();
                else
                    txtUsername.Focus();
                
            }

        }
    }
}
