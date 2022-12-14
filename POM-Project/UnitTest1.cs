using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using POM_Project.Pages;

namespace POM_Project
{
    public class Tests : DriverHelper
    {
        //public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void login()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homepage = new HomePage();
            homepage.clickLogin();

            LoginPage loginpage = new LoginPage();

            loginpage.sendCredential("admin", "password");
            loginpage.clickLogin();

            Assert.That(homepage.LogoffExists(), Is.True, "LOG OFF button not displayed");
        }

        [TearDown]
        public void close()
        {
            driver.Quit();
        }
    }
}