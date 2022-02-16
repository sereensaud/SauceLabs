using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public partial class LoginPage

    {
        By username_Locator = By.Id("user-name");
        By password_Locator = By.Id("password");
        By loginbutton_Locator = By.Id("login-button");

        string elementtypeid = "Id";
        string elementtypename = "Name";
        string elementtypeXpath = "xpath"; //XPath uses the XML expression to locate an element on the webpage. b=By.xpath("//tag_name[@attribute_value]") By.xpath("//input[@id='userName']");
        string elementtypeclassname = "className";
        string elementtypecssselector = "cssSelector";//<input autocomplete="off" placeholder="Full Name" type="text" id="userName" class=" mr-sm-2 form-control"> SO, By.cssSelector("input[id= ‘userName’]");
        string elementtypelinktext = "LinkText"; //<a id="simpleLink" href="https://www.demoqa.com" target="_blank">Home</a> SO, By.linkText("Home");
        string elementtypepartiallinktextt = "PartialLinkText"; // partial link text can also recognize the element by using part of the hyperlink text, as shown By.partialLinkText("Ho");
        string elementtypetagname = "tagName"; //By.partialLinkText("Ho");
    }
}
