using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecflowDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowDemo.BusinessFunctions
{
    public static class BrowserUtils
    {
        public static void LaunchBrowser(this IWebDriver driver, string _url)
        {
            var chromeOptions = new ChromeOptions();
            var chromeDriverService = ChromeDriverService.CreateDefaultService();

            switch (ConfigurationManager.AppSettings["Browser"])
            {
                case "CHROME":
                    //chromeOptions.AddArguments(new List<string>() { "headless" });                    
                    CommonConstants.driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriverPath"], chromeOptions);
                    CommonConstants.driver.Navigate().GoToUrl(_url);
                    CommonConstants.driver.Manage().Window.Maximize();
                    break;
                case "FIREFOX":
                    break;
                case "IE":
                    break;
                default:
                    
                    //chromeOptions.AddArguments(new List<string>() { "headless" });                    
                    CommonConstants.driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriverPath"], chromeOptions);
                    CommonConstants.driver.Navigate().GoToUrl(_url);
                    CommonConstants.driver.Manage().Window.Maximize();
                    break;
            }
        }

        public static void CloseWebDriver(this IWebDriver driver)
        {
            if (CommonConstants.driver != null)
            {
                CommonConstants.driver.Close();
                CommonConstants.driver.Quit();
            }
        }

        public static IWebElement FindWebElement(this IWebDriver driver, By _by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(CommonConstants.driver, new TimeSpan(0, 0, CommonConstants.TIMEOUTSECONDS));
                wait.Until(drv => drv.FindElement(_by));                
                return (driver.FindElement(_by));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
                
            }
        }
    }
}
