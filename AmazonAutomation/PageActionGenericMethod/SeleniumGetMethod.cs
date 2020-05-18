using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AmazonAutomation.PageAction
{
    public static class SeleniumGetMethod
    {

        //Text : takes inner text without whit space
        public static string GetTextFromThePage(this IWebElement element)
        {

            return element.Text;

        }
        //it takes the value we typed inside the text box   
        public static string GetText(this IWebElement element)
        {

            return element.GetAttribute("value");

        }
        //It is used to get the text from the dropdown what we have selected
        public static string GetTextFromDropdown(this IWebElement element)
        {

            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }
    }
}
