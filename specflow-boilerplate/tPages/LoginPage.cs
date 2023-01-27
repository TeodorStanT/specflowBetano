using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using specflow_boilerplate.Util;
//using specflow_boilerplate.Util;

namespace specflow_boilerplate.Pages
{
    public class LoginPage
    {
        //Standard getter and constructor
        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver) { WebDriver = webDriver; }
        

        //UI elements with different selectors examples
        private IWebElement UserNameTextField => WebDriver.FindElement(By.CssSelector("#username"));
        private IWebElement PasswordTextField => WebDriver.FindElement(By.Id("password"));
        private IWebElement LoginButton => WebDriver.FindElement(By.CssSelector("#app > div > main > div > section > div > form > button"));
        private IWebElement ErrorMessage => WebDriver.FindElement(By.Id("error-http"));

        //Methods
        //public void ClickLogin() => LoginLink.Click();
        public void ClickLoginButton() => LoginButton.Click();

        public void LoginWithIframe(string userName, string password)
        {
            //WebDriver.SwitchTo().Frame(WebDriver.FindElement(By.CssSelector(TestConstant.AccountLoginModal)));
            Helper.SwitchFrame(WebDriver,TestConstant.AccountLoginModal);
            UserNameTextField.SendKeys(userName);
            PasswordTextField.SendKeys(password);
            ClickLoginButton();
            
            WebDriver.SwitchTo().DefaultContent();
        }
        public bool IsErrorMessagePresent() => ErrorMessage.Displayed;
    }
}
