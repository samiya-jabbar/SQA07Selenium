using System;
using System.Security.Policy;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SQA07Selenium
{
    [TestClass]
    public class Fiverr
    {
        [TestMethod] // Attribute --> by applying this attribute before of normal class and methods are changed
        public void TestLogin()
        {
            IWebDriver driver = new ChromeDriver();

            // driver.Url = "https://www.heb.com/";
            //driver.Navigate().GoToUrl("https://accounts.heb.com/interaction/0HgupsNWJjeeI0lB-njEB/register");
            driver.Url = "https://www.walmart.com/account/login?vid=oaoh&tid=0&returnUrl=%2F";
            //driver.Manage().Window.Maximize();

            //driver.FindElement(By.XPath("//*[@id=\"root\"]/header/div[2]/div/ul/li[1]/a[2]")).Click();
            //driver.FindElement(By.Id("firstName")).SendKeys("Samiya");
            //driver.FindElement(By.Id("lastName")).SendKeys("Marlee");
            //driver.FindElement(By.Id("email")).SendKeys("samia@gmail.com");
            //driver.FindElement(By.Id("password")).SendKeys("123456");
            //driver.FindElement(By.Id("phone")).SendKeys("030566348748");
            //driver.FindElement(By.XPath("//*[@id=\"sso-root\"]/div/main/div/div/div[2]/form/fieldset/div[5]")).Click();
            // driver.FindElement(By.Id("email")).SendKeys("samia@gmail.com");
            Thread.Sleep(5000);
           // driver.Close();

        }
    }

}
