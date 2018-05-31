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
            formMain form = new formMain("Guest", "Guest","");
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain form = new formMain("Admin", "Andre", @"D:\Mikroskil\Sem 4\OOP C#\ProjectC#\Pic Folders\Andre.jpg");
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp signup = new FormSignUp();
            signup.Show();
        }
    }
}
