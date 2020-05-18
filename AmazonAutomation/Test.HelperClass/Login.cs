using AmazonAutomation.PageObject;
using AmazonAutomation.TestSuits;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.Test.HelperClass
{
    public class Login: LoginPageTestcase
    {
        public void ClickOnSignIn()
        {
            LoginHelper.clickOnLogin.ClickButton();
        }
        public void loginUsingValidCredentials()
        {
            string name = ConfigurationManager.AppSettings["username"];
            string _password = ConfigurationManager.AppSettings["password"];
            //SeleniumSetMethod.ClickButton(login.clickOnLogin);
            ClickOnSignIn();
            LoginHelper.userNameTextbox.EnterText(name);
            LoginHelper.continueButton.ClickButton();
            LoginHelper.passwordTextbox.EnterText(_password);
            LoginHelper.SignInButton.ClickButton();
        }
        public void loginWithNoCredential()
        {
            ClickOnSignIn();
            LoginHelper.continueButton.ClickButton();
        }
        public void loginWithInvalidCredential()
        {
            string invalidUserName = ConfigurationManager.AppSettings["invalidUserName"];
            ClickOnSignIn();
            LoginHelper.userNameTextbox.EnterText(invalidUserName);
            LoginHelper.continueButton.ClickButton();
        }


        #region instantiate
        private LoginPageObject _LoginHelper;
        public LoginPageObject LoginHelper
        {
            get { return _LoginHelper ?? (_LoginHelper = new LoginPageObject()); }
        }
        #endregion
    }
}
