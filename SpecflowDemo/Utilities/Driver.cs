using OpenQA.Selenium.Chrome;
using SpecflowDemo.BusinessFunctions;
using SpecflowDemo.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Utilities
{
    [Binding]
    public sealed class Driver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //implement logic that has to run before executing each scenario
            String url = LoginData.URL;
            CommonConstants.driver.LaunchBrowser(url);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            CommonConstants.driver.CloseWebDriver();//Close and quit the web driver
        }
    }
}
