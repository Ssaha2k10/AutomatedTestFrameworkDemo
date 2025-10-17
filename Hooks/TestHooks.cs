using System.Threading.Tasks;
using Microsoft.Playwright;
using Reqnroll;
using Reqnroll.BoDi;
using Microsoft.Extensions.Configuration;

[Binding]
public class TestHooks
{
    public static IPlaywright? playwright;
    public static IBrowser? browser;
    public static IPage? _page;
    public static string baseUrl = string.Empty;

    private readonly IObjectContainer _objectContainer;

    public TestHooks(IObjectContainer objectContainer)
    {
        _objectContainer = objectContainer;
    }

    [BeforeScenario]
    public async Task BeforeScenario()
    {
        string env = Environment.GetEnvironmentVariable("ENV") ?? "QA";

        baseUrl = env switch
        {
            "DEV" => "https://www.saucedemo.com/v1/index.html",
            "QA" => "https://www.saucedemo.com/v1/index.html",
            "PROD" => "https://www.saucedemo.com/v1/index.html",
            _ => "https://www.saucedemo.com/v1/index.html"
        };
        playwright = await Playwright.CreateAsync();
        browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false // Set to true if you want to run in headless mode
        });
        var context = await browser.NewContextAsync();
        _page = await context.NewPageAsync();

        _objectContainer.RegisterInstanceAs(_page);
        _objectContainer.RegisterInstanceAs(browser);
        _objectContainer.RegisterInstanceAs(context);


    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        if (_page != null)
        {
            await _page.CloseAsync();
        }
        if (browser != null)
        {
            await browser.CloseAsync();
        }
        if (playwright != null)
        {
            playwright.Dispose();
        }
    }
}