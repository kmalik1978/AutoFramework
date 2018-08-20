using Next.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Next.TestData;

namespace Next.PageObjects
{
	public class MyAccountPage
	{

		#region Account Summary Submenu


		[FindsBy(How = How.XPath, Using = ".//*[@id='sec']/div[1]/ul/li[1]/a")]
		public IWebElement AccountSummary { get; set; }

		[FindsBy(How = How.PartialLinkText, Using = "MyAccount")]
		public IWebElement MyAccountlnk { get; set; }

		[FindsBy(How = How.ClassName, Using = "myAccountSummary")]
		public IWebElement AccountSummaryLinkFromPopup { get; set; }

		[FindsBy(How = How.XPath, Using = ".//*[@id='sec']/div[1]/ul/li[1]/ul/li[2]/a")]
		public IWebElement RecentActivity { get; set; }

		[FindsBy(How = How.PartialLinkText, Using = "nextunlimited")]
		public IWebElement NextUnlimitedLink { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#nuMessageBanner-container")]
		public IWebElement NextUnlimitedBnr { get; set; }

		[FindsBy(How = How.PartialLinkText, Using = "Request a Call Back")]
		public IWebElement RequestCallBack { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#txtCallbackCustomer")]
		public IWebElement CallBackCustNum { get; set; }

		#endregion

		public void ClickNU()
		{
			NextUnlimitedLink.ClickOnIt("nextunlimited");
		}

		public void CheckNU()
		{
			NUnit.Framework.Assert.True(NextUnlimitedBnr.IsDisplayed("NextUnlimitedBnr"));
		}

	}
}
