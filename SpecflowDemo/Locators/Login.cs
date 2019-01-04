using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowDemo.BusinessFunctions;
using SpecflowDemo.TestData;
using SpecflowDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowDemo.Locators
{
    class Login
    {
        private IWebDriver driver;
        
        private IWebElement UserName
        {
            get { return driver.FindWebElement(By.CssSelector("input[name='email']")); }
        }

        private IWebElement Password
        {
            get { return driver.FindWebElement(By.CssSelector("input[name='password']")); }
        }

        private IWebElement LoginButton
        {
            get { return driver.FindWebElement(By.CssSelector("button > span.ladda-label")); }
        }

        private IWebElement SideBarDashboard
        {
            get { return driver.FindWebElement(By.CssSelector("#social-sidebar-menu > li > a > strong")); }
        }


        public Login(IWebDriver driver)
        {
            this.driver = CommonConstants.driver;
            //SeleniumSupport.InitElements(driver, this);
        }

        public void EnterLoginDetails()
        {
            UserName.SendKeys(LoginData.UserName);
            Password.SendKeys(LoginData.PassWord);           

        }

        public void ClickLoginButton()
        {
            LoginButton.Click();

        }

        public bool IsDashboardExists()
        {
            
            return (SideBarDashboard.Displayed);
        }

    }
}
