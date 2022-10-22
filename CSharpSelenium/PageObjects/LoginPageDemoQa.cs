using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.PageObjects
{
    internal class LoginPageDemoQa
    {
        public LoginPageDemoQa()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //euser
        //EuserPass!-123

        [FindsBy (How = How.Id, Using = "userName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginButton { get; set; }
    }
}
