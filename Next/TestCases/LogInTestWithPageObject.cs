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

            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Page.Home.ClickOnMyAccount();
            Page.Login.EnterLoginDetails("LogInTestWithPageObjects");
            Page.Login.ClickSignIn();

            BrowserFactory.CloseAllDrivers();
        }
    }
}
