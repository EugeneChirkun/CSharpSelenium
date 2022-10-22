using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium
{
    internal class SeleniumGetMethods
    {
        public static string GetStringFromBox(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }

        public static string GetTextFromDropDown(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }
    }
}
