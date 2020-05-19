using AmazonAutomation.Test.HelperClass;
using AmazonAutomation.UIPageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.TestSuits
{
    public class UserLogoutTestCase
    {
        [Test]
        public void logout()
        {
            LoginPageTestcase login = new LoginPageTestcase();
            login.OpenBrowserAndNavigateToAmazon();
            login.AmazonLoginWithValidUserNameAndPassword();
            LogoutHelper.logOut();
            Assert.AreEqual(SeleniumDriver.driver.Title, "Amazon Sign In");

        }
        #region instantiateLogout
        private LogoutHelperClass _LogoutHelper;
        public LogoutHelperClass LogoutHelper
        {
            get { return _LogoutHelper ?? (_LogoutHelper = new LogoutHelperClass()); }
        }
        #endregion


    }
}
