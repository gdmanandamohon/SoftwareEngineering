using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.IO;
namespace controller
{
   public  class MainviewController
    {
        protected PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public int ProcessorUsages()
        {        
            int processorUsage = (int)cpuCounter.NextValue();
            return processorUsage;
        }
        
        public float MemoryUsage()
        {
            PerformanceCounter pf_MemoryCounter_Total = new PerformanceCounter("Memory", "Free & Zero Page List Bytes", "");
            float total = (pf_MemoryCounter_Total.NextValue() / 1024)/1024;
            PerformanceCounter pf_MemoryCounter_Avaiable = new PerformanceCounter("Memory", "Available MBytes", "");
            float memoryFree = pf_MemoryCounter_Avaiable.NextValue();
            float percentage = (total - memoryFree) / total;
            return memoryFree;
        }

        protected PerformanceCounter logical_disk = new PerformanceCounter("LogicalDisk", "% Disk Time", "_Total");

        public String DiskUsages()
        {
            int x = (int)logical_disk.NextValue();
            return x.ToString();
        }
        protected PerformanceCounter powerCounter = new PerformanceCounter("Power Meter", "Power", "_Total");

        public String PowerCalculator()
        {
            int power_remain = (int)powerCounter.NextValue();
            return power_remain.ToString();
        }

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
