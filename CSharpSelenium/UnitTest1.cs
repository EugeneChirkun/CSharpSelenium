using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpSelenium
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();
//          driver.FindElement(By.XPath("//button[@id='ez-accept-all']")).Click();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            Console.WriteLine("Closed driver");
        }

        [Test]
        public void Test1()
        {
            //Continent
            SeleniumSetMethods.SelectDropdown(driver, "continents", "Id", "Europe");
            //First name
            SeleniumSetMethods.EnterText(driver, "firstname", "Eugene", "Name");
            Console.WriteLine("The value from Dropdown is: " + SeleniumGetMethods.GetTextFromDropDown(driver, "continents", "Id"));
            Console.WriteLine("The value from First Name field is: " + SeleniumGetMethods.GetStringFromBox(driver, "firstname", "Name"));
            //Checkbox
            SeleniumSetMethods.ClickElement(driver, "submit", "Name");
        }

       
    }
}