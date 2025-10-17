using AutomatedTestFramework.Pages;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;

namespace AutomatedTestFramework.Pages
{
    public class LogoutPage
    {
       private readonly IPage _page;
       private readonly string _url;
       private ILocator MenuBtn => _page.Locator(".bm-burger-button");
       private ILocator LogoutLink => _page.Locator("#logout_sidebar_link");
       private ILocator Menulist => _page.Locator(".bm-item-list");
       private ILocator LoginBtn => _page.Locator("#login-button");
        private ILocator UsernameField => _page.Locator("input[data-test='username']");
        private ILocator PasswordField => _page.Locator("input[data-test='password']");
        private ILocator InventoryPage => _page.Locator("#inventory_container").First;

        public LogoutPage(IPage page)
       {
           _page = page;
           _url = TestHooks.baseUrl;
       }

        public async Task NavigateAsync()
        {
            await _page.GotoAsync(_url);
        }

        public async Task NavigateToProductPage(string username, string password)
        {
            username = CredentialsHelper.Username;
            password = CredentialsHelper.Password;


            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await LoginBtn.ClickAsync();
            await Expect(InventoryPage).ToBeVisibleAsync();
        }
      
       public async Task ViewLogoutMenu()
       {
           await MenuBtn.ClickAsync();
           await Expect(Menulist).ToBeVisibleAsync();
           await Expect(LogoutLink).ToBeVisibleAsync();
        }
       public async Task LogoutApplication()
       {
           try
           {
               await LogoutLink.ClickAsync();
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Error during logout: {ex.Message}");
               throw;
           }
        }
        
        public async Task LoginPageVisible()
        {
            await Expect(MenuBtn).Not.ToBeVisibleAsync();
            await Expect(LogoutLink).Not.ToBeVisibleAsync();
            await Expect(LoginBtn).ToBeVisibleAsync();
        }

    }
}
