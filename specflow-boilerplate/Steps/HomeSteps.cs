using NUnit.Framework;
using specflow_boilerplate.Pages;
using specflow_boilerplate.Util;
using System;
using OpenQA.Selenium;

namespace specflow_boilerplate.Steps
{
    class HomeSteps
    {

        //Declare a new HomePage instance with the global ChromeDriver
        readonly HomePage homePage = new HomePage(ChromeDriverProvider.Driver);

        public void ClickLogin() 
        { 
            homePage.ClickLogin(); 
        }
        

        public void AssertUserBalanceIsDisplayed() { Assert.That(homePage.IsUserBalanceDisplayed(), Is.True); }
    }
}
