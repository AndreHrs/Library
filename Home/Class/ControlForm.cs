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
        public ControlForm()
        {
            InitializeComponent();
        }

        public void setFoto(Control objek, string pathFoto)
        {
            try
            {
                Image loadFoto = new Bitmap(pathFoto);
                objek.BackgroundImage = loadFoto;
            }
            catch(Exception)
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
