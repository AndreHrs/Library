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
        //Form can be repurposed to add or edit user account
        private void EnableControl()
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtName.Enabled = true;
            mtbTelephone.Enabled = true;
            rtbAddress.Enabled = true;
            btnChangePic.Enabled = true;
        }

        public FormProfile()
        {
            InitializeComponent();
            if(Program.TipeAkun == "Admin")
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
            this.Hide();
            formMain main = new formMain(Program.TipeAkun, Program.Nama, Program.PathFoto);
            main.Show();
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
    }
}
