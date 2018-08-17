using Next.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Next.PageObjects
{
    public class HomePage
    {

        //private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@title='Sign in to view account details']")]
        [CacheLookup]
        private IWebElement MyAccount { get; set; }

        public void ClickOnMyAccount()
        {
            MyAccount.ClickOnIt("MyAccount");
        }
    }
}
