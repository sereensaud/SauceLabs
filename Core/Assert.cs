using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class Asserts
    {
       // By username_Locator = By.ClassName("title");
    
        public void Verification(IWebDriver driver,string locatorval,string message)
        {

            string text = driver.FindElement(By.ClassName(locatorval)).Text;
            Assert.AreEqual(message, text);
            Console.WriteLine(text);
        }

   
    }
}
