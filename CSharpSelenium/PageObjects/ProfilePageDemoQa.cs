using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpSelenium.PageObjects
{
    internal class ProfilePageDemoQa
    {       
        private readonly IWebDriver _driver;

        public ProfilePageDemoQa(IWebDriver driver) => _driver = driver;

        IWebElement txtSearch => _driver.FindElement(By.Id("searchBox"));
        IWebElement btnLogOut => _driver.FindElement(By.Id("submit"));
        IWebElement btnGoToStore => _driver.FindElement(By.Id("gotoStore"));
        IWebElement tableBooks => _driver.FindElement(By.XPath("//*[@class = 'rt-table']"));

        public void SearchBook(string bookTitle)
        {
            txtSearch.SendKeys(bookTitle);
        }

        public BookStoreDemoQa GoToStore()
        {
            btnGoToStore.Click();

            return new BookStoreDemoQa(_driver);
        }
    }
}
