using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class LoginTest
    {
        #region Prelimanries
        ElementAction elementAction = new ElementAction();
        IWebDriver driver = null;
       // public string url;

        public LoginTest(IWebDriver driver2)
        {
            this.driver = driver2;
        }
        #endregion
        #region Login Test
        /// <summary>
        /// this method is to test login
        /// </summary>
        /// <param name="url"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public void logintestauth(string url, string user, string password)
        {
            #region LoginTest
            driver.Url = url;
            LoginPage POMloginPage = new LoginPage();
            POMloginPage.EnterUserName(driver, user);
            POMloginPage.EnterPassword(driver, password);
            POMloginPage.ClickLogin(driver);
            #endregion
            #region Assertion
            Asserts POMassert = new Asserts();
            POMassert.Verification(driver, "title", "PRODUCTS");
            #endregion
            #region scroll effect
            elementAction.ScrollPage(driver);
            #endregion
            #region Screenshot 
            Snapshots POMsnapshots = new Snapshots();
            POMsnapshots.screenshot(driver);
            #endregion

        }
        #endregion
    }
}
