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

        private ILocator FirstNameField => _page.Locator("input[data-test='firstName']");
        private ILocator LastNameField => _page.Locator("input[data-test='lastName']");
        private ILocator PostalCodeField => _page.Locator("input[data-test='postalCode']");
        private ILocator ContinueBtn => _page.Locator("input[value='CONTINUE']");
        private ILocator CheckoutBtn => _page.GetByText("CHECKOUT");
        private ILocator CheckoutPage => _page.Locator("div.checkout_info");
        private ILocator SummaryPage => _page.Locator(".summary_info");
        private ILocator FinishBtn => _page.GetByText("FINISH");

        public BookingPage(IPage page)
        {
            _page = page;
            _url = TestHooks.baseUrl;
        }

        public async Task NavigateAsync()
        {
            await _page.GotoAsync(_url);
        }

       public async Task UserProceedsToCheckout()
        {
           await Expect(CheckoutBtn).ToBeVisibleAsync();
           await CheckoutBtn.ClickAsync();
           
        }

       public async Task UpdateCheckoutInfo(string firstname, string lastname,string postcode )
        {
            
            await FirstNameField.FillAsync(firstname);
            await LastNameField.FillAsync(lastname);
            await PostalCodeField.FillAsync(postcode);
            await ContinueBtn.ClickAsync();

        }

        public async Task FinishPayment()
        {
            var OrderConfirmation = _page.Locator("h2.complete-header").Filter(new() { HasText = "THANK YOU FOR YOUR ORDER"});
            await Expect(SummaryPage).ToBeVisibleAsync();
            await Expect(FinishBtn).ToBeVisibleAsync();
            await FinishBtn.ClickAsync();
            await Expect(OrderConfirmation).ToBeVisibleAsync();
        }



    }
}
