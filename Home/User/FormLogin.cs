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
    public partial class FormLogin : Form
    {    
        private void cekNull(Control objek)
        {
            if (String.IsNullOrEmpty(objek.Text))
            {
                objek.Focus();
            }
        }
        public FormLogin()
        {
            
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            linkLabel1.BackColor = System.Drawing.Color.Transparent;
        }
     
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formMain form = new formMain(Program.userSekarang);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                cekNull(txtPassword);
                cekNull(txtUsername);
                DialogError dialog = new DialogError();
                dialog.BackgroundImage = Properties.Resources.blank;
                dialog.ShowDialog();
            }
            else
            {
                koneksiSql koneksi = new koneksiSql();
                string username = txtUsername.Text.Trim(), password = txtPassword.Text.Trim();
                koneksi.validasiLogin(username, password);

                if (koneksi.validasiLogin(username, password))
                {
                    CurrentUser user = koneksi.returnUser(username);
                    if(txtUsername.Text == user.user && txtPassword.Text == user.pass)
                    {
                        Program.userSekarang = user;
                        this.Hide();

                        formMain form = new formMain(user);
                        form.Show();
                    }
                    else
                    {
                        DialogError dialog = new DialogError();
                        dialog.ShowDialog();
                    }
                }
                else
                {
                    DialogError dialog = new DialogError();
                    dialog.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignUp signup = new FormSignUp();
            signup.ShowDialog();
        }

        private void pBoxShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pBoxShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(null, null);
            }   
        }

        private void pBoxShow_Click(object sender, EventArgs e)
        {

        }
    }
}
