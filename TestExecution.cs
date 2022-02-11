using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SauceLabs
{
    [TestClass]
    public class TestExecution

    {
        public TestContext instance;

        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\Data\loginData.xml", "user", DataAccessMethod.Sequential)]
        public void TestMethod_Login()
        {
            string browsername = TestContext.DataRow["browsername"].ToString();
            string browsertype = TestContext.DataRow["browsertype"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username1"].ToString();
            string password = TestContext.DataRow["pass"].ToString();
            Factory browserfactory = new Factory();
            browserfactory.BrowserFactory(browsername, browsertype);
            browserfactory.driver.Url=url;
            LoginPage POMloginPage = new LoginPage();
            POMloginPage.EnterUserName(browserfactory.driver,user);
            POMloginPage.EnterPassword(browserfactory.driver,password);
            POMloginPage.ClickLogin(browserfactory.driver);
            Asserts POMassert = new Asserts();
            POMassert.Verification(browserfactory.driver, "title", "PRODUCTS");
            Snapshots POMsnapshots = new Snapshots();
            POMsnapshots.screenshot(browserfactory.driver);
            browserfactory.driver.Close(); 
        }


    }
}