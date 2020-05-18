using AmazonAutomation.UIPageObject;
using NUnit.Framework;
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
            Thread.Sleep(4000);
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
