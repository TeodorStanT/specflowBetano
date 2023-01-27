using NUnit.Framework;
using specflow_boilerplate.tPages;
using specflow_boilerplate.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace specflow_boilerplate.Steps
{
    public class ProviderSteps
    {
        readonly ProviderPage providerPage  = new ProviderPage(ChromeDriverProvider.Driver);

        public void GoToProviderUrl()
        {
            providerPage.GoToProviderPage();
        }

        public void AssertProviderLogo()
        {
            Assert.That(providerPage.IsProviderLogoPresent, Is.True);
        }
    }
}
