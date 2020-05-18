using AmazonAutomation.Test.HelperClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AmazonAutomation.UIPageObject
{
    public class LoginPageObject 
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(SeleniumDriver.driver, this);
        }


        [FindsBy(How =How.CssSelector,Using = "#nav-link-accountList > span.nav-line-2 > span")]
        public IWebElement clickOnLogin { get; set; }

        [FindsBy(How =How.XPath,Using = "//*[@id='ap_email']")]
        public IWebElement userNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='continue']")]
        public IWebElement continueButton { get; set; }

        [FindsBy(How=How.XPath,Using = "//input[@id='ap_password']")]
        public IWebElement passwordTextbox { get; set; }

        [FindsBy(How=How.XPath,Using = "//input[@id='signInSubmit']")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How=How.XPath,Using = "//div[@id='auth-email-missing-alert']")]
        public IWebElement continueErrorMessage { get; set; }

        [FindsBy(How = How.ClassName, Using = "a-alert-heading")]
        public IWebElement invalidUserNameErrorMessage { get; set; }
    }
}
