using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTestFramework.Pages;
using Microsoft.Playwright;

namespace AutomatedTestFramework.StepDefinition
{
    [Binding]
    public class CheckOutSteps
    {
        private readonly CheckOutPage _checkoutPage;
        private readonly IPage _page;
        public CheckOutSteps(CheckOutPage checkoutPage, IPage page)
        {
            _checkoutPage = checkoutPage;
            _page = page;

        }

        [When("the user proceeds to checkout")]
        public async Task TheUserProceedsToCheckout()
        {
            await _checkoutPage.UserProceedsToCheckout();
        }

        [When("the user enters valid shipping information <{string}>, <{string}> and <{string}>")]
        public async Task WhenTheUserEntersValidShippingInformationAnd(string firstname, string lastname, string postalcode)
        {
            await _checkoutPage.UpdateCheckoutInfo(firstname, lastname, postalcode);
        }


        [When("the user completes the purchase")]
        public async Task WhenTheUserCompletesThePurchase()
        {
            await _checkoutPage.UserProceedsToCheckout();
        }

        [Then("the user should see a confirmation message")]
        public async Task ThenTheUserShouldSeeAConfirmationMessage()
        {
            await _checkoutPage.FinishPayment();
        }


    }
}
