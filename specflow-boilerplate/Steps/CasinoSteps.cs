using specflow_boilerplate.tPages;
using System;
using System.Collections.Generic;
using System.Text;
using specflow_boilerplate.Util;

namespace specflow_boilerplate.Steps
{
    public class CasinoSteps
    {
        readonly CasinoPage casinoPage = new CasinoPage(ChromeDriverProvider.Driver);

        public void ClickCasinoButton()
        {
            casinoPage.ClickCasinoButton();
        }
    }
}
