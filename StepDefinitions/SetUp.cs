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
        protected ScenarioContext scenarioContext;

        public SetUp(ScenarioContext _scenarioContext)
        {
            scenarioContext = _scenarioContext;
        }

        [BeforeScenario]
        internal static void RunSetup()
        {
            SafariOptions capabilities = new SafariOptions();
            capabilities.BrowserVersion = "latest";
            Dictionary<string, object> ltOptions = new Dictionary<string, object>();
            ltOptions.Add("username", LT_USERNAME);
            ltOptions.Add("accessKey", LT_ACCESS_KEY);
            ltOptions.Add("platformName", "macOS Ventura");
            ltOptions.Add("build", "SpecFlow ScenarioContext");
            ltOptions.Add("project", ScenarioContext.Current.ScenarioInfo.Title);
            ltOptions.Add("w3c", true);
            ltOptions.Add("plugin", "c#-nunit");
            capabilities.AddAdditionalOption("LT:Options", ltOptions);
            driver = new RemoteWebDriver(new Uri($"https://{LT_USERNAME}:{LT_ACCESS_KEY}{gridURL}"), capabilities);
        }

        [AfterScenario]
        internal void TearDown()
        {

            driver.Quit();
        }

    }
}
