using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using static Microsoft.Playwright.LocatorFilterOptions;
using Reqnroll;
using System.Threading.Tasks;

namespace AutomatedTestFramework.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly string _url;
        private ILocator UsernameField => _page.Locator("input[data-pw-id='UserEmail']");
        private ILocator PasswordField => _page.Locator("input[data-pw-id='PasswordInput']");
        private ILocator LoginBtn => _page.Locator("button[data-pw-id ='login']");
        
        



        public LoginPage(IPage page)
        {
            _page = page;
            _url = TestHooks.baseUrl;
        }

        public async Task NavigateAsync()
        {
            try
            {
                await _page.GotoAsync(_url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error navigating to URL: {ex.Message}");
                throw;
            }
        }



        public async Task SuccessfulLoginWithEnter(string username, string password)
        {
                username = CredentialsHelper.Username;
                password = CredentialsHelper.Password;
                

            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await _page.Keyboard.PressAsync("Enter");
           
        }
            public async Task AccuratePinEntry()
        {
            string pin = CredentialsHelper.Pin;


            foreach (var ch in pin)
            {
                await _page.GetByRole(AriaRole.Button, new() { Name = ch.ToString() }).ClickAsync();
                await _page.WaitForTimeoutAsync(100);
            }

        }

        public async Task InaccuratePinEntry(string pin)
        {
          
            foreach (var ch in pin)
            {
                await _page.GetByRole(AriaRole.Button, new() { Name = ch.ToString() }).ClickAsync();
                await _page.WaitForTimeoutAsync(100);
            }

        }

        public async Task SuccessfulLoginWithLoginBtn(string username, string password)
        {

            username = CredentialsHelper.Username;
            password = CredentialsHelper.Password;


            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await LoginBtn.ClickAsync();
            
        }

        public async Task ViewErrorMessage()
        {
            var errorMessage = _page.Locator(".PinForm_errorContainer__AjwKp");
            await Expect(errorMessage).ToBeVisibleAsync();
        }

        public async Task ViewBookingPage()
        {
            var bookingPage = _page.Locator(".scheduler");
            await Expect(bookingPage).ToBeVisibleAsync();
        }

    }

}