using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class Snapshots
    {
        #region screenshot and save it
        /// <summary>
        /// this takes the screenshot of the point where driver is and saves it
        /// </summary>
        /// <param name="driver"></param>
        public void screenshot(IWebDriver driver)


        {


            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot(); // takes the screenshot
            string ScreenShotName = @"D:\OneDrive - Constellation HomeBuilder Systems\VSprojects/Screenshot.png";
            image.SaveAsFile(ScreenShotName, ScreenshotImageFormat.Png);



        }
        #endregion
    }
}
