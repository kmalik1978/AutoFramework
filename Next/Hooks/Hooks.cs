using System;
using System.Reflection;
using TechTalk.SpecFlow;
using Next.Browsers;
using System.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace Next.Hooks
{
    [Binding]
    public sealed class Hooks
    {

		private static ExtentTest featureName;
		private static ExtentTest scenario;
		private static ExtentReports extent;

        [BeforeTestRun]
		public static void InitializeReport()
		{
			string reportNm = DateTime.Now.ToString("yyyyMMddHHmmss");
			var htmlReporter = new ExtentHtmlReporter(@"C:\Framework\AutoFramework\Next\TestResults\TestRun_" +reportNm + ".html");
			htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
			extent = new ExtentReports();
			extent.AttachReporter(htmlReporter);
		}

		[AfterTestRun]
		public static void tearDown()
		{
			extent.Flush();
		}

		[BeforeFeature]
		public static void BeforeFeature()
		{
			featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
			
		}

		

        [BeforeScenario]
        public void BeforeScenario()
        {
			//TODO: implement logic that has to run before executing each scenario
			BrowserFactory.InitBrowser("Chrome");
			BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
			scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
		}

        [AfterScenario]
		[Scope(Tag = "closebrowser")]
		public void AfterScenario()
        {
			//TODO: implement logic that has to run after executing each scenario
			BrowserFactory.CloseAllDrivers();
			Console.WriteLine("Browser Closed");
		}

		[AfterStep]
		public static void InsertReportingSteps()
		{
			var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

			if (ScenarioContext.Current.TestError == null)
			{
				if (stepType == "Given")
					scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "When")
					scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "Then")
					scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "And")
					scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "But")
					scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text);
			}
			else if (ScenarioContext.Current.TestError != null)
			{
				if (stepType == "Given")
					scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
				else if (stepType == "When")
					scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
				else if (stepType == "Then")
					scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
				else if (stepType == "And")
					scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
				else if (stepType == "But")
					scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
			}

			if (ScenarioContext.Current.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")

			{
				if (stepType == "Given")
					scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
				else if (stepType == "When")
					scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
				else if (stepType == "Then")
					scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

			}
		}
	}
}
