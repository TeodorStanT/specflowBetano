# Getting started with Specflow and Selenium

Specflow is a library for C# that makes it easier to write high quality automated acceptance tests, with powerful reporting and living documentation features.

### The project directory structure
The project has the following directory structure that derives from the standard Specflow structure (this difference is present so that it matches the project structure of a Serenity).
```Gherkin
Dependencies
Features                        Feature files
    + Login.feature             
Hooks                           Hooks files
    + DriverHooks.cs            Hook for initialising and closing the WebDriver
Keywords                        Glue code to compose Gherkin tests, the keywords are created from @steps. They are called Steps in the traditional Specflow structure
    + HomeKeywords.cs   
    + LoginKeywords.cs
Steps                           Reusable steps that are created from page objects. They don't exist in the standard Specflow structure.
    + HomeSteps.cs
    + LoginSteps.cs
tPages                          Standard page object
    + HomePage.cs
    + LoginPage.cs
Util                            Utility package for utility classes
    + ChromeDriverProvider.cs   Used for initialising the WebDriver and also for defining settings
    + TestConstant.cs           Used for defining constant variables
```

## The sample scenarios
One positive and one negative for logging in into a website

```Gherkin
#Scenarios are written in Gherkin
Feature: Login
	Login to EA Demo Application

#Each scenario can have specific tags so that we can run tests with only specific tags if we wish to
#Each step from the scenarios will be linked to the corresponding KEYWORDS file
@smoke @ui
Scenario: Perform Login of EA Appliaction site
	Given that the user clicks the login link
	When the user logs in with credentials
		| Username | Password |
		| admin    | password |
	Then the Employees Details should be visible

#Here we can alteady see the benefit of using Specflow: The GIVEN and WHEN steps are copied from the positive scenario above
#Writing smart and generic steps allow us to reuse them in future
@sanity @ui
Scenario: Perform invalid Login of EA Appliaction site
	Given that the user clicks the login link
	When the user logs in with credentials
		| Username | Password  |
		| admins   | passwords |
	Then an error message is displayed
```


The glue code for the positive scenario looks like this

```C#
// ======== HomeKeywords:
    [Given(@"that the user clicks the login link")]
        public void GivenIClickLoginLink()
        {
            homeSteps.ClickLogin();
        }

// ======== LoginKeywords:
    [When(@"the user logs in with credentials")]
        public void WhenIEnterTheFollowindDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginSteps.LoginWithCredentials((string)data.Username, (string)data.Password);
        }
        
    [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            loginSteps.AssertLoginErrorMessage();
        }

```

## Executing the tests
To run the sample project, you can either just open View -> Test Explorer and Run the tests from there, either run `dotnet test` from the command line with the cmd open on the project folder.

NOTE: In order to run tests using dotnet, you need to download it from here: https://dotnet.microsoft.com/download

By default, the tests will run according to the DriverProvider used (in this case, the ChromeDriverProvider is used).

In order for test results to be automatically created, use the command `dotnet test -r "Results" --logger html` and the results will be present in the Results folder.

If you want to run specific tests, you can run them by tag `dotnet test --filter TestCategory=smoke` where smoke is a tag

### Webdriver configuration
The WebDriver configuration is managed entirely from the ChromeDriverProvider class, as illustrated below:
```C#
public static IWebDriver Driver
        {
            get
            {
                //Check if the driver was already initialised
                if (chromeDriver == null)
                {
                    //Define here the properties of the Driver
                    chromeDriver = new ChromeDriver();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
                    chromeDriver.Manage().Window.Maximize();
                }
                return chromeDriver;
            }
        }

```

# Getting started with RestSharp

RestSharp is a C# library used to build and send API requests, and interpret the responses. It is used as part of the C#Bot API testing framework to build the requests, send them to the server, and interpret the responses so assertions can be made.

### The project directory structure
The project has the following directory structure that derives from the standard Specflow structure (this difference is present so that it matches the project structure of a Serenity).
```Gherkin
Dependencies
Features                        Feature files
    + RestSharp.feature
Keywords                        Glue code to compose Gherkin tests, the keywords are created from @steps. They are called Steps in the traditional Specflow structure
    + RestSharpKeywords.cs   
Steps                           Reusable steps that are created from page objects. They don't exist in the standard Specflow structure.
    + ApiSteps.cs
Util                            Utility package for utility classes
    + TestData.cs           Used for defining constant variables
```

## The sample scenarios

```Gherkin
#Scenarios are written in Gherkin
Feature: RestSharp
	Api testing

#Each scenario can have specific tags so that we can run tests with only specific tags if we wish to
#Each step from the scenarios will be linked to the corresponding KEYWORDS file
@API
Scenario: CheckUserName
	Given I navigate to the base url
	When I retrieve the data about the first user
	Then The information retrived is corect

```


The glue code for the positive scenario looks like this

```C#
    [Given(@"I navigate to the base url")]
        public void GivenINavigateToTheBaseUrl()
        {
            ApiSteps.CreateRequest();
        }

    [When(@"I retrieve the data about the first user")]
        public void WhenIRetrieveTheNameOfFirstUser()
        {
            ApiSteps.GetDataFromJson();
        }

    [Then(@"The information retrived is corect")]
        public void ThenTheNameIsPresent()
        {
            var check = ApiSteps.AssertName(TestData.apiUserName);
            Assert.IsTrue(check);
        }

```

## Executing the tests
To run the sample project, you can either just open View -> Test Explorer and Run the tests from there, either run `dotnet test` from the command line with the cmd open on the project folder.

NOTE: In order to run tests using dotnet, you need to download it from here: https://dotnet.microsoft.com/download

By default, the tests will run according to the DriverProvider used (in this case, the RestClient is used).

In order for test results to be automatically created, use the command `dotnet test -r "Results" --logger html` and the results will be present in the Results folder.

If you want to run specific tests, you can run them by tag `dotnet test --filter TestCategory=smoke` where smoke is a tag

### Webdriver configuration//////////TBC
The WebDriver configuration is managed entirely from the ChromeDriverProvider class, as illustrated below:
```C#
public static IWebDriver Driver
        {
            get
            {
                //Check if the driver was already initialised
                if (chromeDriver == null)
                {
                    //Define here the properties of the Driver
                    chromeDriver = new ChromeDriver();
                    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
                    chromeDriver.Manage().Window.Maximize();
                }
                return chromeDriver;
            }
        }

```

