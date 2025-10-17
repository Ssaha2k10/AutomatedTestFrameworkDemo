using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Reqnroll;
using System.Threading.Tasks;

namespace AutomatedTestFramework.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly string _url;
        private ILocator Logo => _page.Locator(".login_logo");
        private ILocator UsernameField => _page.Locator("input[data-test='username']");
        private ILocator PasswordField => _page.Locator("input[data-test='password']");
        private ILocator LoginBtn => _page.Locator("#login-button");
        private ILocator InventoryPage => _page.Locator("#inventory_container").First;



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

        public async Task ViewHomePageLogo()
        {
            await Expect(Logo).ToBeVisibleAsync();
            await Expect(UsernameField).ToBeVisibleAsync();
            await Expect(PasswordField).ToBeVisibleAsync();
        }

        public async Task SuccessfulLoginWithEnter(string username, string password)
        {
                username = CredentialsHelper.Username;
                password = CredentialsHelper.Password;

            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await _page.Keyboard.PressAsync("Enter");
           
        }
        public async Task ViewProductPage()
        { 
            await Expect(InventoryPage).ToBeVisibleAsync();
        }

        public async Task SuccessfulLoginWithLoginBtn(string username, string password)
        {

            username = CredentialsHelper.Username;
            password = CredentialsHelper.Password;


            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await LoginBtn.ClickAsync();
            
        }

        public async Task FailedLogin(string username, string password)

        {
           
            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await LoginBtn.ClickAsync();
            
        }

        public async Task ViewErrorMessage()
        {
            var errorMessage = _page.Locator("h3[data-test='error']");
            await Expect(errorMessage).ToBeVisibleAsync();
        }

    }

}