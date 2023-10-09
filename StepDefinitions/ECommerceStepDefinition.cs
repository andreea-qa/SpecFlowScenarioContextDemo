using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowScenarioContextDemo.StepDefinitions
{
    [Binding]
    internal class ECommerceStepDefinition : SetUp
    {
        public ECommerceStepDefinition(ScenarioContext _scenarioContext) : base(_scenarioContext)
        {
        }

        [Given(@"I navigate to the LambdaTest ecommerce playground page")]
        public void GivenINavigateToTheLambdaTestEcommercePlaygroundPage()
        {
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");
        }

        [Given(@"I extend the Shop by Category menu")]
        public void GivenIExtendTheShopByCategoryMenu()
        {
            driver.FindElement(By.XPath("//a[normalize-space()='Shop by Category']")).Click();
            WaitForElement($"//h5[normalize-space()='Top categories']");
        }

        [When(@"I select the (.*) category")]
        public void WhenISelectTheCategoryCategory(string categoryName)
        {
            scenarioContext["Category"] = categoryName;
            driver.FindElement(By.XPath($"//span[normalize-space()='{scenarioContext["Category"]}']")).Click();
        }

        [Then(@"the correct page is loaded")]
        public void ThenTheCorrectPageIsLoaded()
        {
            WaitForElement($"//h3[text()='Filter']");
            Assert.That(driver.Title == scenarioContext["Category"].ToString());
        }

        private static void WaitForElement(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }
    }
}
