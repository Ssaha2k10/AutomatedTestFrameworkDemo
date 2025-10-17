using AutomatedTestFramework.Pages;
using Microsoft.Playwright;
using Reqnroll;
using System;
using System.Threading.Tasks;


namespace AutomatedTestFramework.StepDefinition
{
    [Binding]
    public class ProductSteps
    {
        private readonly ProductPage _productPage;
        private readonly IPage _page;

        public ProductSteps(ProductPage productPage, IPage page)
        {
            _productPage = productPage;
            _page = page;
        }

        [Given(@"The user is on the products page")]
        [When(@"the user is on the products page")]
        [Then(@"the user should be able to view the products page")]

        public async Task TheUserIsOnTheProductsPage()
        {
            try
            {
                await _productPage.ViewProductsPage();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while adding product to cart: {ex.Message}");
                throw; // Re-throw the exception to ensure the test fails
            }
        }

        [Given(@"the user adds a product to the cart")]
        [When(@"the user adds a product to the cart")]
        public async Task TheUserAddsAProductToTheCart()
        {
            try
            {
                await _productPage.AddProductToCart();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while adding product to cart: {ex.Message}");
                throw; // Re-throw the exception to ensure the test fails
            }
        }
        [When("the user user navigates to the cart")]
        [Then("the user should be able to view the product in cart")]
        public async Task TheUserShouldBeAbleToViewTheProductInCart()
            {
            try
            { 
                          
                await _productPage.ViewCart();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while viewing the cart: {ex.Message}");
                throw; // Re-throw the exception to ensure the test fails
            }
        }
    }
}
