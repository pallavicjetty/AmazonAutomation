using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation
{
    public static class SeleniumSetMethod
    {
        //MouseHover
        public static void MouseHover(this IWebElement element)
        {
            Actions actions = new Actions(SeleniumDriver.driver);
            actions.MoveToElement(element).Build().Perform();
        }
        //Enter the text inside the textbox
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        //Click into button,checkbox, option etc
        public static void ClickButton(this IWebElement element)
        {
            element.Click();
        }

        //Selecting dropdown control
        public static void selectDropdown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
