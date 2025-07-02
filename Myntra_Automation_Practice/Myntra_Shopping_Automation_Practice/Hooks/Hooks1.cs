using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Reqnroll;

namespace Myntra_Shopping_Automation_Practice.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver _driver;


        public IWebDriver IntializeDriver(string Browser)
        {
            switch (Browser.ToUpper())
            {
                case "CHROME":
                    _driver = new ChromeDriver();
                    break;
                case "IE":
                    _driver = new EdgeDriver();
                    break;
                case "FIREFOX":
                    _driver = new FirefoxDriver();
                    break;

                default: throw new ArgumentException("Invalid Browser Type Please check it");
            }
            _driver.Manage().Window.Maximize();
            return _driver;
        
    }


    }
}