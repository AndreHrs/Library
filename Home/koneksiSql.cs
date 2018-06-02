using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Home
{
    public class koneksiSql
    {
        private string ConnectionString = @"Data Source=ANDRE-MSI\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        protected SqlConnection sqlConn = new SqlConnection(@"Data Source=ANDRE-MSI\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        string query = "";
        

        public string getSqlConn()
        {
            return ConnectionString;
        }

  
        public Boolean InsertIntoUser(string user, string pass, string tipe, string nama, string alamat, string telp, string gender, string path)
        {
            try
            {
                query = $"INSERT INTO Userlist VALUES('{user}', '{pass}', '{tipe}', '{nama}', '{alamat}', '{telp}', '{gender}', '{path}')";
                SqlCommand command = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                command.ExecuteNonQuery();
                DialogNormal dialog = new DialogNormal("Sukses", "Data Added Successfully", 78, 85);
                dialog.ShowDialog();
                sqlConn.Close();
                return true;
            }
            catch(Exception e)
            {
                DialogNormal dialogErr = new DialogNormal("Error","Username Already Used",48,86);
                dialogErr.ShowDialog();
                return false;
            }           
        }

        public Boolean UpdateUser(string user, string pass, string tipe, string nama, string alamat, string telp, string gender, string path)
        {
            try
            {
                query = $"UPDATE Userlist SET PasswordAkun='{pass}', TipeAkun = '{tipe}',Nama = '{nama}',Alamat = '{alamat}', Telepon='{telp}', Gender='{gender}', FilePath='{path}' WHERE Username='{user}'";
                SqlCommand command = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                command.ExecuteNonQuery();
                DialogNormal dialog = new DialogNormal("Sukses", "Data Changed Successfully", 78, 85);
                dialog.ShowDialog();
                sqlConn.Close();
                return true;
            }
            catch (Exception e)
            {
                DialogNormal dialogErr = new DialogNormal("Error", "Failed to Save", 48, 86);
                dialogErr.ShowDialog();
                sqlConn.Close();
                return false;
            }

        }

        public void removeUser(string username)
        {
            DialogYesNo yesno = new DialogYesNo();
            yesno.ShowDialog();
            if(yesno.getresult())
            {
                query = $"DELETE FROM Userlist WHERE Username='{username}'";
                SqlCommand command = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                command.ExecuteNonQuery();
                DialogNormal dialog = new DialogNormal("Notice", "Data Deleted", 139, 85);
                dialog.ShowDialog();
                sqlConn.Close();
            }

            
        }

        public Boolean validasiLogin(string username, string password)
        {
            query = $"SELECT * FROM Userlist WHERE Username = '{username}' and PasswordAkun = '{password}'";
            SqlDataReader sdr;
            SqlCommand command = new SqlCommand(query, sqlConn);

            sqlConn.Open();

            sdr = command.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                sqlConn.Close();
                return true;
            }
            else
            {
                sqlConn.Close();
                return false;
            }
        }

        public CurrentUser returnUser(string username)
        {
            CurrentUser temp = new CurrentUser();
            query = $"SELECT * FROM Userlist WHERE Username = '{username}'";
            SqlDataReader sdr;
            SqlCommand command = new SqlCommand(query, sqlConn);
            sqlConn.Open();
            sdr = command.ExecuteReader();

            //Get value
            sdr.Read();
            temp.user = sdr.GetString(0).Trim();
            temp.pass = sdr.GetString(1).Trim();
            temp.tipe = sdr.GetString(2).Trim();
            temp.nama = sdr.GetString(3).Trim();
            temp.alamat = sdr.GetString(4).Trim();
            temp.telp = sdr.GetString(5).Trim();
            temp.telp = temp.telp.Substring(1, temp.telp.Length - 1);
            temp.gender = sdr.GetString(6).Trim();
            temp.path = @sdr.GetString(7).Trim();

            //return class
            sqlConn.Close();
            return temp;
        }
    }
}
