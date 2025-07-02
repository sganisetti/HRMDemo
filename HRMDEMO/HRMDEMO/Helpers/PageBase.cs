using HRMDEMO.Drivers;
using HRMDEMO.MOdels;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDEMO.Helpers
{
    public class PageBase : DriverHelper
    {
        DriverHelper _driverhelper;
        WebDriverWait wait;
        public PageBase(DriverHelper driverhelper)
        {
            _driverhelper = driverhelper;
            wait = new WebDriverWait(_driverhelper._driver,TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromSeconds(10);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException),typeof(ElementClickInterceptedException),typeof(StaleElementReferenceException));
          // this._driverhelper = driverhelper;

        }
        public  IWebElement GetWebElement(By by)
        {
            try
            {
                return wait.Until(ExpectedConditions.ElementExists(by));
            }
            catch (Exception exception)
            {
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
                return _driverhelper._driver.FindElement(by);
            }

            
        }

        public static T ReadJsonData<T>(string path) 
        {
           var data =  File.ReadAllText(path);
          return  JsonConvert.DeserializeObject<T>(data);
        }
    }
}
