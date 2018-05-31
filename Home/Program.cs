using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Home
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Splash Screen
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Random rand = new Random();
            Thread.Sleep(rand.Next(3000, 7000));
            t.Abort();
            //Splash Screen End

            Application.Run(new FormLogin());
        }

        static void StartForm()
        {
            Application.Run(new Splashscreen());
        }
        public static string Nama, TipeAkun, PathFoto;
    }
}
