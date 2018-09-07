using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Configuration;
using SeleniumExtras.PageObjects;

namespace kpmg.Pages
{
    public class Homepage
    {
        private static IWebDriver _driver;

        private static string _url = ConfigurationManager.AppSettings["SiteUrl"];
        public Homepage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(_url);
            PageFactory.InitElements(_driver, this);
        }
    }
}
