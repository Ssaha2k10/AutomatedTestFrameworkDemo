using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;

namespace AutomatedTestFramework.Pages
{
    public class BookingPage
    {
        private readonly IPage _page;
        private readonly string _url;

        private ILocator NewButton => _page.Locator("button[data-tag='SchedulerHeader__button-new']");
        private ILocator BookingCalendar => _page.Locator(".scheduler");
        private ILocator New_DropdownMenu => _page.Locator("div[data-bem='DropdownFoldout__content']");
        private ILocator AppointmentSelection => _page.Locator("button[data-tag='SchedulerHeader__item-appointment']");
        private ILocator ClientSearchBox => _page.Locator("input.search-dropdown");
        private ILocator ServiceCategories => _page.Locator("div[data-tag='ServiceSelection__service-selection-content']").First;
        private ILocator ServiceList => _page.Locator("div.service-list");
        private ILocator DatePicker => _page.Locator("#bookingDayPicker");
        private ILocator SelectStylistBtn => _page.GetByText("Select Stylist");
        private ILocator SelectTimeBtn => _page.GetByText("Select Time");
        private ILocator SideBar => _page.Locator(".BookingWindow");


        public BookingPage(IPage page)
        {
            _page = page;
            _url = TestHooks.baseUrl;
        }

        public async Task ViewBookingPage()
        {
            await Expect(BookingCalendar).ToBeVisibleAsync();
        }

        public async Task ClickButton(string buttonName)
        {
            await _page.GetByRole(AriaRole.Button, new() { Name = buttonName }).First.ClickAsync();
        }

        public async Task SelectFromDropdown(string option)
        {
            await New_DropdownMenu.GetByRole(AriaRole.Button, new() { Name = option }).ClickAsync();
        }

        public async Task SearchClient(string clientName)
        {
            await ClientSearchBox.FillAsync(clientName);
           
        }

        public async Task SelectClientFromSearchResults(string clientName)
        {
           var searchDropDownmenu = _page.Locator("div.search-dropdown-results");
           await searchDropDownmenu.GetByText(clientName).First.ClickAsync();
        }

        public async Task ViewAvailableServices()
        {
            await Expect(ServiceCategories).ToBeVisibleAsync();
        }
        public async Task SelectServiceCategory(string serviceCategory)
        {
            await ServiceCategories.GetByText(serviceCategory).ClickAsync();
        }
        public async Task SelectServiceFromList(string serviceName)
        {
            await ServiceList.GetByText(serviceName).ClickAsync();
        }
        public async Task SelectDate(string date)
        {
            await DatePicker.ClickAsync();
            await _page.Locator(".react-datepicker").WaitForAsync();

            if (!DateTime.TryParse(date, out var parsed))
                throw new ArgumentException("Invalid date format. Example: '2025-10-30'");

            string targetDay = parsed.Day.ToString();

            var dayLocator = _page.Locator($".react-datepicker__day:not(.react-datepicker__day--outside-month):has-text('{targetDay}')");

            await dayLocator.First.ClickAsync();
        }

        public async Task SelectStylist(string name)
        {
            var MoreOptionsBtn = _page.GetByText("More");

            await SelectStylistBtn.ClickAsync();
            await MoreOptionsBtn.ClickAsync();
            var stylistLocator = _page.Locator(".item-option div").Filter(new() { HasText = name}).First;
            await stylistLocator.ClickAsync();
        }

        public async Task ValidateStylistName(string name)
        {
            var stylistNameLocator = _page.Locator("div.staff-button-right div").First;
            await Expect(stylistNameLocator).ToHaveTextAsync(name);
        }

        public async Task SelectTime(string time)
        {
            var morningBtn = _page.GetByRole(AriaRole.Button, new() { Name = "Morning", Exact = true });
            await SelectTimeBtn.ClickAsync();
            await morningBtn.ClickAsync();
            var timeLocator = _page.Locator(".item-option div").Filter(new() { HasText = time }).First;
            await timeLocator.ClickAsync();

        }

        public async Task ViewAppointment(string clientName)
        {
            await Expect(SideBar).Not.ToBeVisibleAsync();
            var appointmentDetails = _page.Locator(".cal-client").Filter(new() { HasText = clientName}).Last;
            await Expect(appointmentDetails).ToBeVisibleAsync();

        }

        public async Task ConfirmAppointment(string clientName)
        {
            var appointmentConfirmation = _page.Locator("div[data-bem = 'AppointmentHeader__status-text']");
            var confirmBtn = _page.GetByRole(AriaRole.Button, new() { Name = "Confirm" });

            var appointmentDetails = _page.Locator(".cal-client").Filter(new() { HasText = clientName }).Last;
            await appointmentDetails.ClickAsync();
            await Expect(confirmBtn).ToBeVisibleAsync();
            await confirmBtn.ClickAsync();
            await Expect(appointmentConfirmation).ToHaveTextAsync("Confirmed");
        }




    }






}

