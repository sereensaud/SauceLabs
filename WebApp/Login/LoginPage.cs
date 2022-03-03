using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public partial class LoginPage

    {

        ElementAction elementAction = new ElementAction();
        #region Enter User Name
        /// <summary>
        /// this method enters users name to login
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="username"></param>
        public void EnterUserName(IWebDriver driver, string username)
        {

            //driver.FindElement(username_Locator).SendKeys(username_keys);
            elementAction.EnterText(driver, username_Locator,username, elementtypeid);

        }
        #endregion
        #region Enter Password
        /// <summary>
        /// this method enters users password to login
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="password"></param>
        public void EnterPassword(IWebDriver driver, string password)
        {

            //driver.FindElement(password_Locator).SendKeys(password_keys);
            elementAction.EnterText(driver, password_Locator, password, elementtypeid);

        }
        #endregion
        #region Login Now
        /// <summary>
        /// this method clicks on the login button on login page
        /// </summary>
        /// <param name="driver"></param>
        public void ClickLogin(IWebDriver driver)
        {

            //driver.FindElement(loginbutton_Locator).Click();
            elementAction.ClickItem(driver, loginbutton_Locator, elementtypeid);

        }
        #endregion
    

    }
}
