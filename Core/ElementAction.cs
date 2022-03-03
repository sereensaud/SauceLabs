using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class ElementAction
    {
        #region To enter some text
        /// <summary>
        /// this is to enter text by sending driver, the locator, its value and its type
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <param name="elementtype"></param>
        public void EnterText(IWebDriver driver, By element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "Name")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "xpath")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "className")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "cssSelector")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "LinkText")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "PartialLinkText")
            {
                driver.FindElement(element).SendKeys(value);
            }
            if (elementtype == "tagName")
            {
                driver.FindElement(element).SendKeys(value);
            }
        }
        #endregion
        #region to click on a item
        /// <summary>
        /// this is to click on an element by sending driver, the locator and its type
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="elementtype"></param>
        public void ClickItem(IWebDriver driver, By element, string elementtype)
        {
            if (elementtype == "Id")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "Name")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "xpath")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "className")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "cssSelector")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "LinkText")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "PartialLinkText")
            {
                driver.FindElement(element).Click();
            }
            if (elementtype == "tagName")
            {
                driver.FindElement(element).Click();
            }
        }
        #endregion
        #region To select from a Dropdown option
        /// <summary>
        /// this is to select from drop down menu by sending driver, the locator, its value and its type
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <param name="elementtype"></param>
        public void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementtype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
            if (elementtype == "XPath")
            {
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);

            }
        }
        #endregion
        #region to move mouse to an element
        public void MoveToElement(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementtype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
            if (elementtype == "XPath")
            {
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);

            }
        }
        #endregion
        #region to scroll on a page
        /// <summary>
        /// by using javascript this scrolls on a page till its end
        /// </summary>
        /// <param name="driver"></param>
        public void ScrollPage(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,  document.body.scrollHeight);");
        }
        #endregion
    }
}
