using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpSelenium.PageObjects
{
    internal class BookStoreDemoQa
    {
        private readonly IWebDriver _driver;

        public BookStoreDemoQa(IWebDriver driver) => _driver = driver;

        IWebElement txtSearch => _driver.FindElement(By.Id("searchBox"));
        public IWebElement tableBooks => _driver.FindElement(By.XPath("//*[@role = 'grid']"));


        public void SearchBookInStore(string bookTitle)
        {
            txtSearch.SendKeys(bookTitle);
        }

    }
}
