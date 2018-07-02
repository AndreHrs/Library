using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class UcNotif1 : UserControl
    {
        Form form;
        public UcNotif1(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
