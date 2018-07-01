using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home
{
    public partial class Blank_Borderless1 : Form
    {
        DataSet data;
        public Blank_Borderless1(DataSet data)
        {
            InitializeComponent();
            this.data = data;
            LendingReport rpt = new LendingReport();
            rpt.SetDataSource(data);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Blank_Borderless1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
