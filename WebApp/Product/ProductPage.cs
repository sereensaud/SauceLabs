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
        ElementAction elementAction = new ElementAction();
        public void ClickOnProduct(IWebDriver driver)
        {
            elementAction.ClickItem(driver, add_to_cart_locator, elementtypeid);
        }

    }
}
