using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Next.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Url = "http://www.store.demoqa.com";
            driver.Url = "http://www.next.co.uk";

            // Find the element that's ID attribute is 'account'(My Account) 
            //driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
            driver.FindElement(By.XPath(".//*[@title='Sign in to view account details']")).Click();

            // Find the element that's ID attribute is 'log' (Username)
            // Enter Username on the element found by above desc.
            // driver.FindElement(By.Id("log")).SendKeys("testuser_1");
            driver.FindElement(By.Id("EmailOrAccountNumber")).SendKeys("kadir.h.malik@gmail.com");


            // Find the element that's ID attribute is 'pwd' (Password)
            // Enter Password on the element found by the above desc.
            //driver.FindElement(By.Id("pwd")).SendKeys("Test@123");
            driver.FindElement(By.Id("Password")).SendKeys("Khm881978");


            // Now submit the form.
            //driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.XPath(".//*[@id='pri']")).Click();

            // Close the driver
            driver.Quit();

        }
    }
}
