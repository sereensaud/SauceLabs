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
      

        public void screenshot(IWebDriver driver)


        {


            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot(); // takes the screenshot
            string ScreenShotName = @"D:\OneDrive - Constellation HomeBuilder Systems\VSprojects/Screenshot.png";
            image.SaveAsFile(ScreenShotName, ScreenshotImageFormat.Png);



        }
    }
}
