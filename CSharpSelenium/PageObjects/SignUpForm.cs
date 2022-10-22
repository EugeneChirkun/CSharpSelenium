using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpSelenium.PageObjects
{
    class SignUpForm
    {
        public SignUpForm()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy (How = How.Name, Using = "firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Name, Using = "continents")]
        public IWebElement ContinentsDropDown { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement SubmitButton { get; set; }
    }
}
