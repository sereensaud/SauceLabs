using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    internal class ElementAction
    {
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


    }
}
