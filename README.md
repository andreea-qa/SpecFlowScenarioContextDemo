# SpecFlowScenarioContextDemo

ScenarioContext class is a shared context object used in SpecFlow to share data between different steps and scenarios. It allows storing and retrieving data throughout the execution of the test scenarios, and it can be used to transfer data between different steps and scenarios. 
This project uses SpecFlow and LambdaTest to exemplify how to share data between test steps using ScenarioContext.

## Configure Environment Variables

Before the tests are run, please set the environment variables LT_USERNAME & LT_ACCESS_KEY from the terminal. The account details are available on your [LambdaTest Profile](https://accounts.lambdatest.com/detail/profile) page.

For macOS:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
```

For Linux:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
```

For Windows:

```bash
set LT_USERNAME=LT_USERNAME
set LT_ACCESS_KEY=LT_ACCESS_KEY
```

Please visit [LambdaTest Capabilities Generator](https://www.lambdatest.com/capabilities-generator/) to generate capabilities for the test cases.

## How to run tests

Once the environment variables are exported, run the following command from the terminal (after navigating to the root directory):

```bash
dotnet test SpecFlowScenarioContextDemo.sln
```

Shown below is the test execution on LambdaTest:

![image](https://github.com/andreea-qa/SpecFlowScenarioContextDemo/assets/60468653/3b9f7d83-b949-4dbc-91b2-8ee6a2d05632)

