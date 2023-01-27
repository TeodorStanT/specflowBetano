using TechTalk.SpecFlow;
using SpecFlow;
using OpenQA.Selenium;
using System;

namespace specflow_boilerplate.Steps
{
    [Binding]
    class HomeKeywords
    {
        //Declare a new HomeSteps instance
        readonly HomeSteps homeSteps = new HomeSteps();
        // ========== GIVEN Keywords

        [Given(@"that the user clicks the login link")]

        public void GivenIClickLoginLink()
        {    
            homeSteps.ClickLogin();
            
        }

        // ========== WHEN Keywords

        // ========== THEN Keywords

        [Then(@"the Balance should be visible")]
        public void ThenIShouldSeeUserBalance()
        {
            homeSteps.AssertUserBalanceIsDisplayed();
        }

    }
}
