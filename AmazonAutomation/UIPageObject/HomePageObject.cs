using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.UIPageObject
{
    public class HomePageObject
    {
        public HomePageObject()
        {
            PageFactory.InitElements(SeleniumDriver.driver, this);
        }
        [FindsBy(How =How.XPath,Using = "//input[@id='twotabsearchtextbox']")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How =How.CssSelector,Using = "#nav-search > form > div.nav-right > div")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-action='a-dropdown-button']")]
        public IWebElement FeaturedDropdown { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[@id='s-result-sort-select_1']")]
        public IWebElement PriceLowToHighFeature { get; set; }

        [FindsBy(How=How.ClassName,Using = "a-dropdown-prompt")]
        public IWebElement PriceLowToHighText { get; set; }

        [FindsBy(How=How.XPath,Using = "//a[@id='s-result-sort-select_2']")]
        public IWebElement PriceHighToLowFeature { get; set; }

        [FindsBy(How=How.XPath,Using = "//*[@value='price-desc-rank']")]
        public IWebElement PriceHighToLowText { get; set; }

        [FindsBy(How=How.XPath,Using = "//a[@id='s-result-sort-select_3']")]
        public IWebElement AvgCustomerReviewFeature { get; set; }

        [FindsBy(How =How.XPath,Using = "//*[@value='review-rank']")]
        public IWebElement AvgCustomerReviewText { get; set; }

        [FindsBy(How=How.XPath,Using = "//a[@id='s-result-sort-select_4']")]
        public IWebElement NewestArrivals { get; set; }

        [FindsBy(How=How.XPath,Using = "//*[@value='date-desc-rank']")]
        public IWebElement NewestArrivalsText { get; set; }

    }
}
