using specflow_boilerplate.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace specflow_boilerplate.Keywords
{
    [Binding]
    class ProviderKeywords
    {

        //Declare a new LoginSteps instance
        readonly ProviderSteps providerSteps = new ProviderSteps();

        // ========== GIVEN Keywords

        // ========== WHEN Keywords

        [Given(@"that the user is on the providers page")]
        public void WhenIEnterTheFollowindDetails()
        {
            //dynamic data = table.CreateDynamicInstance();
            providerSteps.GoToProviderUrl();
        }

        // ========== THEN Keywords

        [Then(@"the Provider logo should be visible")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            providerSteps.AssertProviderLogo();
        }

    }
}
