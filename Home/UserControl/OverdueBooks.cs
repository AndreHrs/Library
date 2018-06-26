using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home
{
    public partial class OverdueBooks : UserControl
    {
        List<string> listId = new List<string>();
        public OverdueBooks(DataSet dsOverdue)
        {
            InitializeComponent();

            ControlForm kontrol = new ControlForm();
            Panel[] listPanel= {pnlValue1, pnlValue2, pnlValue3, pnlValue4, pnlValue5};
            PictureBox[] listPbox = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            List<Peminjaman> listPinjam = new List<Peminjaman>();

            int counter = 0;
            for (int i = 0; i < dsOverdue.Tables["Lendings"].Rows.Count; i++)
            {
                Peminjaman temp = new Peminjaman();
                temp.username = dsOverdue.Tables["Lendings"].Rows[i]["Username"].ToString();
                temp.bookId = dsOverdue.Tables["Lendings"].Rows[i]["BookId"].ToString();
                temp.lendId = dsOverdue.Tables["Lendings"].Rows[i]["LendId"].ToString();
                temp.strLendDate = dsOverdue.Tables["Lendings"].Rows[i]["LendDate"].ToString();
                temp.strDueDate = dsOverdue.Tables["Lendings"].Rows[i]["DueDate"].ToString();
                temp.fineCount();
                string[] thumbnailList = dsOverdue.Tables["Lendings"].Rows[i]["PicturePath"].ToString().Split('|');
                //Done load data peminjaman//
                if (temp.fine > 0)
                {
                    kontrol.setFotoBuku(listPbox[counter % 5], thumbnailList[0]);
                    string fine = temp.fine.ToString();
                    listPanel[counter % 5].Controls.Add(new UcFineValue(fine));
                    listId.Add(temp.bookId);
                }
                

            }
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[0]);
                showbook.ShowDialog();
            }
            catch (Exception) { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[1]);
                showbook.ShowDialog();
            }
            catch (Exception)
            {

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[2]);
                showbook.ShowDialog();
            }
            catch (Exception)
            {

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[3]);
                showbook.ShowDialog();
            }
            catch (Exception)
            {

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[4]);
                showbook.ShowDialog();
            }
            catch (Exception)
            {

            }

        }
    }
}
