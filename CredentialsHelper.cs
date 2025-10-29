using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

public static class CredentialsHelper
{
    private static readonly IConfiguration _config;

    static CredentialsHelper() { 
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        _config = builder.Build();
    }


    public static string Username =>
        _config["Credentials:Username"]
       // ?? Environment.GetEnvironmentVariable("TEST_USER")
        ?? throw new InvalidOperationException("Username not set");

    public static string Password =>
        _config["Credentials:Password"]
       ?? Environment.GetEnvironmentVariable("TEST_PASS")
        ?? throw new InvalidOperationException("Password not set");

    public static string Pin =>
        _config["Credentials:Pin"]
        ?? Environment.GetEnvironmentVariable("TEST_PIN")
        ?? throw new InvalidOperationException("Pin not set");

   
}
