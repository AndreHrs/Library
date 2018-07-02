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
    class ValidasiSignUp
    {
        Icon ikonNo = new Icon(@"..\..\..\Picture\Icons\NoIc.ico");
        Icon ikonYes = new Icon(@"..\..\..\Picture\Icons\Check.ico");
        ErrorProvider errProv = new ErrorProvider();
        ErrorProvider corrProv = new ErrorProvider();
        FormSignUp formTujuan;

        private void setIconErrProv()
        {
            errProv.Icon = ikonNo;
            corrProv.Icon = ikonYes;
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
            else
            {
                corrProv.SetError(objek, $"Done !");
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

        /*

        public bool validasi(Control objek, string nama)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(objek.Text))
            {
                valid = false;
                errProv.Icon = ikonYes;
                errProv.SetError(objek, $"{nama} Can't be left empty");
                formTujuan.setErr(objek, $"{nama} Can't be left empty");
            }
            else
            {
                formTujuan.setCorr(objek);
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
                formTujuan.setErr(objek, $"{nama} length must be more than {minimal} and less than {maximal - 1}");
            }
            else
            {
                formTujuan.setCorr(objek);
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
                    formTujuan.setErr(objek, $"{nama} must be text only !");
                }
            }
            else if (tipe == "angka")
            {
                if (valid && (value.Any(Char.IsPunctuation) || value.Any(Char.IsLetter) || value.Any(Char.IsSymbol) || value.Any(Char.IsPunctuation)))
                {
                    valid = false;
                    formTujuan.setErr(objek, $"{nama} must be text only !");
                }
            }
            if (valid)
                formTujuan.setCorr(objek);
            return valid;
        }*/
    }
}
