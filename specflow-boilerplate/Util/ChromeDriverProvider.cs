using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace specflow_boilerplate.Util
{
    class ChromeDriverProvider
    {
        //This is the ChromeDriver that will be used across all of the tests and pages
        private static IWebDriver chromeDriver;
        public static IWebDriver Driver
        {
            get
            {
                //Check if the driver was already initialised
                if (chromeDriver == null)
                {
                    //Define here the properties of the Driver
                    chromeDriver = new ChromeDriver("C:\\workspace");
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                    chromeDriver.Manage().Window.Maximize();
                }
                return chromeDriver;
            }
        }
    }
}
