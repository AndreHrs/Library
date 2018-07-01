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
    public partial class FormSignUp : Form
    {
        string path = "";

        Utility fungsi = new Utility();
        ControlForm kontrol = new ControlForm();
        ValidasiSignUp validasi;

        public void setErr(Control objek, string message)
        {
            ErrProv.Clear();
            CorrProv.Clear();
            ErrProv.SetError(objek, message);
        }
        public void setCorr(Control objek)
        {
            ErrProv.Clear();
            CorrProv.Clear();
            CorrProv.SetError(objek, "Done");
        }

        private bool validasiInput()
        {
            /*FormSignUp formini = this;
            validasi = new ValidasiSignUp(formini);

            List<bool> listValidasi = new List<bool>();
            bool valid = true;

            listValidasi.Add(validasi.validasi(txtUsername, "Username", 8, 21));
            listValidasi.Add(validasi.validasi(txtPassword, "Password", 8, 21));
            listValidasi.Add(validasi.validasi(txtName, "Name", "teks", 1, 51));
            listValidasi.Add(validasi.validasi(rtbAddress, "Address", 1, 100));
            listValidasi.Add(validasi.validasi(cBoxGender, "Gender"));
            listValidasi.Add(validasi.validasi(mtbTelephone, "Telephone", 10, 13));
            if (chkBoxAgree.Checked)
            {
                listValidasi.Add(true);
                formini.setCorr(chkBoxAgree);
            }
            else
            {
                formini.setErr(chkBoxAgree, "Please check agree fist");
                listValidasi.Add(false);
            }

            foreach (bool b in listValidasi)
            {
                if (b == false)
                {
                    valid = false;
                    break;
                }
            }

            return valid;*/
            
            List<bool> listValidasi = new List<bool>();
            bool valid = true;

            kontrol.clear();
            listValidasi.Add(kontrol.validasi(txtUsername, "Username", 4, 21));
            listValidasi.Add(kontrol.validasi(txtPassword, "Password", 6, 21));
            listValidasi.Add(kontrol.validasi(txtName, "Name", "teks", 1, 51));
            listValidasi.Add(kontrol.validasi(rtbAddress, "Address", 1, 100));
            listValidasi.Add(kontrol.validasi(cBoxGender, "Gender"));
            listValidasi.Add(kontrol.validasi(mtbTelephone, "Telephone", 10, 13));
            if (chkBoxAgree.Checked)
            {
                listValidasi.Add(true);
            }    
            else
            {
                ErrProv.Clear();
                CorrProv.Clear();
                ErrProv.SetError(chkBoxAgree, "Please check agree fist");
                listValidasi.Add(false);
            }
            
            foreach(bool b in listValidasi)
            {
                if (b == false)
                {
                    valid = false;
                    break;
                }
            }
                             
            return valid;
        }

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
            if (validasiInput())     
            {
                string pathFile = "";
                string filename = "";

                if (!String.IsNullOrEmpty(this.path))
                {
                    pathFile = fungsi.returnDestPath(this.path, "profil");
                    filename = Path.GetFileName(pathFile);
                }
                    
                string user = txtUsername.Text, pass = txtPassword.Text, tipe = "User", nama = txtName.Text,
                    alamat = rtbAddress.Text, telp = mtbTelephone.Text.Replace("+62", "0"), gender = cBoxGender.Text, fine = "0";
                koneksiSql koneksi = new koneksiSql();
                if (koneksi.InsertIntoUser(user, pass, tipe, nama, alamat, telp, gender, filename, fine))
                {
                    fungsi.copyKe(path, "profil");
                    this.Close();
                }
                else
                    txtUsername.Focus();
            }
            else
            {
                FormKosong dialog = new FormKosong();
                dialog.loadUC(new UcNotif1(dialog));
                dialog.ShowDialog();
            }
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

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void mtbTelephone_TextChanged(object sender, EventArgs e)
        {
            mtbTelephone.Text = mtbTelephone.Text.ToString().Replace(' ', '\0');
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
