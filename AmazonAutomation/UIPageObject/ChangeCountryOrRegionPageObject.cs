using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.UIPageObject
{
    public class ChangeCountryOrRegionPageObject
    {
        public ChangeCountryOrRegionPageObject()
        {
            PageFactory.InitElements(SeleniumDriver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#icp-nav-flyout > span > span.nav-line-2 > span")]
        public IWebElement ChangeCountryOrRegionDropdown { get; set; }

    }
}
