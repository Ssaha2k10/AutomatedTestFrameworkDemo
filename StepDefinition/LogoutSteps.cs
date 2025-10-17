using AutomatedTestFramework.Pages;
using Microsoft.Playwright;
using Reqnroll;
using System.Threading.Tasks;

namespace AutomatedTestFramework.StepDefinition
{
    [Binding]
    public class LogoutSteps
    {
        private readonly LogoutPage _logoutpage;
        private readonly IPage _page;

        public LogoutSteps(LogoutPage logoutPage, IPage page)
        {
            _logoutpage = logoutPage;
            _page = page;
        }

        [Given("the user is logged in with valid credentials <{string}> and <{string}>")]
        public async Task GivenTheUserIsLoggedInWithValidCredentials(string username, string password)
        {
            await _logoutpage.NavigateAsync();
            await _logoutpage.NavigateToProductPage(username, password);
        }


        [When("the user views the burger menu")]
        public async Task WhenTheUserViewsTheBurgerMenu()
        {
            await _logoutpage.ViewLogoutMenu();
        }

        [When("the user clicks on the logout button")]
        public async Task WhenTheUserClicksOnTheLogoutButton()
        {
            try
            {
                await _logoutpage.LogoutApplication();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during logout: {ex.Message}");
                throw;
            }
        }

        [Then("the user should be redirected to the login page")]
        public async Task ThenTheUserShouldBeRedirectedToTheLoginPage()
        {
            await _logoutpage.LoginPageVisible();
        }
    }
}