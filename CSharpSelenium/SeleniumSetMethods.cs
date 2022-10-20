using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium
{
    internal class SeleniumSetMethods
    {
        //Enter text method
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
            driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Perform click
        public static void ClickElement(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }
        //Select a dropdown control
        public static void SelectDropdown(IWebDriver driver, string element, string elementType, string value)
        {
            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
