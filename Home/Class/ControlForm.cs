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
    public partial class ControlForm : Form
    {
        Utility utilitas = new Utility();
        ErrorProvider errProv = new ErrorProvider();

        public void setFoto(Control objek, string pathFoto)
        {
            try
            {
                Image loadFoto = new Bitmap(pathFoto);
                objek.BackgroundImage = loadFoto;
            }
            catch (Exception)
            {
                objek.BackgroundImage = null;
            }
        }

        public void setFotoBuku(Control objek, string namaFoto)
        {
            try
            {
                string path = utilitas.strukturFolder("buku") + namaFoto;
                Bitmap temp = new Bitmap(path);
                objek.BackgroundImage = temp;
            }
            catch (Exception)
            {
                objek.BackgroundImage = null;
            }
        }

        public void setFotoProfil(Control objek, string namaFoto)
        {
            try
            {
                string path = utilitas.strukturFolder("profil") + namaFoto;
                Bitmap temp = new Bitmap(path);
                objek.BackgroundImage = temp;
            }
            catch (Exception)
            {
                objek.BackgroundImage = null;
            }
        }

        public bool validasi(Control objek)
        {
            bool valid = true;
            koneksiSql koneksi = new koneksiSql();

            return valid;
        }

        public bool validasi(Control objek, string nama)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(objek.Text))
            {
                valid = false;
                errProv.SetError(objek, $"{nama} cannot be empty !");
            }
            return valid;
        }
        public bool validasi(Control objek, string nama, int minimal, int maximal)
        {
            bool valid = true;

            //Check if blank or not
            valid = validasi(objek, nama);

            //If not blank then validate the char count
            if (valid && (string.IsNullOrEmpty(objek.Text) || objek.Text.Length <= minimal || objek.Text.Length >= maximal))
            {
                valid = false;
                errProv.SetError(objek, $"{nama} length must be more than {minimal} and less than {maximal}");
            }
            return valid;
        }

        public bool validasi(Control objek, string nama, string tipe, int minimal, int maximal)
        {
            bool valid = true;

            //Validate the char count and blank or not
            valid = validasi(objek, nama, minimal, maximal);

            string value = objek.Text.ToString();
            if (tipe == "teks")
            {
                if (valid && (value.Any(Char.IsDigit) || value.Any(Char.IsSymbol) || value.Any(Char.IsPunctuation)))
                {
                    valid = false;
                    errProv.SetError(objek, $"{nama} must be text only !");
                }      
            }
            else if (tipe == "angka")
            {
                if (valid && (value.Any(Char.IsPunctuation) ||value.Any(Char.IsLetter) || value.Any(Char.IsSymbol) || value.Any(Char.IsPunctuation)))
                {
                    valid = false;
                    errProv.SetError(objek, $"{nama} must be number only !");
                }
            }
            return valid;
        }

        public string pickFoto(Control objek)
        {
            string path;
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileName;
                if ((path.EndsWith(".jpg")) || path.EndsWith(".png") || path.EndsWith(".gif"))
                {
                    setFoto(objek, path);
                    return path;
                }
            }
            return "";
        }
    }
}
