using Next.Browsers;
using OpenQA.Selenium.Support.PageObjects;

namespace Next.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserDriver.Driver, page);
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

		public static MyAccountPage MyAccount
		{
			get { return GetPage<MyAccountPage>(); }
		}
	}
}