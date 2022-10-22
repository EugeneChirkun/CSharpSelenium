using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium
{
    internal class SeleniumSetMethods
    {
        //Enter text method
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Perform click
        public static void ClickElement(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }
        //Select a dropdown control
        public static void SelectDropdown(string element, PropertyType elementType, string value)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
