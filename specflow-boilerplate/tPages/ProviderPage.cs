using OpenQA.Selenium;
using System;
using specflow_boilerplate.Util;

namespace specflow_boilerplate.tPages
{
    public class ProviderPage
    {
        public IWebDriver WebDriver { get; }

        public ProviderPage(IWebDriver webDriver) { WebDriver = webDriver; }
        
        public String ProvidersURL = "https://develop-v3-ro-staging-c0j9vocf.betano.com/casino/providers/";

        private IWebElement ProviderLogo => WebDriver.FindElement(By.CssSelector("#app > div > div.app-main-container > div > main > div.seo-page-container > div > div > a:nth-child(21)"));

        public void GoToProviderPage()
        {
            ChromeDriverProvider.Driver.Navigate().GoToUrl(ProvidersURL);
        }

        public bool IsProviderLogoPresent() => ProviderLogo.Displayed;

    }
}
