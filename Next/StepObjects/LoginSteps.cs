using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Next.PageObjects;
using System.Configuration;
using Next.Browsers;

namespace Next.StepObjects
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"user is on the homepage")]
        public void UserIsOnTheHomepage()
        {
			// BrowserFactory.InitBrowser("Chrome");
			// BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
			string browserURL = BrowserFactory.Driver.Url.ToLower();
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
    }
}