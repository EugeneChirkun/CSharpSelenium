using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium.Utils
{
    internal class SeleniumSetMethods
    {
        //Enter text method
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Perform click
        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }
        //Select a dropdown control
        public static void SelectDropdownByText(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
