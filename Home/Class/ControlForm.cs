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
        private ErrorProvider Correct;
        private IContainer components;
        private ErrorProvider Error;

        Icon ikonNo = new Icon(@"..\..\..\Picture\Icons\NoIc.ico");
        Icon ikonYes = new Icon(@"..\..\..\Picture\Icons\Check.ico");
        ErrorProvider errProv = new ErrorProvider();
        ErrorProvider corrProv = new ErrorProvider();

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

        private void setIconErrProv()
        {
            errProv.Icon = ikonNo;
            corrProv.Icon = ikonYes;
            
        }

        public void clear()
        {
            errProv.Clear();
            corrProv.Clear();
        }

        public bool validasi(Control objek, string nama)
        {
            setIconErrProv();
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
            int panjang = objek.Text.Length;
            if (objek is MaskedTextBox)
            {
                panjang -= 2;
            }

            //If not blank then validate the char count
            if (valid && (string.IsNullOrEmpty(objek.Text) || panjang < minimal || panjang > maximal))
            {
                valid = false;
                errProv.SetError(objek, $"{nama} length must be more than {minimal} and less than {maximal}");
            }
            if (valid)
            {
                corrProv.SetError(objek, "Done !");
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
                if (valid && (value.Any(Char.IsPunctuation) || value.Any(Char.IsLetter) || value.Any(Char.IsSymbol) || value.Any(Char.IsPunctuation)))
                {
                    valid = false;
                    errProv.SetError(objek, $"{nama} must be number only !");
                }
            }
            if (valid)
            {
                corrProv.SetError(objek, "Done !");
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.Correct = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Correct
            // 
            this.Correct.ContainerControl = this;
            this.Correct.Icon = ((System.Drawing.Icon)(resources.GetObject("Correct.Icon")));
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // ControlForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ControlForm";
            ((System.ComponentModel.ISupportInitialize)(this.Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
