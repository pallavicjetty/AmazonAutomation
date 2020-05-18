using AmazonAutomation.PageAction;
using AmazonAutomation.PageObject;
using AmazonAutomation.Test.HelperClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonAutomation.TestSuits
{
    [TestFixture]
    public class LoginPageTestcase
    {
        [SetUp]
        public void OpenBrowserAndNavigateToAmazon()
        {
            var url = ConfigurationManager.AppSettings["URL"];
            SeleniumDriver.driver = new ChromeDriver();
            SeleniumDriver.driver.Navigate().GoToUrl(url);
            SeleniumDriver.driver.Manage().Window.Maximize();
            string pageTitle = SeleniumDriver.driver.Title;
            Assert.AreEqual(pageTitle, "Online Shopping site in India: Shop Online for " +
                "Mobiles, Books, Watches, Shoes and More - Amazon.in");
        }

        [Test]
        public void AmazonLoginWithValidUserNameAndPassword()
        {
            LoginHelper.loginUsingValidCredentials();
            //WebDriverWait wait = new WebDriverWait(SeleniumDriver.driver,20);
            Thread.Sleep(40000);
            //SeleniumDriver.driver.Manage().Timeouts().ImplicitWait(10, TimeUnit.SECONDS);
            Assert.AreEqual(SeleniumDriver.driver.Title, "Online Shopping site in India: Shop Online for " +
                "Mobiles, Books, Watches, Shoes and More - Amazon.in");
        }
        [Test]
        public void ContinueWithoutUserName()
        {
            LoginHelper.loginWithNoCredential();
            string errorMessage = LoginHelper.continueErrorMessage.GetTextFromThePage();
            Assert.AreEqual(errorMessage, "Enter your email or mobile phone number");
        }
        [Test]
        public void LoginWithInvalidUserName()
        {
            LoginHelper.loginWithInvalidCredential();
            string invalidUsernameError = LoginHelper.invalidUserNameErrorMessage.GetTextFromThePage();
            Assert.IsNotNull(invalidUsernameError);
        }
        
        #region instantiate
        private LoginPageObject _LoginHelper;
        
        public LoginPageObject LoginHelper
        {
            get { return _LoginHelper ?? (_LoginHelper = new LoginPageObject()); }
        }
        #endregion

    }
}
