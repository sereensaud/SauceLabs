using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public partial class ProductPage
    {
        #region Preliminaries
        ElementAction elementAction = new ElementAction();
        #endregion
        #region Click on the Product to Add in the cart
        /// <summary>
        /// this methods add product to the cart
        /// </summary>
        /// <param name="driver"></param>
        public void ClickOnProduct(IWebDriver driver)
        {
            elementAction.ClickItem(driver, add_to_cart_locator, elementtypeid);
        }
        #endregion

    }
}
