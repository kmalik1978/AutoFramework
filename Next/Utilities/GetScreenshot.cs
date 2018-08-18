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
			ITakesScreenshot ts = (ITakesScreenshot)driver;
			Screenshot screenshot = ts.GetScreenshot();
			//string localpath = Path.Combine (ConfigurationManager.AppSettings["ScreenShotsPath"], "Capture");
			string captureFileNm = DateTime.Now.ToString("HHmmss");
			string localpath = Path.Combine(ConfigurationManager.AppSettings["ScreenShotsPath"], captureFileNm);
			screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
			return localpath;
		}
	}
}