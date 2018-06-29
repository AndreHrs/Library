using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Home
{
    public class koneksiSql
    {

        Utility utilitas = new Utility();
        private string ConnectionString;//@"Data Source=andre-msi\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        protected SqlConnection sqlConn;// = new SqlConnection(@"Data Source=BEAST\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        string query = "";

        public koneksiSql()
        {
            string constring = utilitas.getConString();
            ConnectionString = constring;
            sqlConn = new SqlConnection(constring);
        }

        public string getSqlConn()
        {
            return ConnectionString;
        }

        private bool executeSQL(string qCommand, string successMsg, string failMsg, int sucX, int sucY, int faiX, int faiY)
        {
            try
            {
                query = qCommand;
                SqlCommand command = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                command.ExecuteNonQuery();
                DialogNormal dialog = new DialogNormal("Success", successMsg, sucX, sucY);
                dialog.ShowDialog();
                sqlConn.Close();
                return true;
            }
            catch (Exception)
            {
                DialogNormal dialogErr = new DialogNormal("Error", failMsg, faiX, faiY);
                dialogErr.ShowDialog();
                return false;
            }
        }

        private bool executeSQLnoMsg(string qCommand)
        {
            try
            {
                query = qCommand;
                SqlCommand command = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                command.ExecuteNonQuery();
                sqlConn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool removeQuery(string qCommand, string successMsg, int sucX, int sucY)
        {
            DialogYesNo yesno = new DialogYesNo();
            yesno.ShowDialog();
            if (yesno.getresult())
            {
                query = qCommand;
                SqlCommand command = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                command.ExecuteNonQuery();
                DialogNormal dialog = new DialogNormal("Notice", successMsg, sucX, sucY);
                dialog.ShowDialog();
                sqlConn.Close();
                return true;
            }
            return false;
        }


        //Lending//
        public void makeLend(string lendId, string username, string bookid, string lendDate, string dueDate)
        {
            executeSQL($"INSERT INTO Lendings VALUES('{lendId}','{username}','{bookid}','{lendDate}','{dueDate}')",
                "Data Added Successfully", "Failed to make a lend", 78, 85, 48, 86);
        }

        public bool finishLend(string lendId)
        {
            return removeQuery($"DELETE FROM Lendings WHERE LendId = '{lendId}'", "Book Returned", 139, 85);
        }

        public void updateFine(string username, string fine)
        {
            executeSQLnoMsg($"UPDATE Userlist SET Fine={fine} WHERE Username='{username}'");
        }

        public void updateStock(string bookId, string stock, string type)
        {
            int newStock;
            if(type == "add")
            {
                newStock = Convert.ToInt32(stock) + 1;
            }
            else
            {
                newStock = Convert.ToInt32(stock) - 1;
            }
            executeSQLnoMsg($"UPDATE Booklist SET Stock='{newStock.ToString()}' WHERE BookId='{bookId}'");
        }

        public Peminjaman returnLend(string username, string lendId)
        {
            Peminjaman temp = new Peminjaman();
            query = $"SELECT * FROM Lendings WHERE Username = '{username}' AND LendId ='{lendId}'";
            SqlDataReader sdr;
            SqlCommand command = new SqlCommand(query, sqlConn);
            sqlConn.Open();
            sdr = command.ExecuteReader();

            //Get value
            sdr.Read();
            temp.lendId = sdr.GetString(0).Trim();
            temp.username = sdr.GetString(1).Trim();
            temp.bookId = sdr.GetString(2).Trim();
            temp.strLendDate = sdr.GetString(3).Trim();
            temp.strDueDate = sdr.GetString(4).Trim();
            temp.converToDateTime();
            temp.fineCount();
            //return class
            sqlConn.Close();
            return temp;
        }

        //Booklist Type//
        public Boolean InsertIntoBooklist(string bookid, string title, string author, string year, string genre, string path, string stock)
        {
            return executeSQL($@"INSERT INTO Booklist VALUES('{bookid}', '{title}', '{author}', '{year}', '{genre}', '{path}', '{stock}')",
                "Data Added Successfully", "BookId Already Used", 78, 85, 48, 86);
        }

        public Boolean UpdateBook(string bookid, string title, string author, string year, string genre, string path, string stock)
        {
            return executeSQL($"UPDATE Booklist SET Title='{title}', Author = '{author}',YearReleased = '{year}',Genre = '{genre}', PicturePath='{path}', Stock = '{stock}' WHERE BookId='{bookid}'",
                "Data Updated Successfully", "Failed to Save", 78, 85, 48, 86);
        }

        public void removeBook(string bookid)
        {
            removeQuery($"DELETE FROM Booklist WHERE BookId='{bookid}'", "Data Deleted", 139, 85);
        }


        public buku returnBuku(string idBuku)
        {
            buku temp = new buku();
            query = $"SELECT * FROM Booklist WHERE BookId='{idBuku}'";
            SqlDataReader sdr;
            SqlCommand command = new SqlCommand(query, sqlConn);
            sqlConn.Open();
            sdr = command.ExecuteReader();

            //Get value
            sdr.Read();
            temp.bookId = sdr.GetString(0).Trim();
            temp.title = sdr.GetString(1).Trim();
            temp.author = sdr.GetString(2).Trim();
            temp.year = sdr.GetString(3).Trim();
            temp.genre = sdr.GetString(4).Trim();
            temp.path = sdr.GetString(5).Trim();
            temp.stock = sdr.GetString(6).Trim();

            //return class
            sqlConn.Close();
            return temp;
        }
        //Booklist Type End//


        //Userlist Type//
        public Boolean validasiLogin(string username, string password)
        {                  
            try
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
            catch(Exception)
            {
                return false;
            }
            
        }

        public Boolean InsertIntoUser(string user, string pass, string tipe, string nama, string alamat, string telp, string gender, string path, string fine)
        {
            return executeSQL($"INSERT INTO Userlist VALUES('{user}', '{pass}', '{tipe}', '{nama}', '{alamat}', '{telp}', '{gender}', '{path}', '{fine}')",
                "Data Added Successfully", "Failed to Save", 78, 85, 48, 86);
        }

        public Boolean UpdateUser(string user, string pass, string tipe, string nama, string alamat, string telp, string gender, string path, string fine)
        {
            return executeSQL($"UPDATE Userlist SET PasswordAkun='{pass}', TipeAkun = '{tipe}',Nama = '{nama}',Alamat = '{alamat}', Telepon='{telp}', Gender='{gender}', FilePath='{path}', Fine='{fine}' WHERE Username='{user}'",
                "Data Updated Successfully", "Failed to Save", 78, 85, 48, 86);
        }

        public void UserPayFine(string user)
        {
            executeSQL($"UPDATE Userlist SET Fine='0' WHERE Username='{user}'",
                "Fine Paid", "Payment Failed", 160, 85, 48, 86);
        }

        public void removeUser(string username)
        {
            removeQuery($"DELETE FROM Userlist WHERE Username='{username}'", "Data Deleted", 139, 85);     
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
            temp.fine = sdr.GetString(8).Trim();

            //return class
            sqlConn.Close();
            return temp;
        }
        //Userlist Type End//
    }
}
