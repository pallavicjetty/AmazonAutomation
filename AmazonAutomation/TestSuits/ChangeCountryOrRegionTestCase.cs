using AmazonAutomation.Test.HelperClass;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.TestSuits
{
    [TestFixture]
    class ChangeCountryOrRegionTestCase
    {
        [Test]
        public void verifyUserCanChangeThergion()
        {
            LoginPageTestcase login = new LoginPageTestcase();
            login.OpenBrowserAndNavigateToAmazon();
            string text=ChangeCountryObject.verifyUserCanChangeRegion();
            Assert.IsNotNull(text);
        }
        #region SearchForProductHelperClassInstance
        private ChangeCountryOrRegionHelperClass _ChangeCountryOrRegionHelperClass;
        public ChangeCountryOrRegionHelperClass ChangeCountryObject
        {
            get { return _ChangeCountryOrRegionHelperClass ?? (_ChangeCountryOrRegionHelperClass = new ChangeCountryOrRegionHelperClass()); }
        }
        #endregion
    }
}
