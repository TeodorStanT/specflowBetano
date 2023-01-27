using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using specflow_boilerplate.Util;

namespace specflow_boilerplate.Util
{
    static class Helper
    {
        public static IWebDriver WebDriver { get; }

        public static WebDriver SwitchFrame(this IWebDriver webDriver, string frame)
        {
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.CssSelector(frame)));
            return (WebDriver)webDriver;
        }
    }
}
