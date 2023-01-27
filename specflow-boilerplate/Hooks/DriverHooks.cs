using specflow_boilerplate.Util;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow_boilerplate.Hooks
{
    [Binding]
    public class DriverHooks
    {
        //Navigate to the homepage before every scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            //Here is where the desired Website is opened
            ChromeDriverProvider.Driver.Navigate().GoToUrl(TestConstant.ENV);
        }

        //After all of the scenarios have been run, Close the driver
        [AfterTestRun]
        public static void AfterTestRun()
        {
            //Closing and disposing of the Driver
            ChromeDriverProvider.Driver.Quit();
            ChromeDriverProvider.Driver.Dispose();
        }
    }
}
