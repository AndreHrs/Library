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
    public partial class ShowLog : Form
    {
        DataSet data;
        public ShowLog()
        {
            InitializeComponent();
        }
        public ShowLog(DataSet data)
        {
            InitializeComponent();
            this.data = data;
            ReportLog rpt = new ReportLog();
            rpt.SetDataSource(data);
            crystalReportViewer1.ReportSource = rpt;
        }


    }
}
