using AmazonAutomation.Test.HelperClass;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Threading;

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
            LoginHelperObject.loginUsingValidCredentials();
            
            Thread.Sleep(40000);
            
            Assert.AreEqual(SeleniumDriver.driver.Title, "Online Shopping site in India: Shop Online for " +
                "Mobiles, Books, Watches, Shoes and More - Amazon.in");
        }
        [Test]
        public void ContinueWithoutUserName()
        {
            string errorMessage=LoginHelperObject.loginWithNoCredential();
            Assert.AreEqual(errorMessage, "Enter your email or mobile phone number");
        }
        [Test]
        public void LoginWithInvalidUserName()
        {
            string invalidUserError=LoginHelperObject.loginWithInvalidCredential();
            Assert.IsNotNull(invalidUserError);
        }

        #region instantiateLogIn
        private LoginHelper _LoginHelperObject;
        public LoginHelper LoginHelperObject
        {
            get { return _LoginHelperObject ?? (_LoginHelperObject = new LoginHelper()); }
        }
        #endregion

    }
}
