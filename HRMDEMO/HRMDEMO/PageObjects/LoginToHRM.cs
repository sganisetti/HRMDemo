using HRMDEMO.Drivers;
using HRMDEMO.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDEMO.PageObjects
{
    public class LoginToHRM : PageBase

    {
       DriverHelper _driverHelper;
        public LoginToHRM(DriverHelper driverHelper) : base(driverHelper) { 
          this._driverHelper = driverHelper;
        
        }
      

        By UserNmae = By.XPath("//input[@name='username']");
        By Password = By.XPath("//input[@name='password']");
        By Login_Btn = By.XPath("//button[@type='submit']");
    

    public void Login(string username,string password)
    {

            GetWebElement(UserNmae).SendKeys(username);
            GetWebElement(Password).SendKeys(password);
            GetWebElement(Login_Btn).Click();
    }
    
}}
