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
        #region Locators for Product
        By add_to_cart_locator = By.Id("add-to-cart-sauce-labs-backpack");
        #endregion
        #region Locators type
        string elementtypeid = "Id";
        string elementtypename = "name";
        string elementtypexpath = "xpath"; //xpath uses the xml expression to locate an element on the webpage. b=by.xpath("//tag_name[@attribute_value]") by.xpath("//input[@id='username']");
        string elementtypeclassname = "classname";
        string elementtypecssselector = "cssselector";//<input autocomplete="off" placeholder="full name" type="text" id="username" class=" mr-sm-2 form-control"> so, by.cssselector("input[id= ‘username’]");
        string elementtypelinktext = "linktext"; //<a id="simplelink" href="https://www.demoqa.com" target="_blank">home</a> so, by.linktext("home");
        string elementtypepartiallinktextt = "partiallinktext"; // partial link text can also recognize the element by using part of the hyperlink text, as shown by.partiallinktext("ho");
        string elementtypetagname = "tagname"; //by.partiallinktext("ho");
        #endregion

    }
}
