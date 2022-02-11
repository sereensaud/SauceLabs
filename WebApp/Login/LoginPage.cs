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
 
        public void EnterUserName(IWebDriver driver, string username)
        {

            //driver.FindElement(username_Locator).SendKeys(username_keys);
            elementAction.EnterText(driver, username_Locator,username, elementtypeid);

        }
        public void EnterPassword(IWebDriver driver, string password)
        {

            //driver.FindElement(password_Locator).SendKeys(password_keys);
            elementAction.EnterText(driver, password_Locator, password, elementtypeid);

        }
        public void ClickLogin(IWebDriver driver)
        {

            //driver.FindElement(loginbutton_Locator).Click();
            elementAction.ClickItem(driver, loginbutton_Locator, elementtypeid);

        }

    }
}
