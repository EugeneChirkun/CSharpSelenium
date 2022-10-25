using OpenQA.Selenium;

namespace CSharpSelenium.PageObjects
{
    internal class LoginPageDemoQa
    {
        ////euser
        ////EuserPass!-123

        private readonly IWebDriver _driver;

        public LoginPageDemoQa(IWebDriver driver) => _driver = PropertiesCollection.driver;

        IWebElement txtUserName => _driver.FindElement(By.Id("userName"));
        IWebElement txtPassword => _driver.FindElement(By.Id("password"));
        IWebElement btnLogin => _driver.FindElement(By.Id("login"));

        public ProfilePageDemoQa Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();

            return new ProfilePageDemoQa(_driver);
        }
    }
}
