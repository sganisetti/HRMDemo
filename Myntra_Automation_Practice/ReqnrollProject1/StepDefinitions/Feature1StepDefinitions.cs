using System;
using Business_Logic_PageObjects.PageObjects;
using OpenQA.Selenium;
using Reqnroll;
using TestRunner.Support;

namespace TestRunner.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions : BaseDriver
    {
        //IWebDriver _driver;
        HomePage _homePage;
        public Feature1StepDefinitions(ScenarioContext scenariocontext) : base(scenariocontext) 
        {
            _homePage = new HomePage(Driver);
        }

        [Given("Iam on Ajio Home Page and verified the Home Page {string}")]
        public void GivenIamOnAjioHomePageAndVerifiedTheHomePage(string Actual)
        {
            _homePage.Validate_Home_Page(Actual);
        }


        [When("I mouse hover on the Mens Section")]
        public void WhenIMouseHoverOnTheMensSection()
        {
           _homePage.Hovering_On_Mens_Section();
        }

        [When("I click on the Coates and Jackets Section")]
        public void WhenIClickOnTheCoatesAndJacketsSection()
        {
            _homePage.Click_On_JacketsandCoates();
        }

        [When("I Select the Product")]
        public void WhenISelectTheProduct()
        {
            _homePage.ClickonProduct();
        }

        [Then("I Verified the Price of the product {string}")]
        public void ThenIVerifiedThePriceOfTheProduct(string cost)
        {
           
            _homePage.Verifyingprice(cost);
        }


        [When("I Click on SIze Button")]
        public void WhenIClickOnSIzeButton()
        {
           _homePage.Click_on_SelectSize();
        }

        [When("I Click on Add To Bag Button")]
        public void WhenIClickOnAddToBagButton()
        {
            _homePage.Click_on_AddToBag();
        }

        [When("I click on Bag")]
        public void WhenIClickOnBag()
        {
            Thread.Sleep(5000);
            _homePage.click_on_Bag();
        }

        [Then("I Verify the Shipping Page {string}")]
        public void ThenIVerifyTheShippingPage(string Actual)
        {
           _homePage.verifyShippingPage(Actual);
        }
    }
}
