using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Home
{
    public partial class FormAddEditBook : Form
    {
        Utility utilitas = new Utility();
        ControlForm kontrol = new ControlForm();
        string bookId, title, author, year, genre, path, stock;
        bool editExisting = false;

        private bool validasiInput()
        {
            kontrol.clear();
            List<bool> listValidasi = new List<bool>();
            bool valid = true;

            listValidasi.Add(kontrol.validasi(txtBookId, "BookId", 3, 21));
            listValidasi.Add(kontrol.validasi(txtAuthor, "Author Name"));
            listValidasi.Add(kontrol.validasi(txtTitle, "Title"));
            listValidasi.Add(kontrol.validasi(txtYear, "Released Year", "angka",3,5));
            listValidasi.Add(kontrol.validasi(txtAuthor, "Author Name"));

            foreach (bool b in listValidasi)
            {
                if (b == false)
                {
                    valid = false;
                    break;
                }
            }

            return valid;
        }

        private string convertList()
        {
            string stringList = "";

            foreach (string x in listBoxGambar.Items)
            {
                stringList += x + "|";
            }
            if(string.IsNullOrEmpty(stringList))
            {
                return "";
            }
            else
            {
                stringList = stringList.Substring(0, stringList.Length - 1);
                return stringList;
            }    
        }

        private void fillCredentials()
        {
            bookId = txtBookId.Text.Trim();
            title = txtTitle.Text.Trim();
            author = txtAuthor.Text.Trim();
            year = txtYear.Text.Trim();
            genre = txtGenre.Text.Trim();
            path = convertList().Trim();
            stock = nudStock.Value.ToString();
        }

        public FormAddEditBook()
        {
            InitializeComponent();
            lblWelcome.Text = "Add Book"; 
        }

        public FormAddEditBook(string bookId) //Overload Constructor utk Edit
        {
            buku currentBook = new buku();
            koneksiSql sql = new koneksiSql();
            currentBook = sql.returnBuku(bookId);

            InitializeComponent();
            lblWelcome.Text = "Edit Book";
            editExisting = true;

            txtBookId.Enabled = false;
            txtBookId.Text = currentBook.bookId;
            txtTitle.Text = currentBook.title;
            txtAuthor.Text = currentBook.author;
            txtGenre.Text = currentBook.genre;
            txtYear.Text = currentBook.year;
            nudStock.Value = Convert.ToInt32(currentBook.stock);
            string[] temp = currentBook.path.Split('|');
            foreach (string x in temp)
            {
                listBoxGambar.Items.Add(x);
            }
            
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


        private void FormAddEditBook_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string path = openfile.FileName;
                if ((path.EndsWith(".jpg")) || path.EndsWith(".png") || path.EndsWith(".gif"))
                {   
                    utilitas.copyKe(path, "buku");
                    listBoxGambar.Items.Add(Path.GetFileName(path));
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBoxGambar.Items.RemoveAt(listBoxGambar.SelectedIndex);
        }

        private void listBoxGambar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                kontrol.setFotoBuku(pBoxPreview, listBoxGambar.SelectedItem.ToString());
            }
            catch (Exception)
            {
                pBoxPreview.BackgroundImage = null;
            }  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validasiInput())
            {
                koneksiSql koneksi = new koneksiSql();
                fillCredentials();
                if (editExisting)
                {
                    if (koneksi.UpdateBook(bookId, title, author, year, genre, path, stock))
                        this.Close();
                    else
                        txtBookId.Focus();
                }
                else
                {
                    if (koneksi.InsertIntoBooklist(bookId, title, author, year, genre, path, stock))
                        this.Close();
                    else
                        txtBookId.Focus();
                }
            }
            else
            {
                FormKosong dialog = new FormKosong();
                dialog.loadUC(new UcNotif1(dialog));
                dialog.ShowDialog();
            }


        }
    }
}
