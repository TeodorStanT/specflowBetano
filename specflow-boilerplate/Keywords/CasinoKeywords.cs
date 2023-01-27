using System;
using System.Collections.Generic;
using System.Text;
using specflow_boilerplate.Steps;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace specflow_boilerplate.Keywords
{
    [Binding]
    public class CasinoKeywords
    {
        readonly LoginSteps loginSteps = new LoginSteps();

        [Given(@"that the user is on the Casino page")]

        public void ReachCasinoPage()
        {
            
        }
    }
}
