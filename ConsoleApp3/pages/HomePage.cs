using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ConsoleApp3
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void VerifyHomePage()
        {
            
            IWebElement username = driver.FindElement(By.XPath("//a[contains(.,'Hello hari!')]"));
            Console.WriteLine("username.Text " + username.Text);
            //Assert.AreEqual("Hello hari!" == username.Text, "Test Passed");
            Assert.That("Hello hari!", Is.EqualTo(username.Text));
           //if (username.Text == "Hello hari!")
             //  Console.WriteLine("verification passed - username disaplyed on home page");
            //else
         //     Console.WriteLine("verification failed - username not disaplyed on home page ");
        }

        internal void ClickAdminstration()
        {

            //Click adminstration 
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();
        }

        internal void ClickTimenMaterial()
        {
            //Click Time n Material 
            driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]")).Click();
        }
    }
}