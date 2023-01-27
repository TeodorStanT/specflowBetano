using NUnit.Framework;
using specflow_boilerplate.Pages;
using specflow_boilerplate.Util;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace specflow_boilerplate.Steps
{
    [Binding]
    public class LoginKeywords
    {
        //Declare a new LoginSteps instance
        readonly LoginSteps loginSteps = new LoginSteps();

        // ========== GIVEN Keywords

        // ========== WHEN Keywords

        [When(@"the user logs in with credentials")]
        public void WhenIEnterTheFollowindDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginSteps.LoginWithCredentials((string)data.Username, (string)data.Password);
        }

        // ========== THEN Keywords

        [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            loginSteps.AssertLoginErrorMessage();
        }

    }
}
