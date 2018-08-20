using System.Threading;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Next.PageObjects;
using Next.Extensions;
using System.Configuration;
using Next.Browsers;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Next.Utilities;

namespace Next.StepObjects
{
    [Binding]
    public class MyAccountSteps
    {
        [Then(@"user clicks nextunlimited")]
        public void ClickonNU()
        {
			Page.MyAccount.ClickNU();
        }

		[Then(@"confirm nu image exists")]
		public void ThenThenExits()
		{
			Page.MyAccount.CheckNU();
		}

		[Then(@"user clicks on call back")]
		public void ThenUserClicksOnCallBack()
		{
		//	string mainWindowHandle = BrowserFactory.Driver.CurrentWindowHandle;
		//	Console.WriteLine("deafult window = " + mainWindowHandle);

			Page.MyAccount.RequestCallBack.ClickOnIt("request call back");
		}

		[Then(@"enters phone number")]
		public void ThenEntersPhoneNumber()
		{
			Thread.Sleep(5000);
			//SwitchWindows.SwitchToNewWindow();
			BrowserFactory.Driver.SwitchTo().DefaultContent();
			string mainWindowHandle = BrowserFactory.Driver.CurrentWindowHandle;
			Console.WriteLine("deafult window = " + mainWindowHandle);

			ReadOnlyCollection<string> windowHandles = BrowserFactory.Driver.WindowHandles;
			String newWindowHandle = "";
			foreach (string handle in windowHandles)
			{
				if (handle != mainWindowHandle)
				{
					newWindowHandle = handle;
					break;
				}
			}

			BrowserFactory.Driver.SwitchTo().Window(newWindowHandle);
			Console.WriteLine("window  url= " + BrowserFactory.Driver.Url);
			Page.MyAccount.CallBackCustNum.SendKeys("PL191876");
			BrowserFactory.Driver.SwitchTo().Window(mainWindowHandle);
			Console.WriteLine("window url= " + BrowserFactory.Driver.Url);

			//SwitchWindows.SwitchToDefaultWindow();
		}

	}
}