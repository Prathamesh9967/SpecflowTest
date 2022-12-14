using NUnit.Framework;
using POM_Project.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace POM_Project.Steps
{
    [Binding]
    public class LoginSteps : DriverHelper
    {
        HomePage homepage = new HomePage();
        LoginPage loginpage = new LoginPage();

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homepage.clickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.sendCredential(data.username, data.password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLogin()
        {
            loginpage.clickLogin();
        }

        [Then(@"I should see user logged in")]
        public void ThenIShouldSeeUserLoggedIn()
        {
            Assert.That(homepage.LogoffExists(), Is.True, "Log Off button not displayed");
        }

    }
}
