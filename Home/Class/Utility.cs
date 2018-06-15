using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Home
{
    public class Utility
    {
        string folderStructTxt = @"D:\ProjectC#\Library\folderStruct.enclib";
        public string strukturFolder(string tipe)
        {
            List<string> listPath = new List<string>();
            StreamReader reader = new StreamReader(folderStructTxt);
            while (!reader.EndOfStream)
            {
                listPath.Add(reader.ReadLine());
            }
            reader.Close();
            if (tipe == "profil")
                return listPath[0];
            else if (tipe == "buku")
                return listPath[1];
            return "";
        }

        public void copyKe(string srcPath, string tipe)
        {
            string filename = Path.GetFileName(srcPath);
            string destPath = strukturFolder(tipe);
            string sourceFile = srcPath, destFile = destPath + filename;
             
            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
            }
            try
            {
                File.Copy(sourceFile, destFile, true);
            }
            catch(Exception)
            {

            }          
        }
        
        public string returnDestPath(string srcPath, string tipe)
        {
            string filename = Path.GetFileName(srcPath);
            string destPath = strukturFolder(tipe);
            string sourceFile = srcPath, destFile = destPath + filename;
            return destFile;
        }
    }
}
