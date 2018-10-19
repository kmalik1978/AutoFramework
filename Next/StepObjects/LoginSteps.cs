using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Next.PageObjects;
using System.Configuration;
using Next.Browsers;
using AventStack.ExtentReports.Gherkin.Model;

namespace Next.StepObjects
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"user is on the homepage")]
        public void UserIsOnTheHomepage()
        {
			string browserURL = BrowserDriver.Driver.Url.ToLower();
			Console.WriteLine("BROWSER URL IS: " + browserURL);
			Assert.AreEqual(browserURL, ConfigurationManager.AppSettings["URL"]);
		}

        [Given(@"selects MyAccount to login")]
        public void SelectsMyAccountToLogin()
        {
            Page.Home.ClickOnMyAccount();
        }

        [When(@"user enters username and password")]
        public void UserEntersUsernameAndPassword()
        {
            Page.Login.EnterLoginDetails("LogInTestWithPageObjects");
        }

        [Then(@"user signs in")]
        public void SignsIn()
        {
            Page.Login.ClickSignIn();
        }

		[Then(@"then exits")]
		public void ThenThenExits()
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"user clicks Help button")]
		public void ThenClicksHelpButton()
		{
			Page.Login.ClickHelp();
		}

	}
}