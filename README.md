# TestFramework

This repository contains a simple test framework implemented in C# with Playwright. It allows you to define and run tests for your code, providing a basic structure for organizing and executing test cases.

## Features
- Define test cases using a simple interface
- Run tests and report results
- Basic setup for Playwright integration
- Easy to extend and customize
- Supports asynchronous test execution
- Basic logging of test results
- Example test cases included
- Cross-platform support
- Lightweight and easy to use
- Open source and community-driven
- Continuous integration setup with GitHub Actions

## Prerequisites
Before running the project, ensure you have the following installed:
- .NET 9 SDK
- Node.js (for Playwright dependencies)
- A supported browser (Playwright will handle browser installation automatically)

## Setup Instructions
1. Clone the repository:
````````
git clone https://github.com/Ssaha2k10/AutomatedTestFramework
cd testframework
````````
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

## Folder Structure
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
