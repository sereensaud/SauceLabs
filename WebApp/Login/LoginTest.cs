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
       IWebDriver driver = null;
       // public string url;

        public LoginTest(IWebDriver driver2)
        {
            this.driver = driver2;
        }
    public void logintestauth(string url, string user, string password)
        {
            driver.Url = url;
            LoginPage POMloginPage = new LoginPage();
            POMloginPage.EnterUserName(driver, user);
            POMloginPage.EnterPassword(driver, password);
            POMloginPage.ClickLogin(driver);
            Asserts POMassert = new Asserts();
            POMassert.Verification(driver, "title", "PRODUCTS");
            ElementAction elementAction = new ElementAction();
            elementAction.ScrollPage(driver);
            Snapshots POMsnapshots = new Snapshots();
            POMsnapshots.screenshot(driver);
         
        }
    }
}
