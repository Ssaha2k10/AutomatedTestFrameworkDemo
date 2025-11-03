# AutomatedTestFrameworkDemo

End-to-end UI test automation framework for salon management application built with C#, Playwright for .NET, Reqnroll (BDD), and NUnit.

## Overview

This framework automates testing of a salon booking system including login authentication, appointment scheduling, service selection, stylist assignment, and checkout workflows. Built using Page Object Model (POM) pattern with BDD scenarios written in Gherkin.

## Tech Stack

- **.NET 9.0** with C# 13 (latest language features)
- **Playwright for .NET 1.55.0** - Cross-browser automation
- **Reqnroll 3.1.2** - BDD framework (SpecFlow successor)
- **NUnit 4.3.2** - Test runner and assertions
- **Microsoft.Extensions.Configuration** - Settings management


## Features
- Define test cases using a simple interface
- Run tests and report results
- Basic setup for Playwright integration
- Easy to extend and customize
- Supports asynchronous test execution
- Example test cases included
- Cross-platform support
- Lightweight and easy to use
- Open source and community-driven
  

## Prerequisites

Before running the project, ensure you have the following installed:

- **.NET 9 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/9.0)
- **Visual Studio 2022 (17.8+)** or **VS Code** with C# extension
- **Git** for version control
- **No Node.js required** - Playwright for .NET is fully managed

## Setup Instructions

### 1. Clone the Repository:
````````
git clone https://github.com/Ssaha2k10/AutomatedTestFrameworkDemo.git.
`````````
2. Restore NuGet packages:
````````
dotnet restore
````````
3. Install Playwright for .NET:
````````
dotnet tool install -g playwright
playwright install
````````

4. Configure the application:
   - Update the `appsettings.json` file with the required configuration values (e.g., credentials).

## Execution Instructions
1. Build the project:
````````
dotnet build
````````
2. Run the tests:
````````
dotnet test
````````

## Project Structure
````````
.
├── src                      # Source files for the test framework
│   ├── TestFramework.csproj    # Project file for the test framework
│   ├── Program.cs              # Entry point for the test framework
│   └── ...                    # Other source files
├── tests                     # Sample tests
│   ├── SampleTests.csproj       # Project file for sample tests
│   ├── SampleTest.cs          # Example test case
│   └── ...                    # Other test files
├── playwright.config.ts       # Playwright configuration file
└── README.md                 # This file
````````

## Customization and Extension
To customize or extend the test framework:
- Modify the source files in the `src` folder.
- Add new test cases in the `tests` folder.
- Update the configuration in `appsettings.json` as needed.

## Troubleshooting Common Issues
- **Playwright installation issues**: Ensure Node.js is installed and accessible in your PATH. Try reinstalling Playwright dependencies with `playwright install`.
- **Test execution failures**: Check the logs for error messages. Ensure the application under test is running and accessible.
- **Performance issues**: Adjust the concurrency settings in the Playwright configuration. Ensure your machine has sufficient resources (CPU, RAM) available.

## Contributing
Contributions are welcome! Please follow these steps to contribute:
1. Fork the repository
2. Create a new branch for your feature or bug fix
3. Make the necessary changes and commit them
4. Push your branch and create a pull request

Please ensure your code follows the existing style and conventions used in the project.

### Folder Details

#### 📁 **Features/**
Contains BDD feature files written in Gherkin syntax. Each `.feature` file describes test scenarios in plain English that are automatically converted to executable tests by Reqnroll.

- **Login.feature** - Authentication test scenarios (valid/invalid credentials, PIN validation)
- **Booking.feature** - End-to-end appointment booking workflow
- **\*.feature.cs** - Auto-generated backing code (do not manually edit)

#### 📁 **StepDefinition/**
Contains C# classes that bind Gherkin steps to actual test code. Each step definition implements the "Given/When/Then" logic.

- **LoginSteps.cs** - Implements login-related step definitions
- **BookingSteps.cs** - Implements booking workflow step definitions

#### 📁 **Pages/**
Contains Page Object Model (POM) classes. Each class represents a page/component in the application and encapsulates locators and actions.

- **LoginPage.cs** - Login page interactions (username, password, PIN entry)
- **BookingPage.cs** - Booking page interactions (client search, service selection, date picking)

#### 📁 **Hooks/**
Contains test lifecycle hooks that run before/after scenarios or features.

- **TestHooks.cs** - Browser initialization, environment setup, teardown logic

#### 📁 **Properties/**
Contains project metadata and launch configurations.

- **launchSettings.json** - Defines launch profiles for different environments
- **Resources.resx** - Embedded resource files

#### 📄 **Root Files**
- **appsettings.json** - Stores configuration like credentials and environment settings
- **CredentialsHelper.cs** - Utility class to load credentials from config
- **AutomatedTestFramework_Slk.csproj** - .NET project file with package references

## Running Tests

### Visual Studio

1. Open **Test Explorer** (__Test > Test Explorer__)
2. Build the solution (__Ctrl+Shift+B__)
3. Run tests:
   - Click __Run All__ to execute entire test suite
   - Right-click specific feature/scenario → __Run__
   - Set breakpoints and select __Debug__

