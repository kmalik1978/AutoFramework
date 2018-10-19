using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Next.Browsers;

namespace Next.Utilities
{
	class SwitchWindows
	{

		private static string mainWindowHandle = BrowserDriver.Driver.CurrentWindowHandle;

		public static void SwitchToNewWindow()
		{
			BrowserDriver.Driver.SwitchTo().DefaultContent();
			//string mainWindowHandle = BrowserDriver.Driver.CurrentWindowHandle;
			Console.WriteLine("deafult window = " + mainWindowHandle);

			ReadOnlyCollection<string> windowHandles = BrowserDriver.Driver.WindowHandles;
			String newWindowHandle = "";
			foreach (string handle in windowHandles)
			{
				if (handle != mainWindowHandle)
				{
					newWindowHandle = handle;
					break;
				}
			}

			BrowserDriver.Driver.SwitchTo().Window(newWindowHandle);
			Console.WriteLine("new window = " + BrowserDriver.Driver.Url);
		}

		public static void SwitchToDefaultWindow()
		{
			BrowserDriver.Driver.SwitchTo().DefaultContent();
			Console.WriteLine(" window url = " + BrowserDriver.Driver.Url);
		}
	}
}
