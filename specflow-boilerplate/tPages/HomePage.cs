using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;


namespace specflow_boilerplate.Pages
{
    class HomePage
    {
        //Standard getter and constructor
        public IWebDriver WebDriver { get; }

        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements with different selectors examples
        private IWebElement LoginModal => WebDriver.FindElement(By.LinkText("CONECTARE"));
        private IWebElement UserBalance => WebDriver.FindElement(By.CssSelector(".user-info-basic-balance-amount"));

        //Methods
        public void ClickLogin() {
            LoginModal.Click();
        }

        public bool IsUserBalanceDisplayed() => UserBalance.Displayed;
    }
}
