using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SQA07Selenium
{
    [TestClass]
    public class UTKeywordsDriven
    {
        [TestMethod]
        //These all are attributes
        [Owner("Samiya Jabbar")]
        [Description("This Test Case is for Showing Keyword Driven Process")]
        [TestCategory("Login") , TestCategory("Smoke")]
        [WorkItem(1123)] // e.g for user story etc
        public void Testabc()
        {

        }


        [TestMethod]
        [Ignore] //if this tage is given then it will ignore this method while execution of test cases
        [Priority(1)]
        public void Testabc2() 
        { }  
    }
}