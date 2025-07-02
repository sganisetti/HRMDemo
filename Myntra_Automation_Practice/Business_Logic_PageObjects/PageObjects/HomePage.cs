using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.WebAuthn;
using Selenium_Framework_Layer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_PageObjects.PageObjects
{
    public class HomePage 
    {
        IWebDriver _driver;
        Helper help;
        public HomePage(IWebDriver driver)
        {

           this. _driver = driver;
            help = new Helper(_driver);

        }
        By Ajio_HomePage_Verify = By.XPath("//span[text()='MEN']");
        By Hover_On_Men = By.XPath("//span[@aria-label='MEN']");
        By Click_on_Jackets = By.XPath("//a[@title='Jackets & Coats']");
        By Clickon_Product = By.XPath("//div[@class='443004374004']");
        By Valdate_Price = By.XPath("//div[contains(text(),'₹799')]");
        By Click_on_Select_size = By.XPath("//span[text()='XL']");
        By AddToBag_Btn = By.XPath("//span[text()='ADD TO BAG']");
        By Click_on_Bag = By.XPath("//a[@aria-label='cart icon']");
        By Verifiy_Shipping = By.XPath("//button[text()='Proceed to shipping']");


        public void Validate_Home_Page(string Actual)
        {
           string Expected = help.GetWebElement(Ajio_HomePage_Verify).Text;
            Assert.AreEqual(Expected, Actual);
        }
        public void Hovering_On_Mens_Section()
        {
            help.MouseHoverHelper(_driver, help.GetWebElement(Hover_On_Men));

        }

        public void Click_On_JacketsandCoates()
        {
            help.GetWebElement(Click_on_Jackets).Click();
        }
        public void ClickonProduct()
        {
           // help.ScrollByusigAction(_driver,help.GetWebElement(Clickon_Product));
            help.ClickElementUsingJavaScript(_driver,help.GetWebElement(Clickon_Product));
           // help.GetWebElement(Clickon_Product).Click();

        }
        public void Verifyingprice(string Actual)
        {
          string parent =  _driver.CurrentWindowHandle;
        IList<string> Allwindows =  _driver.WindowHandles;
            foreach (var window in Allwindows)
            {
                if(window != parent)
                {
                    _driver.SwitchTo().Window(window);
                }
            }
            string Expected =   help.GetWebElement(Valdate_Price).Text;
            int index = 0;
          string Expected2 =  Expected.Remove(index,1);
            Assert.AreEqual(Expected2, Actual);
        }

        public void Click_on_SelectSize()
        {
            help.GetWebElement(Click_on_Select_size).Click();
        }
        public void Click_on_AddToBag()
        {
            help.GetWebElement(AddToBag_Btn).Click();
        }
        public void click_on_Bag()
        {
            // help.ClickByUsingJavaScriptExecutor(help.GetWebElement(Click_on_Bag));
            // help.GetWebElement(Click_on_Bag).Click();

            //  help.ScrollByusigAction(_driver,help.GetWebElement(Click_on_Bag));
            help.ClickElementUsingJavaScript(_driver, help.GetWebElement(Click_on_Bag));
        }

        public void verifyShippingPage(string Actual)
        {
          string Expected =  help.GetWebElement(Verifiy_Shipping).Text;
            Assert.AreEqual(Expected, Actual);
        }
        //public void Select_Product()
        //{
           
        //    help.MouseHoverHelper(_driver, help.GetWebElement(Hover_On_Men));
        //    help.GetWebElement(Click_on_Jackets).Click();
        //    help.GetWebElement(Clickon_Product).Click();

        //}
        //public void AddProductToBag(string Actual)
        //{
        //  string Expected =  help.GetWebElement(Valdate_Price).Text;
        //  Assert.AreEqual(Expected, Actual);
        //    help.GetWebElement(Click_on_Select_size).Click();
        //    help.GetWebElement(AddToBag_Btn).Click();
        //    help.GetWebElement(Click_on_Bag).Click();
         

        //}
        //public void ValidateAccountPage(string Actual)
        //{
        //  string Expectd =   help.GetWebElement(Verifiy_Shipping).Text;
        //    Assert.AreEqual(Expectd, Actual);
        //}

    }
}
