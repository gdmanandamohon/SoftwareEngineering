using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using controller;
using System.Linq.Expressions;



namespace TestProject
{
       
    [TestClass]
    public class UnitTest1
    {
        CCleanerClass CC= new CCleanerClass();
        CPUperformance CP = new CPUperformance();

        [TestMethod]
        public void Test_cleanTemp()
        {
            CC.cleanTemp();
        }

        [TestMethod]
        public void Test_clean_PTemp()
        {
            CC.clean_PTemp();
        }

        [TestMethod]
        public void Test_cleanPrefetch()
        {
            CC.cleanPrefetch();
        }

        [TestMethod]
        public void Test_cleanTempInternetCach()
        {
            CC.cleanTempInternetCach();
        }

        [TestMethod]
        public void Test_MemoryUsage()
        {
            CP.MemoryUsage();
        }

        [TestMethod]
        public void Test_ProcessorUsages()
        {
            CP.ProcessorUsages();
        }

        [TestMethod]
        public void Test_DiskUsages()
        {
           
            try
            {

                CP.DiskUsages();
                //Assert.IsTrue(true, "OCCUR");
                //CP.Equals(0);
                
               
            }

            catch (Exception ex)
            {
                Assert.Fail("\nA EXCEPTION OCCURS FOR :\n\n" + ex.Message);
                //Assert.Fail("\n\nNo exception OCCUR");
                Assert.IsTrue(true, "OCCUR");
            }
             
















        }

        [TestMethod]
        public void Test_PowerCalculator()
        {
            try
            {

                CP.PowerCalculator();
            }

            catch (Exception ex)
            {
                Assert.Fail("\nA EXCEPTION OCCURS FOR :\n\n" + ex);
            }
           // Assert.Fail("\n\nNo exception OCCURS");

        }

        [TestMethod,Timeout(2000)]
        public void Test_PowerCalculator1()
        {
            try
            {

                CP.PowerCalculator();
                //Assert.IsTrue(true, "ok");
                 
            }

            catch (Exception ex)
            {
                Assert.Fail("\nA EXCEPTION OCCURS FOR :\n\n" + ex.Source);
            }  
            // Assert.Fail("\n\nNo exception OCCURS");
           // Assert.IsTrue(true, "ok");

        }

















        [TestMethod]
        public void Test_upload()
        {
            try
            {

                CP.upload();
            }




            catch (Exception ex)
            {
                //Assert.Fail("\nA EXCEPTION THROWN FOR :\n\n");
                Assert.Fail("\n\nA EXCEPTION THROWN FOR :" + ex.GetHashCode());
                //Assert.Fail("\n\nNo exception OCCUR");
            }
        }


        [TestMethod]
        public void Test_download()
        {
           
            try
            {
               
                CP.download();
            }
          


          
            catch (Exception ex)
            {
                //Assert.Fail("\nA EXCEPTION THROWN FOR :\n\n");
                Assert.Fail("\n\nA EXCEPTION THROWN FOR :" + ex.GetHashCode());
                //Assert.Fail("\n\nNo exception OCCUR");
            }
           //Assert.Fail("No exception OCCURS");

          

        }

          [TestMethod]
        public void Test_download1()
        {

            try
            {

                CP.download();
            }




            catch (Exception ex)
            {
                //Assert.Fail("\nA EXCEPTION THROWN FOR :\n\n");
                Assert.Fail("\nA EXCEPTION THROWN FOR :\n\n" + ex.Message);
                //Assert.Fail("\n\nNo exception OCCUR");
            }
            //Assert.Fail("No exception OCCURS");



        }

















     



    }
}

