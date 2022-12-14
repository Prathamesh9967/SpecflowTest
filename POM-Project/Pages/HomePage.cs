using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POM_Project.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogOff => driver.FindElement(By.LinkText("Log off"));

        public void clickLogin() => lnkLogin.Click();

        public bool LogoffExists() => lnkLogOff.Displayed;
    }
}
