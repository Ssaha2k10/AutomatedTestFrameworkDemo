using AutomatedTestFramework.Pages;
using Microsoft.Playwright;
using Reqnroll;


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
        

        [Given(@"the user is logged into the application")]
        public async Task GivenTheUserIsLoggedIntoTheApplication()
        {
            var loginPage = new LoginPage(_page);
            await loginPage.NavigateAsync();
            await loginPage.SuccessfulLoginWithLoginBtn(CredentialsHelper.Username, CredentialsHelper.Password);
            await loginPage.AccuratePinEntry();
        }


        [Given("the user is able to view the booking page")]
        public async Task GivenTheUserIsAbleToViewTheBookingPage()
        {
            await _bookingPage.ViewBookingPage();
        }

        [When("the user clicks on the {string} button")]
        public async Task WhenTheUserClicksOnTheButton(string buttonName)
        {
            await _bookingPage.ClickButton(buttonName);
        }

        [When("selects the {string} from the dropdown menu")]
        public async Task WhenSelectsTheFromTheDropdownMenu(string option)
        {
            await _bookingPage.SelectFromDropdown(option);
        }

        [When("enters {string} in the search box")]
        public async Task WhenEntersInTheSearchBox(string text)
        {
            await _bookingPage.SearchClient(text);
        }

        [When("selects the client {string} from the search results")]
        public async Task WhenSelectsTheClientFromTheSearchResults(string text)
        {
            await _bookingPage.SelectClientFromSearchResults(text);
        }

        [Then("the user should see the list of services available")]
        public async Task ThenTheUserShouldSeeTheListOfServicesAvailable()
        {
            await _bookingPage.ViewAvailableServices();
        }

        [When("the user selects the service {string} from the list")]
        public async Task WhenTheUserSelectsTheServiceFromTheList(string serviceCat)
        {
            await _bookingPage.SelectServiceCategory(serviceCat);
        }

        [When("the user selects the {string} from the available services")]
        public async Task WhenTheUserSelectsTheFromTheAvailableServices(string serviceName)
        {
            await _bookingPage.SelectServiceFromList(serviceName);
        }

        [When("chooses the desired date {string} for the booking and clicks {string}")]
        public async Task WhenChoosesTheDesiredDateForTheBookingAndClicks(string p0, string button)
        {
            await _bookingPage.SelectDate(p0);
            await _bookingPage.ClickButton(button);
        }

        [When("the user selects the stylist for the booking {string}")]
        public async Task WhenTheUserSelectsTheStylistForTheBooking(string name)
        {
            await _bookingPage.SelectStylist(name);
        }

        [Then("the user should see the selected stylist {string} displayed for the booking")]
        public async Task ThenTheUserShouldSeeTheSelectedStylistDisplayedForTheBooking(string name)
        {
            await _bookingPage.ValidateStylistName(name);
        }

        [When("the user selects the desired time slot for the booking {string}")]
        public async Task WhenTheUserSelectsTheDesiredTimeSlotForTheBooking(string serviceTime)
        {
            await _bookingPage.SelectTime(serviceTime);
        }

        [Then("the user should see the booking displayed in the calendar view {string}")]
        public async Task ThenTheUserShouldSeeTheBookingDisplayedInTheCalendarView(string test)
        {
            await _bookingPage.ViewAppointment(test);
        }

        [Then("The user should be able to confirm the appointment{string}")]
        public async Task ThenTheUserShouldBeAbleToConfirmTheAppointment(string test)
        {
            await _bookingPage.ConfirmAppointment(test);
        }

    }
}
