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
    public partial class NoOverdue : UserControl
    {
        List<string> listId = new List<string>();

        private void loadLowStock(ref int counter, PictureBox[] listPbox, DataSet dsOverdue)
        {
            ControlForm kontrol = new ControlForm();
            for (int i = 0; i < dsOverdue.Tables["LowStock"].Rows.Count && counter <= 4; i++)
            {
                string id = dsOverdue.Tables["LowStock"].Rows[i]["BookId"].ToString();
                string[] thumbnailList = dsOverdue.Tables["LowStock"].Rows[i]["PicturePath"].ToString().Split('|');
                int stock = Convert.ToInt32(dsOverdue.Tables["LowStock"].Rows[i]["Stock"]);
                if (stock > 0)
                {
                    kontrol.setFotoBuku(listPbox[counter], thumbnailList[0]);
                    counter += 1;
                    listId.Add(id);
                }
            }
        }

        private void loadOutofStock(ref int counter, PictureBox[] listPbox, DataSet dsOverdue)
        {
            label1.Text = "Out of Stock";
            ControlForm kontrol = new ControlForm();
            for (int i = 0; i < dsOverdue.Tables["LowStock"].Rows.Count && counter <= 4; i++)
            {
                string id = dsOverdue.Tables["LowStock"].Rows[i]["BookId"].ToString();
                string[] thumbnailList = dsOverdue.Tables["LowStock"].Rows[i]["PicturePath"].ToString().Split('|');
                int stock = Convert.ToInt32(dsOverdue.Tables["LowStock"].Rows[i]["Stock"]);
                if(stock == 0)
                {
                    kontrol.setFotoBuku(listPbox[counter], thumbnailList[0]);
                    counter += 1;
                    listId.Add(id);
                }  
            }
        }
        public NoOverdue(DataSet dsOverdue)
        {
            InitializeComponent();
            ControlForm kontrol = new ControlForm();
            PictureBox[] listPbox= { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            int counter = 0;
            loadLowStock(ref counter, listPbox, dsOverdue);

            if(counter == 0)
            {
                loadOutofStock(ref counter, listPbox, dsOverdue);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowBookForm showbook = new ShowBookForm(listId[0]);
                showbook.ShowDialog();
            }
            catch(Exception)
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
