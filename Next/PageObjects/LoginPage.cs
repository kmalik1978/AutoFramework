﻿using Next.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Next.TestData;

namespace Next.PageObjects
{
    public class LoginPage
    {

        //private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "EmailOrAccountNumber")]
        [CacheLookup]
        public IWebElement Username { get; set; }


        [FindsBy(How = How.Id, Using = "Password")]
        [CacheLookup]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='pri']")]
        [CacheLookup]
        public IWebElement SignIn { get; set; }


        public void EnterLoginDetails(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            Username.EnterText(userData.username, "UserName");
            Password.EnterText(userData.password, "Password");
            //SignIn.ClickOnIt("SignIn");
        }

        public void ClickSignIn()
        {
            SignIn.ClickOnIt("SignIn");
        }
    }
}