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
        #region Assertion on the basis of equal value comparison
        /// <summary>
        /// this method compares the expected value with actual value
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locatorval"></param>
        /// <param name="message"></param>
        public void Verification(IWebDriver driver,string locatorval,string message)
        {

            string text = driver.FindElement(By.ClassName(locatorval)).Text;
            Assert.AreEqual(message, text);
            Console.WriteLine(text);
        }
        #endregion

    }
}
