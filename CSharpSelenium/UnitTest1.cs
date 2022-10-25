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

            PropertiesCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
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
            SignUpFormTechListic signUpForm = new SignUpFormTechListic(PropertiesCollection.driver);
            signUpForm.EnterFirstName("Eugene");
            signUpForm.EnterLasttName("Chirkun");
            signUpForm.ClickSubmit();
        }
    }
}