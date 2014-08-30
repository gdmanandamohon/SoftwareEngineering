using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
   public  class CCleanerClass
    {
        public void cleanTemp()
        {
            foreach (string filePath in System.IO.Directory.GetFiles("C:\\Windows\\Temp\\", "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    FileInfo currentFile = new FileInfo(filePath);
                    currentFile.Delete();
                }
                catch (Exception ex)
                {
                    // Debug.WriteLine("Error on file: {0}\r\n   {1}", filePath, ex.Message);
                }
            }
        }

        public void clean_PTemp()
        {
            string str = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\";
            foreach (string filePath in System.IO.Directory.GetFiles(str, "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    FileInfo currentFile = new FileInfo(filePath);
                    currentFile.Delete();
                }
                catch (Exception ex)
                {
                    // Debug.WriteLine("Error on file: {0}\r\n   {1}", filePath, ex.Message);
                }
            }
        }

        public void cleanPrefetch()
        {
            foreach (string filePath in System.IO.Directory.GetFiles("C:\\Windows\\Prefetch\\", "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    FileInfo currentFile = new FileInfo(filePath);
                    currentFile.Delete();
                }
                catch (Exception ex)
                {
                    // Debug.WriteLine("Error on file: {0}\r\n   {1}", filePath, ex.Message);
                }
            }
        }

        public void cleanTempInternetCach()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            //for deleting files
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            foreach (string filePath in System.IO.Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    FileInfo currentFile = new FileInfo(filePath);
                    currentFile.Delete();
                }
                catch (Exception ex)
                {
                    // Debug.WriteLine("Error on file: {0}\r\n   {1}", filePath, ex.Message);
                }
            }
        }
    }
}
