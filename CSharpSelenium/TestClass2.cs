using CSharpSelenium.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium
{
    internal class TestClass2
    {
        
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            PropertiesCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            PropertiesCollection.driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://demoqa.com/login");
            Console.WriteLine("Navigated to https://demoqa.com/login");

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
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
            LoginPageDemoQa loginPage = new LoginPageDemoQa(PropertiesCollection.driver);
            ProfilePageDemoQa profilePage = loginPage.Login("euser", "EuserPass!-123");
            //Thread.Sleep(5000);
            BookStoreDemoQa bookStore = profilePage.GoToStore();
            //Thread.Sleep(5000);
            bookStore.SearchBookInStore("It");

            Thread.Sleep(500);
        }
    }
}
