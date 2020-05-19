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

        [FindsBy(How =How.PartialLinkText,Using = "Change country/region.")]
        public IWebElement CountryOrRegion { get; set; }

        [FindsBy(How=How.Id,Using = "a-autoid-0-announce")]
        public IWebElement SelectCountryDropdown { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#icp-selected-country_9 > div > div > div.a-fixed-left-grid-col.a-col-right")]
        public IWebElement Mexico { get; set; }

    }
}
