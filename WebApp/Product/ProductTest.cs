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
        #region Preliminaries
        IWebDriver driver = null;
      

        public ProductTest(IWebDriver driver2)
        {
            this.driver = driver2;
        }
        #endregion
        #region adding to the cart test
        public void AddtoCart(string url, string user, string password)
        {
            #region loging in
            driver.Url = url;
            LoginPage POMloginPage = new LoginPage();
            POMloginPage.EnterUserName(driver, user);
            POMloginPage.EnterPassword(driver, password);
            POMloginPage.ClickLogin(driver);
            #endregion
            #region clicking on product to add in the cart
            ProductPage PomProductPage = new ProductPage();
            PomProductPage.ClickOnProduct(driver);
            #endregion
            #region verify if the product is the one added in the cart or not

            Asserts POMassert = new Asserts();
            POMassert.Verification(driver, "shopping_cart_badge", "1");
            #endregion
            #region screenshot 
            Snapshots POMsnapshots = new Snapshots();
            POMsnapshots.screenshot(driver);
            #endregion
        }
        #endregion
    }
}
