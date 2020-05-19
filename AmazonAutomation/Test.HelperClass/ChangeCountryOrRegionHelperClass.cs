using AmazonAutomation.PageAction;
using AmazonAutomation.UIPageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.Test.HelperClass
{
    class ChangeCountryOrRegionHelperClass
    {
        public String verifyUserCanChangeRegion()
        {
            ChangeCountryOrRegionObject.ChangeCountryOrRegionDropdown.MouseHover();

            WebDriverWait wait = new WebDriverWait(SeleniumDriver.driver, TimeSpan.FromSeconds(4));
            wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText("Change country/region.")));

            ChangeCountryOrRegionObject.CountryOrRegion.ClickButton();
            ChangeCountryOrRegionObject.SelectCountryDropdown.ClickButton();
            ChangeCountryOrRegionObject.Mexico.ClickButton();
            string returnText = ChangeCountryOrRegionObject.Mexico.Text;
            return returnText;
        }


        #region ChangeCountryOrRegionObjectIntantiate
        private ChangeCountryOrRegionPageObject _ChangeCountryOrRegionObject;
        public ChangeCountryOrRegionPageObject ChangeCountryOrRegionObject
        {
            get { return _ChangeCountryOrRegionObject ?? (_ChangeCountryOrRegionObject = new ChangeCountryOrRegionPageObject()); }
        }
        #endregion
    }
}
