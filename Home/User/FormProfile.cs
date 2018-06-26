using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Home
{
    public partial class FormProfile : Form
    { 
        Utility fungsi = new Utility();
        ControlForm kontrol = new ControlForm();
        koneksiSql koneksi = new koneksiSql();
        protected bool AddNewAcc = false;
        public bool fromMain = false;
        string path = "";

        private void checkFromMain()
        {
            if (fromMain)
            {
                CurrentUser userSkrng = koneksi.returnUser(Program.userSekarang.user);
                Program.userSekarang = userSkrng;
                this.Hide();

                formMain form = new formMain(userSkrng);
                form.Show();
            }
            else
            {
                this.Close();
            }
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

        private bool validasiInput()
        {
            List<bool> listValidasi = new List<bool>();
            bool valid = true;
            listValidasi.Add(kontrol.validasi(txtPassword, "Password", 8, 21));
            listValidasi.Add(kontrol.validasi(txtName, "Name", "teks", 1, 51));
            listValidasi.Add(kontrol.validasi(rtbAddress, "Address", 1, 100));
            listValidasi.Add(kontrol.validasi(cBoxGender, "Gender"));
            listValidasi.Add(kontrol.validasi(mtbTelephone, "Telephone", 10, 13));

            foreach (bool b in listValidasi)
            {
                if (b == false)
                {
                    valid = false;
                    break;
                }
            }

            return valid;
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
            txtFine.Text = temp.fine;
            lblPhotoPath.Text = temp.path;
            if(!String.IsNullOrEmpty(temp.path))
            {
                kontrol.setFotoProfil(pictureBox2, temp.path);
            }

            if (Program.userSekarang.tipe == "Admin")
            {
                lblAccountType.Visible = true;
                cBoxAccountType.Visible = true;
            }
            txtUsername.Focus();
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
            checkFromMain();
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
            path = kontrol.pickFoto(pictureBox2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validasiInput())
            {
                string pathFile = "";

                if (!String.IsNullOrEmpty(this.path))
                    pathFile = fungsi.returnDestPath(this.path, "profil");

                string user = txtUsername.Text, pass = txtPassword.Text, tipe = cBoxAccountType.Text, nama = txtName.Text,
                    alamat = rtbAddress.Text, telp = mtbTelephone.Text.Replace("+62", "0"), gender = cBoxGender.Text, fine = txtFine.Text;
                if (AddNewAcc)
                {
                    if (koneksi.InsertIntoUser(user, pass, tipe, nama, alamat, telp, gender, Path.GetFileName(pathFile), fine))
                    {
                        fungsi.copyKe(path, "profil");
                        this.Close();
                    }
                    else
                        txtUsername.Focus();
                }
                else
                {
                    if (koneksi.UpdateUser(user, pass, tipe, nama, alamat, telp, gender, Path.GetFileName(pathFile), fine))
                    {
                        fungsi.copyKe(path, "profil");
                        checkFromMain();
                    }

                    else
                        txtUsername.Focus();
                }
            }    
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (Convert.ToInt32(txtFine.Text) > 0)
            {
                koneksi.UserPayFine(username);
                txtFine.Text = "0";
            }
            else
            {
                DialogNormal dialog = new DialogNormal("Error", "No Fine to Pay", 127, 85);
                dialog.ShowDialog();
            }
            
        }
    }
}
