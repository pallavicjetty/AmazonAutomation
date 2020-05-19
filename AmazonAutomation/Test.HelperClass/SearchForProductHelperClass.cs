using AmazonAutomation.PageAction;
using AmazonAutomation.UIPageObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.Test.HelperClass
{
    public class SearchForProductHelperClass
    {
        public void searchForProduct()
        {
            string mobile = ConfigurationManager.AppSettings["mobile"];
            HomePageVariable.SearchBox.EnterText(mobile);
            HomePageVariable.SearchIcon.ClickButton();
            HomePageVariable.FeaturedDropdown.ClickButton();
        }
        public String searchForProductSortWithPriceLowToHigh()
        {
            searchForProduct();
            HomePageVariable.PriceLowToHighFeature.ClickButton();
            String LowToHighText=HomePageVariable.PriceLowToHighText.GetTextFromThePage();
            return LowToHighText;
        }
    
        public String searchForProductSortWithPriceHighToLow()
        {
            searchForProduct();
            HomePageVariable.PriceHighToLowFeature.ClickButton();
            String LowToHighText = HomePageVariable.PriceHighToLowText.GetTextFromThePage();
            return LowToHighText;
        }

        public String searchForProductSortWithAvgCustomerReview()
        {
            searchForProduct();
            HomePageVariable.AvgCustomerReviewFeature.ClickButton();
            String ReviewText = HomePageVariable.AvgCustomerReviewText.GetTextFromThePage();
            return ReviewText;
        }
        public String searchForProductSortWithNewestArrivals()
        {
            searchForProduct();
            HomePageVariable.NewestArrivals.ClickButton();
            String NewestArrival = HomePageVariable.NewestArrivalsText.GetTextFromThePage();
            return NewestArrival;
        }


        #region HomePageObjectInstantiate
        private HomePageObject _HomepageObject;
        public HomePageObject HomePageVariable
        {
            get { return _HomepageObject ?? (_HomepageObject = new HomePageObject()); }
        }
        #endregion
    }


}
