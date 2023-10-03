
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
            
        }

        [When(@"I select the (.*) category")]
        public void WhenISelectTheCategoryCategory(string categoryName)
        {
            scenarioContext["Category"] = categoryName;
        }

        [Then(@"the correct page is loaded")]
        public void ThenTheCategoryPageIsLoaded()
        {
            throw new PendingStepException();
        }

    }
}
