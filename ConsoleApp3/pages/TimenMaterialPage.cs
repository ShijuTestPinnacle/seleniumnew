using ConsoleApp3.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class TimenMaterialPage
    {
        private IWebDriver driver;
       

        public TimenMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickCreateNew()
        {

            //Click create new button
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]")).Click();
        }

        internal void EnterValidDataandSave()
        {

            //Enter code 
            driver.FindElement(By.Id("Code")).SendKeys("Floods");

            // Enterd description
            driver.FindElement(By.Id("Description")).SendKeys("Be safe");

            //Price per unit
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("10");

            //click save
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        internal void ValidateData()
        {
            Wait.ElementIsVisible(driver, "//span[contains(.,'Go to the next page')]", "XPath");
            //Wait
            //Thread.Sleep(3000);
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            //IWebElement table = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table")));
            //Verification part
            // assignment 3 is to verify that the time an material object that you created is displayed on the table
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        //Identify the code element
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(code.Text);
                        if (code.Text == "HafsdfsddfA00075618")
                        {
                            Console.WriteLine("Test Passed, code found on table");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed, Code not found");
            }
        }
        internal void EditData()
        {
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();
            driver.FindElement(By.Id("Code")).SendKeys("modified");

            // Enterd description
            driver.FindElement(By.Id("Description")).SendKeys("check");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
        internal void ValidateEditedData()
        {

        }
    }
}