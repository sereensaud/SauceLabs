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
        //string username_keys = "standard_user";

        By password_Locator = By.Id("password");
       // string password_keys = "secret_sauce";
        By loginbutton_Locator = By.Id("login-button");

        string elementtypeid = "Id";
        string elementtypename = "Name";
        string elementtypeXpath = "XPath";
        string elementtypeclassname = "className";
        string elementtypecssselector = "cssSelector";
        string elementtypelinktext = "";
        string elementtypepartiallinktextt = "";
        string elementtypetagname = "tagName";
    }
}
