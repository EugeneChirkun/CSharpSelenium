using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium
{
    internal class SeleniumGetMethods
    {
        public static string GetStringFromBox(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }

        public static string GetTextFromDropDown(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }
    }
}
