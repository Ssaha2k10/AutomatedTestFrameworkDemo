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
    public class ProductPage
    {
        private readonly IPage _page;
        private readonly string _url;
        private ILocator AddToCartBtn => _page.Locator("button.btn_primary");
        private ILocator Cart => _page.Locator("#shopping_cart_container");
        private ILocator InventoryPage => _page.Locator(".inventory_list").First;
        public ProductPage(IPage page)
        {
            _page = page;
            _url = TestHooks.baseUrl;
        }

        public async Task NavigateAsync()
        {
            await _page.GotoAsync(_url);
        }

        public async Task ViewProductsPage()
        {
            await Expect(InventoryPage).ToBeVisibleAsync();
        }
        public async Task AddProductToCart()
        {
            try
            {
                var items = await _page.Locator(".inventory_item").AllAsync();
                foreach (var item in items)
                {
                    var text = await item.InnerTextAsync();
                    if (text.Contains("Sauce Labs Onesie"))
                    {
                        await item.Locator(AddToCartBtn).ClickAsync();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product to cart: {ex.Message}");
                throw;
            }
        }

        public async Task ViewCart()
        {
            var cartItem = _page.GetByText("Sauce Labs Onesie");
            await Cart.ClickAsync();
            await Expect(cartItem).ToBeVisibleAsync();
        }


    }
}


   