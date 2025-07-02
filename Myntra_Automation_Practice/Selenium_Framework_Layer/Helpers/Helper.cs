using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AutoIt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Framework_Layer.Helpers
{
    public class Helper
    {
        IWebDriver _driver;
        WebDriverWait wait;
        public Helper(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        public IWebElement GetWebElement(By Locator)
        {
          return  wait.Until(ExpectedConditions.ElementIsVisible(Locator));
           
        }
        public void MouseHoverHelper(IWebDriver driver,IWebElement element)
        {
            Actions act = new Actions(driver);
            act.MoveToElement(element).Perform();
            

        }
        public void Scroll_ClickByUsingJavaScriptExecutor(IWebElement element)
        {
            //  ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", h.GetWebElement(AddToCart_btn));
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
           

        }

        public void ElementToBeClickable(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        public void ScrollByusigAction(IWebDriver driver,IWebElement element)
        {
            Actions act = new Actions(driver);
            act.MoveToElement(element);
            act.Click(element).Perform();
        }
        public void ClickElementUsingJavaScript(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // Click the element using JavaScript
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            js.ExecuteScript("arguments[0].click();", element);
        }
        public static string CaptureScreenshot(IWebDriver driver, string screenshotName)
        {
            // Create a folder to store the screenshots
            string screenshotPath = Path.Combine(Directory.GetParent(@"../../../").FullName, "Screenshots");
            Directory.CreateDirectory(screenshotPath); // Ensure the directory exists

            // Capture screenshot using Selenium
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            // Save the screenshot with the provided name
            string screenshotFile = Path.Combine(screenshotPath, screenshotName + ".png");
            screenshot.SaveAsFile(screenshotFile);

            return screenshotFile; // Return the path of the screenshot
        }
        public static void AutoITHelper()
        {
            
        }
    }
}
