using HRMDEMO.Drivers;
using HRMDEMO.Helpers;
using HRMDEMO.MOdels;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace HRMDEMO
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks
        DriverHelper Helper;
        public Hooks1(DriverHelper driverHelper)

        {
            Helper = driverHelper;
        }

        [BeforeScenario()]
        public   void LaunchBrowser()
        {
          string  filepath = "C:\\Users\\Sairam_Ganisetti\\source\\repos\\HRMDEMO\\HRMDEMO\\JsonRequests\\json1.json";
         var jsondata =   PageBase.ReadJsonData<TestData>(filepath);
          //  var config = JsonHelper.ReadJsonData<Config>(filePath);
            Helper._driver = new ChromeDriver();
            Helper._driver.Navigate().GoToUrl(jsondata.Url);
            Helper._driver.Manage().Window.Maximize();
            
            
            
           
        }

       
    }
}