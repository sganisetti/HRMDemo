using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRunner.Support
{
    public class BaseDriver
    {
        protected IWebDriver Driver;
        ScenarioContext _scenarioContext;
        public BaseDriver(ScenarioContext scenariocontext)
        {
            this._scenarioContext = scenariocontext;
            Driver = _scenarioContext.Get<IWebDriver>("WebDriver");
        }
    } 
}
