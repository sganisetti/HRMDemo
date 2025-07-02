using System;
using HRMDEMO.Drivers;
using HRMDEMO.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace HRMDEMO.StepDefinitions
{
    [Binding]
    public class LogintoHRMStepDefinitions 

    {
        LoginToHRM login;
        DriverHelper _driverhelper;
        public LogintoHRMStepDefinitions( DriverHelper driverhelper)
        {
            _driverhelper = driverhelper;
            login = new LoginToHRM(_driverhelper);
        }
        [Given("Iam on Hrm LoginPage")]
        public void GivenIamOnHrmLoginPage()
        {
            _driverhelper._driver.Url.Contains("login");
        }

        [When("I enter Username and Password")]
        public void WhenIEnterUsernameAndPassword(DataTable dataTable)
        {
            foreach(var row in dataTable.Rows)
            {
                string username = row["UserName"];
                string password = row["Password"];
                login.Login(username, password);
                
            }
           
        }

        [Then("I Validate the Dashboard and Errormsg")]
        public void ThenIValidateTheDashboardAndErrormsg()
        {
            if (_driverhelper._driver.Url.Contains("dashboard"))
            {
                Console.WriteLine("Logged in successfully");
            }
            else
            {
                Console.WriteLine("you are credentials are incorrect");
            }
        }
    }
}
