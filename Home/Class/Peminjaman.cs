using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Peminjaman
    {
        public string lendId, username, bookId;
        public double fine = 0;

        private string lendDateString, dueDateString;
        private double finepday = 1000;
        DateTime lendDate, dueDate, returnDate;

        public void addLendDate()
        {
            lendDate = DateTime.Now;
        }

        public void addDueDate()
        {
            DateTime temp = lendDate;
            dueDate = temp.AddDays(10);
        }

        public void fineCount()
        {
            converToDateTime();
            returnDate = DateTime.Now;
            int day = (returnDate - dueDate).Days;
            if (day > 0)
            {
                fine = day * finepday;
            }
            else
            {
                fine = 0;
            }         
        }

        public string strLendDate
        {
            get { return lendDateString; }
            set { lendDateString = value; }
        }

        public string strDueDate
        {
            get { return dueDateString; }
            set { dueDateString = value; }
        }

        public void convertToString()
        {
            lendDateString = lendDate.ToString("dd MM yyyy");
            dueDateString = dueDate.ToString("dd MM yyyy");
        }

        public void converToDateTime()
        {
            lendDate = DateTime.ParseExact(lendDateString, "dd MM yyyy", null);
            dueDate = DateTime.ParseExact(dueDateString, "dd MM yyyy", null);
        }
    }
}
