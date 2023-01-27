using NUnit.Framework;
using specflow_boilerplate.Pages;
using specflow_boilerplate.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace specflow_boilerplate.Steps
{
    class LoginSteps
    {
        //Declare a new LoginPage instance with the global ChromeDriver
        readonly LoginPage loginPage = new LoginPage(ChromeDriverProvider.Driver);

        public void LoginWithCredentials(String username, String password)
        {
            loginPage.LoginWithIframe(username, password);
            //loginPage.ClickLoginButton();
        }

        public void AssertLoginErrorMessage()
        {
            Assert.That(loginPage.IsErrorMessagePresent(), Is.True);
        }

    }
}
