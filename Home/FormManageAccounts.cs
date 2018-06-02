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
    public partial class FormManageAccounts : Form
    {
        private DataSet ds;
        public FormManageAccounts()
        {
            InitializeComponent();
            isiDgv(txtSearch.Text);
        }

        private void isiDgv(string teks)
        {
            dgvAccounts.Rows.Clear();
            koneksiSql koneksi = new koneksiSql();
            SqlConnection conn = new SqlConnection(koneksi.getSqlConn());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Userlist Where Username LIKE '%{teks}%' or PasswordAkun LIKE '%{teks}%' or TipeAkun LIKE '%{teks}%'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
                    
            for(int i = 0; i< dataTable.Rows.Count; i++)
            {
                string username = dataTable.Rows[i][0].ToString();
                string password = dataTable.Rows[i][1].ToString();
                string tipeAkun = dataTable.Rows[i][2].ToString();
                dgvAccounts.Rows.Add(username, password, tipeAkun);
            }
            conn.Close();
        }
   

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProfile addAcc = new FormProfile();
            addAcc.AddNew();
            addAcc.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dgvAccounts.CurrentRow.Index;
            FormProfile editAcc = new FormProfile(dgvAccounts.SelectedCells[0].Value.ToString());
            editAcc.ShowDialog();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            koneksiSql koneksi = new koneksiSql();
            koneksi.removeUser(dgvAccounts.SelectedCells[0].Value.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isiDgv(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isiDgv(txtSearch.Text);
        }
    }
}
