using OpenQA.Selenium;

namespace POM_Project.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement txtusername => driver.FindElement(By.Name("UserName"));
        IWebElement txtpassword => driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));

        public void sendCredential(string username, string password)
        {
            txtusername.SendKeys(username);
            txtpassword.SendKeys(password);
        }

        public void clickLogin()
        {
            btnLogin.Click();
        }
    }
}
