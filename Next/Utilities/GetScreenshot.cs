using OpenQA.Selenium;
using System;
using System.Configuration;
using System.IO;

namespace Next.Utilities
{
	public class GetScreenShot
	{
		public static string Capture(IWebDriver driver, string screenShotName)
		{
			DateTime date = DateTime.Now.ToUniversalTime();
			ITakesScreenshot ts = (ITakesScreenshot)driver;
			Screenshot screenshot = ts.GetScreenshot();
			string captureFileNm = DateTime.Now.ToString("yyyyMMddHHmmssfff");
			string localpath = Path.Combine(ConfigurationManager.AppSettings["ScreenShotsPath"], captureFileNm);
			screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
			return localpath;
		}
	}
}