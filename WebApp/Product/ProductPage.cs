using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabs
{
    public class ProductPage
    {
        ElementAction elementAction = new ElementAction();
        //-----------LOCATORS TYPE-------------------------------------------------------------//    
        string elementtypeid = "Id";
        string elementtypename = "Name";
        string elementtypeXpath = "XPath";
        //string elementtype = "Id";
        //string elementtype = "Id";
        //string elementtype = "Id";

        //------------LOCATORS VALUES AND THEIR KEYS---------------------------------------------------//
        By username_Locator = By.Id("user-name");
        string username_keys = "standard_user";

        By password_Locator = By.Id("password");
        string password_keys = "secret_sauce";
        By loginbutton_Locator = By.Id("login-button");


    }
}
