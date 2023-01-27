using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace specflow_boilerplate.tPages
{
    public class CasinoPage
    {
        public IWebDriver WebDriver { get; }

        public CasinoPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private IWebElement CasinoButton => WebDriver.FindElement(By.CssSelector(".providers-button"));
        private IWebElement CasinoSearchBar => WebDriver.FindElement(By.CssSelector(".search-bar"));

        public void ClickCasinoButton()
        {
            CasinoButton.Click();
        }

        public void ClickSearchBar()
        {
            CasinoSearchBar.Click();
        }
    }
}
