using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AmazonAutomation.UIPageObject
{
    public class LogoutPageObject
    {
        public LogoutPageObject()
        {
            PageFactory.InitElements(SeleniumDriver.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@id='nav-hamburger-menu']")]
        public IWebElement homePageHamburger { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#hmenu-content > ul.hmenu.hmenu-visible > li:nth-child(27) > a")]
        public IWebElement SignOut { get; set; }
    }
    
}
