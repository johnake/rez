using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace kpmg.Support.HelperObjects
{
    public static class WebDriverExtensions
    {
        internal static bool WaitUntilDisplayed(this IWebDriver webDriver, IWebElement element, int time = 10)
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(time)).Until(driver => element.Displayed);
        }

        internal static bool WaitUntilNotDisplayed(this IWebDriver webDriver, IWebElement element, int time = 10)
        {
            try
            {
                return !new WebDriverWait(webDriver, TimeSpan.FromSeconds(time)).Until(driver => element.Displayed);
            }
            catch (Exception e)
            {
                if (e.InnerException is StaleElementReferenceException || e.InnerException is NoSuchElementException ||
                    e.InnerException is WebDriverTimeoutException || e is WebDriverTimeoutException)
                    return true;
                throw;
            }
        }
    }
}
