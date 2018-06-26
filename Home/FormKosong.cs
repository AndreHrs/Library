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
    public partial class FormKosong : Form
    {
        public FormKosong()
        {
            InitializeComponent();  
        }

        public void loadUC(UserControl uc1)
        {
            panel2.Controls.Add(uc1);
        }
    }
}
