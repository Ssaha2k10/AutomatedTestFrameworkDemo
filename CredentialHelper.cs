using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

public static class CredentialsHelper
{
    private static readonly IConfiguration _config;

    static CredentialsHelper()
    {
        _config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }

    public static string Username =>
        _config["Credentials:Username"]
        ?? Environment.GetEnvironmentVariable("TEST_USER")
        ?? throw new InvalidOperationException("Username not set");

    public static string Password =>
        _config["Credentials:Password"]
        ?? Environment.GetEnvironmentVariable("TEST_PASS")
        ?? throw new InvalidOperationException("Password not set");

    
}
