using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace SQA07Selenium
{
    #region SeliniumWithInitAttributes

    [TestClass]
    public class SeliniumWithInitAttributes
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        #region ASSEMBLY INIT AND CLEANUP

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            MessageBox.Show("AssemblyInit");

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("AssemblyCleanup");
        }
        #endregion

        #region CLASS INIT AND CLEANUP

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            MessageBox.Show("ClassInit 2");

        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            MessageBox.Show("ClassCleanUp 2");
        }

        #endregion

        #region TEST INIT AND CLEANUP
        [TestInitialize]
        public void TestInit()
        {
            MessageBox.Show("TestInit 2");
        }

        [TestCleanup]
        public void TestClean()
        {
            MessageBox.Show("TestClean 2");
        }

        #endregion

        [TestMethod]
        public void TestCase_001()
        {
            MessageBox.Show("TestCase_001 2");

        }

        [TestMethod]
        public void TestCase_002()
        {
            MessageBox.Show("TestCase_002 2");

        }
    }

    #endregion




}
