using OpenQA.Selenium;

namespace CSharpSelenium
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    internal class PropertiesCollection
    {
        
        //Auto-implemented property
        public static IWebDriver driver{ get; set; }
    }
}
