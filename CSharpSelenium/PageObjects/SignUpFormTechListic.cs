using OpenQA.Selenium;

namespace CSharpSelenium.PageObjects
{
    class SignUpFormTechListic
    {
        private readonly IWebDriver _driver;
        public SignUpFormTechListic(IWebDriver driver) => _driver = driver;

        IWebElement txtFirstName => _driver.FindElement(By.Name("firstname"));
        IWebElement txtLastName => _driver.FindElement(By.Name("lastname"));
        IWebElement ddlContinents => _driver.FindElement(By.Name("continents"));
        IWebElement btnSubmit => _driver.FindElement(By.Name("submit"));

        public void EnterFirstName(string firstName)
        {
            txtFirstName.SendKeys(firstName);
        }

        public void EnterLasttName(string lastName)
        {
            txtLastName.SendKeys(lastName);
        }

        public void ClickSubmit()
        {
            btnSubmit.Click();
        }
    }
}
