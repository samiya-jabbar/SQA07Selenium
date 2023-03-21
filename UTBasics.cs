using System;
using System.Security.Policy;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SQA07Selenium
{
    [TestClass]
    public class UTBasic
    {
        [TestMethod] // Attribute --> by applying this attribute before of normal class and methods are changed
        public void TestLoginOnly()
        {
        IWebDriver driver = new ChromeDriver(); //it's a jin, whatever we say to him, it will perform it for us
        driver.Manage().Window.Maximize();
        driver.Url = "https://adactinhotelapp.com/";
        driver.FindElement(By.Id("username")).SendKeys("jabbasam");
        driver.FindElement(By.Id("password")).SendKeys("123456");
        driver.FindElement(By.Id("login")).Click();
        Thread.Sleep(5000);
        driver.Close();

        }

        [TestMethod]
        public void TestAssertion() 
        {
        }

        [TestMethod]
        public void TestMultipleBrowsers()
        {
            
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new EdgeDriver();

            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("jabbasam");
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.Id("login")).Click();
            driver.Close();
        }

        [TestMethod]
        public void TestBrowserOptions() 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("-start-maximized");
            // options.AddArguments("headless");
            // options.AddArguments("incognito");

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("jabbasam");
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.Id("login")).Click();
            driver.Close();

        }
    }
    
}
