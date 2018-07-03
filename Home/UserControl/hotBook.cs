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
    public partial class hotBook : UserControl
    {
        ControlForm kontrol = new ControlForm();
        List<string> listId = new List<string>();
        public hotBook(DataSet dsOverdue)
        {
            InitializeComponent();
            PictureBox[] listPbox = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            Label[] listLabel = { label2, label3, label4, label5, label6 };
            int counter = 0;

            for (int i = 0; i < dsOverdue.Tables["Hotlist"].Rows.Count && counter <= 4; i++)
            {
                string id = dsOverdue.Tables["Hotlist"].Rows[i]["BookId"].ToString();
                string[] thumbnailList = dsOverdue.Tables["Hotlist"].Rows[i]["PicturePath"].ToString().Split('|');
                int stock = Convert.ToInt32(dsOverdue.Tables["Hotlist"].Rows[i]["Stock"]);
                kontrol.setFotoBuku(listPbox[counter], thumbnailList[0]);
                if (stock == 0)
                {
                    listLabel[counter].Visible = true;
                }
                counter += 1;
                listId.Add(id);          
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[0]);
                showbook.ShowDialog();
            }
            catch (Exception)
            {

            }
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
