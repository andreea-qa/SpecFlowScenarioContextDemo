using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace SpecFlowScenarioContextDemo.StepDefinitions
{
    [Binding]
    internal class SetUp
    {
        protected static IWebDriver driver;
        public static string gridURL = "@hub.lambdatest.com/wd/hub";
        private static readonly string LT_USERNAME = Environment.GetEnvironmentVariable("LT_USERNAME");
        private static readonly string LT_ACCESS_KEY = Environment.GetEnvironmentVariable("LT_ACCESS_KEY"); 
        protected readonly ScenarioContext scenarioContext;

        public SetUp(ScenarioContext _scenarioContext)
        {
            scenarioContext = _scenarioContext;
        }

        [BeforeTestRun]
        internal static void RunSetup()
        {
            SafariOptions capabilities = new SafariOptions();
            capabilities.BrowserVersion = "16.0";
            Dictionary<string, object> ltOptions = new Dictionary<string, object>();
            ltOptions.Add("username", "Your LambdaTest Username");
            ltOptions.Add("accessKey", "Your LambdaTest Access Key");
            ltOptions.Add("platformName", "macOS Ventura");
            ltOptions.Add("project", "Untitled");
            ltOptions.Add("w3c", true);
            ltOptions.Add("plugin", "c#-nunit");
            capabilities.AddAdditionalOption("LT:Options", ltOptions);
            driver = new RemoteWebDriver(new Uri($"https://{LT_USERNAME}:{LT_ACCESS_KEY}{gridURL}"), capabilities);
        }

        [After]
        internal static void TearDown()
        {
            driver.Dispose();
        }

    }
}
