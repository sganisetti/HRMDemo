using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Gherkin.CucumberMessages.Types;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Reqnroll;
using Selenium_Framework_Layer.Helpers;
using TestRunner.Support;

namespace TestRunner.Hooks
{
    [Binding]
    public sealed class Hooks1 
    {
        public IWebDriver _driver;
        ScenarioContext _scenarioContext;
        static string _reportingpath = System.IO.Directory.GetParent(@"../../../").FullName
        + Path.DirectorySeparatorChar +"TestReports"+Path.DirectorySeparatorChar+"_Results"+DateTime.Now.ToString("F");
        static AventStack.ExtentReports.ExtentReports _extentReports;
        static AventStack.ExtentReports.ExtentTest _feature;
        AventStack.ExtentReports.ExtentTest _scenario, _step;
       
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks
        public Hooks1(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;

        }

        [BeforeScenario (Order = 0)]
        public void Intializebrowser()
        {
            var brosertypeandurl = ReadJsonData();
            switch (brosertypeandurl.Browser.ToUpper())
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
            _driver.Navigate().GoToUrl(brosertypeandurl.Url);
            AddDriverToScenarioContext(_driver);
            //  return _driver;

        }
        public BrowserandUrl ReadJsonData()
        {

            string relativePath = "UrlAndBrowser.json";
            // string filepath =  Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            string filepath = File.ReadAllText("C:\\Users\\Sairam_Ganisetti\\source\\repos\\Myntra_Automation_Practice\\ReqnrollProject1\\Support\\UrlAndBrowser.json");
            return JsonConvert.DeserializeObject<BrowserandUrl>(filepath);

        }
        public void AddDriverToScenarioContext(IWebDriver driver)
        {
            _scenarioContext.Set(driver, "WebDriver");
        }

       
        [BeforeTestRun]
        public static void AttachReports()
        {
            ExtentHtmlReporter _extentHtmlReporter  = new ExtentHtmlReporter(_reportingpath);
            _extentReports = new AventStack.ExtentReports.ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }
        [BeforeFeature]
        public static void FeatureTitla(FeatureContext context)
        {
            _feature = _extentReports.CreateTest(context.FeatureInfo.Title);
        }
        [BeforeScenario (Order = 1)]
        public void ScenarioTitle(ScenarioContext context)
        {
            _scenario = _feature.CreateNode(context.ScenarioInfo.Title);
        }
        [BeforeStep]
        public void BeforeStep()
        {
            _step = _scenario;
        }
        //[AfterStep]
        //public void AfterStep(ScenarioContext context)
        //{
        //    string screenshotPath = Helper.CaptureScreenshot(_driver, "TestReportScreenshot");
        //    if (context.TestError == null)
        //    {
        //        _step.Log(Status.Pass, context.StepContext.StepInfo.Text);
        //    }
        //    else if (context.TestError != null)
        //    {
        //        _step.Log(Status.Fail, context.StepContext.StepInfo.Text).AddScreenCaptureFromPath(screenshotPath);
        //    }
        //    // try to diplay TestScenario Name and and where it fails
        //}




        [AfterStep]
        public void InsertReportingSteps()
        {
            // Log each step based on its status
            if (_scenarioContext.TestError == null)
            {
                _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass("Step passed");
            }
            else
            {
                // If the step failed, capture a screenshot and log it
                string screenshotPath = Helper.CaptureScreenshot(_driver, _scenarioContext.ScenarioInfo.Title + "_Error");
                _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text)
                         .Fail(_scenarioContext.TestError.Message)
                         .AddScreenCaptureFromPath(screenshotPath);
            }
        }

        [AfterFeature]
        public static void Flush_Report()
        {
            _extentReports.Flush();
        }


      

    }


}