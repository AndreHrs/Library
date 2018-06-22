using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.Dialogs
{
    public partial class userControl1 : UserControl
    {
        DialogNormal dia;
        Panel pnl;
        public userControl1(DialogNormal dia, Panel pnl)
        {
            InitializeComponent();
            this.dia = dia;
            this.pnl = pnl;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dia.Close();
        }
    }
}
