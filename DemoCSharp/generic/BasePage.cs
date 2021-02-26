using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharp.generic
{
    public static class BasePage
    {

        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

        //Get Methods

        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //Get text from a dropdown input
        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

    }
}
