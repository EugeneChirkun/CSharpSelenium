using CSharpSelenium.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
            PropertiesCollection.driver.FindElement(By.XPath("//button[@id='ez-accept-all']")).Click();
        }

        [TearDown]
        public void TearDown()
        {
            PropertiesCollection.driver.Quit();
            Console.WriteLine("Closed driver");
        }

        [Test]
        public void Test1()
        {
            //Init page
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.FirstName.SendKeys("Eugene");
            signUpForm.LastName.SendKeys("Chirkun");
            signUpForm.SubmitButton.Click();




            ////Continent
            //SeleniumSetMethods.SelectDropdown("continents", PropertyType.Id, "Europe");
            ////First name
            //SeleniumSetMethods.EnterText("firstname", "Eugene", PropertyType.Name);
            //Console.WriteLine("The value from Dropdown is: " + SeleniumGetMethods.GetTextFromDropDown("continents", PropertyType.Id));
            //Console.WriteLine("The value from First Name field is: " + SeleniumGetMethods.GetStringFromBox("firstname", PropertyType.Name));
            ////Button
            ////Implement waiter
            //SeleniumSetMethods.ClickElement("submit", PropertyType.Name);
        }

       
    }
}