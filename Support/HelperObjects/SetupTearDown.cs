using System;
using System.IO;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Configuration;

namespace kpmg.Support.HelperObjects
{
    [Binding]
    public class SetupTearDown
    {
        private static readonly string TestScreenshotFolder = ConfigurationManager.AppSettings["TestErrorScreenshots"];

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebBrowserSetup ws = new WebBrowserSetup();
            ws.StartWebBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                // This means an error has occured
                var screenshot = ((ITakesScreenshot)Driver.CurrentDriver).GetScreenshot();
                screenshot.SaveAsFile(Path.Combine(TestScreenshotFolder, Environment.MachineName + "_" + ScenarioContext.Current.ScenarioInfo.Title + ".png"), ScreenshotImageFormat.Png);
            }

            Driver.CurrentDriver.Quit();
        }
    }
}
