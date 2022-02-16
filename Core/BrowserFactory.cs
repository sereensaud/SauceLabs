using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class Factory
    {
        public IWebDriver driver;
        public void BrowserFactory(String browsername, string browsertype)
        {
            if (browsername.Equals("Chrome"))
            {
                if (browsertype.Equals("default"))
                {
                    driver = new ChromeDriver();
                }
                else if (browsertype.Equals("headless"))
                {
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("headless");



                    driver = new ChromeDriver(chromeOptions);
                }
                driver.Manage().Window.Maximize();
                driver.Manage().Cookies.DeleteAllCookies();
            }
            else if (browsername.Equals("Edge"))
            {
                if (browsertype.Equals("default"))
                {
                    driver = new EdgeDriver();
                }
                else if (browsertype.Equals("headless"))
                {
                    var edgeOptions = new EdgeOptions();
                    edgeOptions.AddArguments("headless");



                    driver = new EdgeDriver(edgeOptions);
                }
                driver.Manage().Window.Size = new Size(1920, 1080);
                driver.Manage().Cookies.DeleteAllCookies();
            }
            else if (browsername.Equals("Firefox"))
            {
                if (browsertype.Equals("default"))
                {
                    driver = new FirefoxDriver();
                }
                else if (browsertype.Equals("headless"))
                {
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArguments("headless");



                    driver = new FirefoxDriver(firefoxOptions);
                }
                driver.Manage().Window.Size = new Size(1920, 1080);
                driver.Manage().Cookies.DeleteAllCookies();
            }
        }
    }
}
