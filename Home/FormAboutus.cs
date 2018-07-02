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
    public partial class FormAboutus : Form
    {
        List<About> listAnggota = new List<About>();
        int indeks = 0;
        private void loadDataAnggota()
        {
            //Add Andre
            About temp = new About();
            temp.nim = "16.111.0277";
            temp.nama = "Andre Harsono";
            temp.nick = "Regaze";
            temp.motto = "The more time you think you have \nthe less time you actually have";
            temp.gambar = Properties.Resources.Me;
            listAnggota.Add(temp);

            //Add Andy
            temp = new About();
            temp.nim = "16.111.0099";
            temp.nama = "Andy Yusuf";
            temp.nick = "YuAndyTX";
            temp.motto = "Live a Life You Will Remember";
            temp.gambar = Properties.Resources.ndy;
            listAnggota.Add(temp);

            //Add Ant
            temp = new About();
            temp.nim = "16.111.0439";
            temp.nama = "Anthony";
            temp.nick = "runningman225";
            temp.motto = "Live as if it's your last";
            temp.gambar = Properties.Resources.Ant;
            listAnggota.Add(temp);

            //Add Enjel
            temp = new About();
            temp.nim = "16.111.1027";
            temp.nama = "Enjelin";
            temp.nick = "[Offline] Data Provider";
            temp.motto = "I Can do it !!! \nYou can do it !!! \nWe can do it !!!";
            temp.gambar = Properties.Resources.Enjel;
            listAnggota.Add(temp);

            //Add Kevin
            temp = new About();
            temp.nim = "16.111.3273";
            temp.nama = "Kevin";
            temp.nick = "Hyjet";
            temp.motto = "Why everyone quoted about live ?";
            temp.gambar = Properties.Resources.Kepin;
            listAnggota.Add(temp);

            //Add Vivi
            temp = new About();
            temp.nim = "16.111.0609";
            temp.nama = "Vivi Wijaya";
            temp.nick = "[Offline] Data Provider";
            temp.motto = "Surpass yourself !";
            temp.gambar = Properties.Resources.Vi;
            listAnggota.Add(temp);

            //Add Stip
            temp = new About();
            temp.nim = "16.111.0153";
            temp.nama = "Steven";
            temp.nick = "Vexsten";
            temp.motto = "Masalah bukanlah masalah jika \ntidak dipermasalahkan";
            temp.gambar = Properties.Resources.Stip;
            listAnggota.Add(temp);
        }

        private void loadData(int indeks)
        {
            lblNIM.Text = listAnggota[indeks].nim;
            lblNama.Text = listAnggota[indeks].nama;
            lblNick.Text = listAnggota[indeks].nick;
            lblMotto.Text = listAnggota[indeks].motto;
            pBoxProfile.BackgroundImage = listAnggota[indeks].gambar;
        }

        public FormAboutus()
        {
            InitializeComponent();
            loadDataAnggota();
            loadData(indeks);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (indeks == 0)
                indeks = listAnggota.Count - 1;
            else
                indeks -= 1;
            loadData(indeks);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (indeks == listAnggota.Count - 1)
                indeks = 0;
            else
                indeks += 1;
            loadData(indeks);
        }
    }
}
