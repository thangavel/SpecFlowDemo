using NUnit.Framework;
using SpecflowDemo.Locators;
using SpecflowDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemo.StepDefs
{
   
    [Binding]
    public sealed class PHPTravelAdminSteps
    {
        Login _login = new Login(CommonConstants.driver);
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I have already opened the Admin application")]
        public void GivenIHaveAlreadyOpenedTheAdminApplication()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered valid credentials")]
        public void GivenIHaveEnteredValidCredentials()
        {
            //ScenarioContext.Current.Pending();
            _login.EnterLoginDetails();
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            //ScenarioContext.Current.Pending();
            _login.ClickLoginButton();

        }

        [Then(@"I should see the admin dashboard screen")]
        public void ThenIShouldSeeTheAdminDashboardScreen()
        {
            Assert.IsTrue(_login.IsDashboardExists(),"Dashboard Does not exists/ Not Loaded");
            
        }

    }
}
