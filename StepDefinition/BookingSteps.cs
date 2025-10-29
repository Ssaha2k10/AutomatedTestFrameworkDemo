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
    public class BookingSteps
    {
        private readonly BookingPage _bookingPage;
        private readonly IPage _page;
        public BookingSteps(BookingPage bookingPage, IPage page)
        {
            _bookingPage = bookingPage;
            _page = page;

        }
        [Given("the user is on the Slick Calendar page")]
        public async Task GivenTheUserIsOnTheSlickCalendarPage()
        {
            await _bookingPage.NavigateAsync();
        }

        [Given("the user is logged into the application")]
        public void GivenTheUserIsLoggedIntoTheApplication()
        {
            throw new PendingStepException();
        }


        [Given("the user is able to view the booking page")]
        public void GivenTheUserIsAbleToViewTheBookingPage()
        {
            throw new PendingStepException();
        }

        [When("the user clicks on the {string} button")]
        public void WhenTheUserClicksOnTheButton(string buttonName)
        {
            throw new PendingStepException();
        }

        [When("selects the {string} from the dropdown menu")]
        public void WhenSelectsTheFromTheDropdownMenu(string option)
        {
            throw new PendingStepException();
        }

        [When("enters {string} in the search box")]
        public void WhenEntersInTheSearchBox(string text)
        {
            throw new PendingStepException();
        }

        [When("selects the client {string} from the search results")]
        public void WhenSelectsTheClientFromTheSearchResults(string text)
        {
            throw new PendingStepException();
        }

        [Then("the user should see the list of services available for {string}")]
        public void ThenTheUserShouldSeeTheListOfServicesAvailableFor(string text)
        {
            throw new PendingStepException();
        }

        [When("the user selects the service {string} from the list")]
        public void WhenTheUserSelectsTheServiceFromTheList(string serviceCat)
        {
            throw new PendingStepException();
        }

        [When("the user selects the {string} from the available services")]
        public void WhenTheUserSelectsTheFromTheAvailableServices(string serviceName)
        {
            throw new PendingStepException();
        }

        [Then("the user should see the calendar and the option to select a stylist for booking")]
        public void ThenTheUserShouldSeeTheCalendarAndTheOptionToSelectAStylistForBooking()
        {
            throw new PendingStepException();
        }

        [When("the user selects the calendar")]
        public void WhenTheUserSelectsTheCalendar()
        {
            throw new PendingStepException();
        }

        [When("chooses the desired date {string} for the booking and clicks {string}")]
        public void WhenChoosesTheDesiredDateForTheBookingAndClicks(string p0, string button)
        {
            throw new PendingStepException();
        }

        [Then("the calendar should collapse and show the selected date {string}")]
        public void ThenTheCalendarShouldCollapseAndShowTheSelectedDate(string date)
        {
            throw new PendingStepException();
        }

        [When("the user clicks to select the stylist for the booking")]
        public void WhenTheUserClicksToSelectTheStylistForTheBooking()
        {
            throw new PendingStepException();
        }

        [When("selects the available stylist from the list")]
        public void WhenSelectsTheAvailableStylistFromTheList()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the selected stylist displayed for the booking")]
        public void ThenTheUserShouldSeeTheSelectedStylistDisplayedForTheBooking()
        {
            throw new PendingStepException();
        }

        [When("the user clicks to select the time for the booking")]
        public void WhenTheUserClicksToSelectTheTimeForTheBooking()
        {
            throw new PendingStepException();
        }

        [When("selects the desired time slot for the booking")]
        public void WhenSelectsTheDesiredTimeSlotForTheBooking()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the selected time displayed for the booking")]
        public void ThenTheUserShouldSeeTheSelectedTimeDisplayedForTheBooking()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the booking displayed in the calendar view")]
        public void ThenTheUserShouldSeeTheBookingDisplayedInTheCalendarView()
        {
            throw new PendingStepException();
        }

        [Then("the sidebar should close automatically")]
        public void ThenTheSidebarShouldCloseAutomatically()
        {
            throw new PendingStepException();
        }

        [When("the user clicks on the created booking in the calendar")]
        public void WhenTheUserClicksOnTheCreatedBookingInTheCalendar()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the booking details displayed")]
        public void ThenTheUserShouldSeeTheBookingDetailsDisplayed()
        {
            throw new PendingStepException();
        }


        [Then("the booking status should change to {string}")]
        public void ThenTheBookingStatusShouldChangeTo(string confirmed)
        {
            throw new PendingStepException();
        }

        [Then("the modal for checkout or rebook should appear")]
        public void ThenTheModalForCheckoutOrRebookShouldAppear()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the checkout page with booking details")]
        public void ThenTheUserShouldSeeTheCheckoutPageWithBookingDetails()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the modal to confirm payment")]
        public void ThenTheUserShouldSeeTheModalToConfirmPayment()
        {
            throw new PendingStepException();
        }

        [Then("the user should see the payment confirmation message")]
        public void ThenTheUserShouldSeeThePaymentConfirmationMessage()
        {
            throw new PendingStepException();
        }

        [Then("should view the modal to enter the email address {string} for receipt")]
        public void ThenShouldViewTheModalToEnterTheEmailAddressForReceipt(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user enters the email address {string}")]
        public void WhenTheUserEntersTheEmailAddress(string p0)
        {
            throw new PendingStepException();
        }


        [Then("the user should see a message confirming that the receipt has been sent to {string}")]
        public void ThenTheUserShouldSeeAMessageConfirmingThatTheReceiptHasBeenSentTo(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the user should be redirected to the calendar view")]
        public void ThenTheUserShouldBeRedirectedToTheCalendarView()
        {
            throw new PendingStepException();
        }

        [When("the user clicks on the booking")]
        public void WhenTheUserClicksOnTheBooking()
        {
            throw new PendingStepException();
        }

        [Then("the sidebar should open displaying the booking details as checked out")]
        public void ThenTheSidebarShouldOpenDisplayingTheBookingDetailsAsCheckedOut()
        {
            throw new PendingStepException();
        }



    }
}
