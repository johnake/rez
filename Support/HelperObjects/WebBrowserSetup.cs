using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace kpmg.Support.HelperObjects
{
    public class WebBrowserSetup
    {
        private static string abrowser;

        public WebBrowserSetup()
        {
            abrowser = ConfigurationManager.AppSettings["abrowser"];
        }

        public void StartWebBrowser()
        {
            switch (abrowser)
            {
                case "Firefox":
                    Driver.CurrentDriver = new FirefoxDriver();
                    break;
                case "Chrome":
                    Driver.CurrentDriver = new ChromeDriver();
                    break;
                default:
                    Console.WriteLine("Browser unsupported");
                    break;
            }
        }
    }
}
