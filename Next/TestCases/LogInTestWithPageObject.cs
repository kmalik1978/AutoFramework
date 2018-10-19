using NUnit.Framework;
using Next.PageObjects;
using System.Configuration;
using Next.Browsers;

namespace Next.TestCases
{
    class LogInTestWithPageObject
    {
        [Test]
        public void TestPageObjects()
        {

            BrowserDriver.InitBrowser("Chrome");
            BrowserDriver.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Page.Home.ClickOnMyAccount();
            Page.Login.EnterLoginDetails("LogInTestWithPageObjects");
            Page.Login.ClickSignIn();

            BrowserDriver.CloseAllDrivers();
        }
    }
}
