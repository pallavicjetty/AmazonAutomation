using AmazonAutomation.Test.HelperClass;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.TestSuits
{
    public class SearchForProductTestCase
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
        public void SearchForMobileSortWithPriceLowToHigh()
        {
            string LowToHighText=SearchProduct.searchForProductSortWithPriceLowToHigh();
            Assert.AreEqual(LowToHighText, "Price: Low to High");
        }

        [Test]
        public void SearchForMobileSortWithPriceHighToLow()
        {
            string HighToLowText = SearchProduct.searchForProductSortWithPriceHighToLow();
            Assert.AreEqual(HighToLowText, "Price: High to Low");
        }

        [Test]
        public void SearchForMobileSortWithCustomerReview()
        {
            string ReviewText = SearchProduct.searchForProductSortWithAvgCustomerReview();
            Assert.AreEqual(ReviewText, "Avg. Customer Review");
        }

        [Test]
        public void SearchForMobileSortWithNewestArrival()
        {
            string NewestArrival = SearchProduct.searchForProductSortWithNewestArrivals();
            Assert.AreEqual(NewestArrival, "Newest Arrivals");
        }

        #region SearchForProductHelperClassInstance
        private SearchForProductHelperClass _SearchForProductHelperClass;
        public SearchForProductHelperClass SearchProduct
        {
            get { return _SearchForProductHelperClass ?? (_SearchForProductHelperClass = new SearchForProductHelperClass()); }
        }
        #endregion
    }
}
