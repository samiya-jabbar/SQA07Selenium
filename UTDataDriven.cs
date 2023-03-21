//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;

//namespace SQA07Selenium
//{
//    [TestClass]
//    public class UTDataDriven
//    {
//        #region TEST WITH DATA ROW
//        [TestMethod]
//        [DataRow("jabbasam", "123456" , "url")]
//        public void TestDataRow(username, password, url)
//        {

//        }
//        #endregion

//        #region TEST WITH DATA SOURCES CSV & XML
//        public TestContext instance;
//        public TestContext TestContext  // whole project details are hold by this testcontext
//        {
//            set { instance = value; }
//            get { return instance; }
//        }

//        [TestMethod]
//        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Data.csv", "data#csv", DataAccessMethod.Sequential)]
//        public void TestDataSourceCsv()
//        {
//            string url = TestContext.DataRow["url"].ToString();
//            string user = TestContext.DataRow["username"].ToString();
//            string pass = TestContext.DataRow["password"].ToString();

//            IWebDriver driver = new ChromeDriver();

//            driver.Url = url;
//            driver.FindElement(By.Id("username")).SendKeys(user);
//            driver.FindElement(By.Id("password")).SendKeys(pass);
//            driver.FindElement(By.Id("login")).Click();
//            driver.Close();

//        }

//        [TestMethod]
//        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "TestCase_DataDriven_XML_001", DataAccessMethod.Sequential)]
//        //type, path, parent tag, random/sequence read
//        public void TestDataSourceXml()
//        {
//            string url = TestContext.DataRow["url"].ToString();
//            string user = TestContext.DataRow["username"].ToString();
//            string pass = TestContext.DataRow["password"].ToString();

//            IWebDriver driver = new ChromeDriver();

//            driver.Url = url;
//            driver.FindElement(By.Id("username")).SendKeys(user);
//            driver.FindElement(By.Id("password")).SendKeys(pass);
//            driver.FindElement(By.Id("login")).Click();
//            driver.Close();
//        }
//        #endregion
//    }
//}
