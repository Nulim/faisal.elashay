# Planit Technical Assessment
This project is part of the Planit Technical Assessment stage in their recruitment process.

It consists of 4 test case scenarios related to a provided web application where Selenium is being used to locate web page elements and NUnit has been used as the testing framework.

## Installation

Please download Visual Studios (Community Edition) via a google search or by clicking this [link](https://visualstudio.microsoft.com/downloads/).

Once Visual Studios is installed and the project has been cloned, please ensure the following NuGet packages are installed to ensure no compatibility issues.

```bash
coverlet.collector
Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.Json
Microsoft.NET.Test.Sdk
NUnit
Selenium.WebDriver
Selenium.WebDriver.ChromeDriver
System.Configuration.ConfigurationManager
```

You can access the Nuget Package Manager by searching for it in Visual Studios (CTRL + Q).

Alternatively, from the menu bar, you can select (Project -> Manage NuGet Packages...)

## Project Structure
There are 4 folders and a Settings file:
- Base (Contains a BasePage class for test classes to inherit SetUp and TearDown Methods)
- Helpers (Contains Helper classes which are used to simplify code re-usage)
- Pages (Contains Page classes where each page has its respective properties)
- Tests (Contains 4 test classes related to the test scenarios asked)
- Settings.json (This is the setting file where sensitive data is stored. Currently it contains the browser type and website URL settings under the AppSettings section)

## How to Run
Once the project is loaded on Visual Studios and all NuGet Packages are installed, perform the following actions:

1. In the Solution Explorer, Right-click the 'Tests' Folder
2. A menu prompt will be presented, click on 'Run Tests'
3. The project will begin with building
4. All tests running can be shown in the 'Test Explorer' Tab

## Demo
Here is a video link showcasing how I executed my tests and the NuGet packages installed via this [link](https://drive.google.com/file/d/1eDsRn1HOWdoapRy4JkO3xK14-Iv4efqE/view?usp=share_link).

## Answers/Assumptions
The browserType setting under the Settings.json file can only be "Chrome", "FireFox" or "Edge". The solution can be expanded on to run all three browsers but I chose to elect one browser type execution for this technical assessment.

When debugging the test(s), an OpenQA.Selenium.NoSuchElementException error may appear, please don't worry as this is thrown as part of the wait method. Press the F5 key on your keyboard and the test will resume normally.

On the rare occasion that tests start failing due to not finding the Settings.json. Right-click the Settings.json file in the Solution Explorer and select the 'Properties' option. Set 'Copy to Output Directory' to 'Copy always'.

There are a lot of things I would like to do to the solution to improve it, such as adding reporting and parallelism but thought to demo what is required to not further delay my submission.

For any other issues, feel free to reach out to me personally and I will be more than happy to assist in resolving any other issues that I may not have encountered.
