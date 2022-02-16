using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class ProductTest
    {
        IWebDriver driver = null;
        // public string url;

        public ProductTest(IWebDriver driver2)
        {
            this.driver = driver2;
        }
        public void AddtoCart(string url, string user, string password)
        {
            driver.Url = url;
            LoginPage POMloginPage = new LoginPage();
            POMloginPage.EnterUserName(driver, user);
            POMloginPage.EnterPassword(driver, password);
            POMloginPage.ClickLogin(driver);
            ProductPage PomProductPage = new ProductPage();
            PomProductPage.ClickOnProduct(driver);


            Asserts POMassert = new Asserts();
            POMassert.Verification(driver, "shopping_cart_badge", "1");
           
            Snapshots POMsnapshots = new Snapshots();
            POMsnapshots.screenshot(driver);

        }
    }
}
