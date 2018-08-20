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

		private static string mainWindowHandle = BrowserFactory.Driver.CurrentWindowHandle;

		public static void SwitchToNewWindow()
		{
			BrowserFactory.Driver.SwitchTo().DefaultContent();
			//string mainWindowHandle = BrowserFactory.Driver.CurrentWindowHandle;
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
			Console.WriteLine("new window = " + BrowserFactory.Driver.Url);
		}

		public static void SwitchToDefaultWindow()
		{
			BrowserFactory.Driver.SwitchTo().DefaultContent();
			Console.WriteLine(" window url = " + BrowserFactory.Driver.Url);
		}
	}
}
