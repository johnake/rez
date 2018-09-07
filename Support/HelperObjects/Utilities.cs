using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace kpmg.Support.HelperObjects
{
    public class Utilities
    {
        public static void SelectFromDropdown(IWebElement element, string value)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByValue(value);
        }
    }
}
