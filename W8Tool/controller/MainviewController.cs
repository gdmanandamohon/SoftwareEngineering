using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
namespace controller
{
   public  class MainviewController
    {
        protected PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public String ProcessorUsages()
        {        
            int processorUsage = (int)cpuCounter.NextValue();
            return processorUsage.ToString();
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
    }
}
