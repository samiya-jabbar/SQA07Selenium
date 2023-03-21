using System;
using System.Security.Policy;
using System.Threading;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SQA07Selenium
{
    [TestClass]
    public class UTLocators
    {
       //Test#1
        [TestMethod]
        public void TestDemoqaRegistration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form/");
            driver.Url = "https://adactinhotelapp.com/";
            
            //MessageBox.Show(driver.Url);
            driver.FindElement(By.XPath("//*[@id=\"firstName\"]")).SendKeys("ayesha");
            driver.FindElement(By.CssSelector("#lastName")).SendKeys("ali");
            driver.FindElement(By.XPath("//*[@id=\"userEmail\"]")).SendKeys("ayesha21@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"genterWrapper\"]/div[2]/div[2]/label")).Click();
            driver.FindElement(By.CssSelector("#userNumber")).SendKeys("0321133344422");
            driver.FindElement(By.Id("userNumber")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("25 Jan 2019");
            driver.FindElement(By.CssSelector("#lastName")).Click();
            driver.FindElement(By.Id("subjectsInput")).SendKeys("English");
            driver.FindElement(By.Id("subjectsInput")).SendKeys("{Tab}");
            driver.FindElement(By.CssSelector("#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label")).Click();
            driver.FindElement(By.CssSelector("#uploadPicture")).SendKeys("D:\\01EducationalStuff\\03ProfessionalCourses\\11SQABootcamp\\SQA07Programming\\SQA07Selenium\\bin\\Debug\\SampleImage.jfif");
            driver.FindElement(By.Id("currentAddress")).SendKeys("R-24, Bufferzone");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(1000);
            driver.Close();
        }

        [TestMethod]
        public void TestDemoqaLogin()
        {

        }


        [TestMethod]
        public void TestDemoqaAutomateTextBox() 
        {
            IWebDriver drive = new ChromeDriver();
            drive.Url = "https://demoqa.com/text-box";
            drive.FindElement(By.Id("userName")).SendKeys("Group Nine");
            drive.FindElement(By.Id("userEmail")).SendKeys("group9@gmail.com");
            drive.FindElement(By.Id("currentAddress")).SendKeys("Karachi-Pakistan");
            drive.FindElement(By.Id("permanentAddress")).SendKeys("Karachi");
            drive.FindElement(By.Id("submit")).Click();
            
        }
        [TestMethod]
        public void TestDemoqaAutomateCheckBox()
        {
            IWebDriver drive = new ChromeDriver();
            drive.Url = "https://demoqa.com/checkbox";
            drive.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg")).Click();
            drive.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > ol > li:nth-child(2) > ol > li:nth-child(2) > span > label > span.rct-node-icon > svg > path")).Click();
        }

        [TestMethod]
        public void DemoQA_NestedFrame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/nestedframes";

            var frame1 = driver.FindElement(By.Id("frame1"));
            driver.SwitchTo().Frame(frame1);

            string text1 = driver.FindElement(By.CssSelector("body")).Text;
            //driver.SwitchTo().DefaultContent();
            MessageBox.Show(text1);

           // var frame2 = driver.FindElement(By.CssSelector("body > iframe")).Text;
            driver.SwitchTo().Frame(0);
            string text2 = driver.FindElement(By.CssSelector("body > p")).Text;
            MessageBox.Show(text2);
            driver.SwitchTo().DefaultContent();
            
            string text3 = driver.FindElement(By.CssSelector("#app > div > div > div.pattern-backgound.playgound-header")).Text;
            string text4 = driver.FindElement(By.CssSelector("#app > div > div > div.pattern-backgound.playgound-header > div")).Text;
            //MessageBox.Show(text3);
            string a = "Nested Frames";
            Assert.AreEqual(a, text3);
            driver.Quit();
          
        }
        [TestMethod]
        public void DemoQA_BrowserTab()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/browser-windows";
            // var frame1 = driver.FindElement(By.Id("frame1"));
             // driver.SwitchTo().Frame(frame1);
            driver.FindElement(By.Id("tabButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string newtab1= driver.FindElement(By.Id("sampleHeading")).Text;          
            //MessageBox.Show(newtab1);
            Assert.AreEqual("This is a sample page", newtab1);          
            Thread.Sleep(3000);
            driver.Quit();

        }
        [TestMethod]
        public void WindowSwitch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/browser-windows";          
            driver.FindElement(By.Id("windowButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string newtab2 = driver.FindElement(By.Id("sampleHeading")).Text;
            MessageBox.Show(newtab2);
            MessageBox.Show("newtab2 ok");
            Thread.Sleep(3000);
            driver.Quit();
           
        }
        [TestMethod]
        public void WindowMessage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/browser-windows";
            driver.FindElement(By.Id("messageWindowButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string message = driver.FindElement(By.CssSelector("body")).Text;
            Assert.AreEqual("Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.", message);
            Thread.Sleep(3000);
            driver.Quit();
            
        }

    }
    
}
