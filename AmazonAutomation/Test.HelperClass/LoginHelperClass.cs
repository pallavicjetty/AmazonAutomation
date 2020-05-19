using AmazonAutomation.UIPageObject;
using System.Configuration;
using AmazonAutomation.PageAction;

namespace AmazonAutomation.Test.HelperClass
{
    public class LoginHelper
    {
        public void ClickOnSignIn()
        {
            LoginHelperObject.clickOnLogin.ClickButton();
        }
        public void loginUsingValidCredentials()
        {
            string name = ConfigurationManager.AppSettings["username"];
            string _password = ConfigurationManager.AppSettings["password"];
            //SeleniumSetMethod.ClickButton(login.clickOnLogin);
            ClickOnSignIn();
            LoginHelperObject.userNameTextbox.EnterText(name);
            LoginHelperObject.continueButton.ClickButton();
            LoginHelperObject.passwordTextbox.EnterText(_password);
            LoginHelperObject.SignInButton.ClickButton();
        }
        public string loginWithNoCredential()
        {
            ClickOnSignIn();
            LoginHelperObject.continueButton.ClickButton();
            string errorMessage = LoginHelperObject.continueErrorMessage.GetTextFromThePage();
            return errorMessage;
        }
        public string loginWithInvalidCredential()
        {
            string invalidUserName = ConfigurationManager.AppSettings["invalidUserName"];
            ClickOnSignIn();
            LoginHelperObject.userNameTextbox.EnterText(invalidUserName);
            LoginHelperObject.continueButton.ClickButton();
            string invalidUsernameError = LoginHelperObject.invalidUserNameErrorMessage.GetTextFromThePage();
            return invalidUserName;
        }


        #region instantiateLoginObject
        private LoginPageObject _LoginHelper;
        public LoginPageObject LoginHelperObject
        {
            get { return _LoginHelper ?? (_LoginHelper = new LoginPageObject()); }
        }
        #endregion
    }
}
