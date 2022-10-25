using CSharpSelenium.PageObjects;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.ToWorkOnIt
{
    public class TestTable
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
            PropertiesCollection.driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(5));
            PropertiesCollection.driver.Manage().Timeouts().AsynchronousJavaScript.Add(TimeSpan.FromSeconds(5));

            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://demoqa.com/login");
            Console.WriteLine("Navigated to https://demoqa.com/login");
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        [TearDown]
        public void TearDown()
        {
            PropertiesCollection.driver.Quit();
            Console.WriteLine("Closed driver");
        }

        //[Test]
        public void FirstTableTest()
        {
            LoginPageDemoQa loginPage = new LoginPageDemoQa(PropertiesCollection.driver);
            ProfilePageDemoQa profilePage = loginPage.Login("euser", "EuserPass!-123");
            Thread.Sleep(5000);
            BookStoreDemoQa bookStore = profilePage.GoToStore();
            Thread.Sleep(5000);
            bookStore.SearchBookInStore("It");
            TableUtils.ReadTable(bookStore.tableBooks);
            Thread.Sleep(5000);
            var fromTable = TableUtils.ReadCell("Author", 1);
            Thread.Sleep(5000);
            Console.WriteLine("Output" + fromTable);
            Thread.Sleep(50000);
        }
    }
}
