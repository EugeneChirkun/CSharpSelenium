using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium.Utils
{
    internal class SeleniumGetMethods
    {
        public static string GetStringFromBox(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDropDown(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
