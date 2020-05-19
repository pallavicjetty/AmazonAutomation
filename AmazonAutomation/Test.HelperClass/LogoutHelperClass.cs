using AmazonAutomation.UIPageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonAutomation.Test.HelperClass
{
    
    public class LogoutHelperClass
    {
        public void logOut()
        {
            signoutObject.homePageHamburger.ClickButton();
            
            WebDriverWait wait = new WebDriverWait(SeleniumDriver.driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("#hmenu-content > ul.hmenu.hmenu-visible > li:nth-child(27) > a")));
            
            signoutObject.SignOut.ClickButton();
            
        }

        #region logoutObjctInstantiate
        private LogoutPageObject _LogoutObjectHelper;
        public LogoutPageObject signoutObject
        {
            get { return _LogoutObjectHelper ?? (_LogoutObjectHelper = new LogoutPageObject()); }
        }
        #endregion
    }


}
