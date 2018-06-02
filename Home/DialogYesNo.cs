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
    public partial class DialogYesNo : Form
    {
        public DialogYesNo()
        {
            InitializeComponent();
        }
        bool status = false;
        public bool getresult()
        {
            return status;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            status = true;
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            status = false;
            this.Hide();
        }
    }
}
