using AutomatedTestFramework.Pages;
using Microsoft.Playwright;
using Reqnroll;
using System;
using System.Threading.Tasks;

namespace AutomatedTestFramework.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly IPage _page;

        public LoginSteps(LoginPage loginPage, IPage page)
        {
            _loginPage = loginPage;
            _page = page;
        }


        [Given("the user is on the login page")]
        public async Task GivenTheUserIsOnTheLoginPage()
        {
            await _loginPage.NavigateAsync();
        }

        [When("the user enters valid credentials {string} and {string}")]
        public async Task WhenTheUserEntersValidCredentialsAnd(string username, string password)
        {
            await _loginPage.SuccessfulLoginWithLoginBtn(username, password);
            }


        [Then("the user should be redirected to the product page")]
        public async Task ThenTheUserShouldBeRedirectedToTheProductPage()
        {
            await _loginPage.ViewBookingPage();

        }

        [When("the user enters invalid credentials {string} and {string}")]
        public async Task WhenTheUserEntersInvalidCredentials(string username, string password)
        {
            await _loginPage.FailedLogin(username, password);
        }

        [Then("an error message should be displayed")]
        public async Task ThenAnErrorMessageShouldBeDisplayed()
        {
            await _loginPage.ViewErrorMessage();
        }

        [When("the user enters the pin code")]
        public async Task WhenTheUserEntersThePinCode()
        {
            await _loginPage.AccuratePinEntry();

        }

        [When("the user enters incorrect pin code {string}")]
        public async Task WhenTheUserEntersIncorrectPinCode(string pin)
        {
            await _loginPage.InaccuratePinEntry(pin);
        }






    }
}
