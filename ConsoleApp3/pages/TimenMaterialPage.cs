using ConsoleApp3.utilities;
using NUnit.Framework;
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
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\Abishake Vipinan\source\repos\ConsoleApp3\ConsoleApp3\TestData\Book1.xlsx", "TMSheet");
            //Enter code 

           IWebElement code= driver.FindElement(By.Id("Code"));
            code.SendKeys( ExcelLibHelpers.ReadData(2, "code"));

            // Enter description

            IWebElement Description=driver.FindElement(By.Id("Description"));
            Description.SendKeys(ExcelLibHelpers.ReadData(2, "Description"));
            //Price per unit

            IWebElement Priceperunit=driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
            Priceperunit.SendKeys(ExcelLibHelpers.ReadData(2, "PricePerUnit"));
            //click save
           driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        internal void ValidateData(String newcode)
        {
            Wait.ElementIsVisible(driver, "//span[contains(.,'Go to the next page')]", "XPath");
            //Wait
            //Thread.Sleep(3000);
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            //IWebElement table = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table")));
            //Verification part
            try
            { 
                while (true)
                 {
                for (int i = 1; i <= 10; i++)
                {
                    //Identify the code element
                    IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                    Console.WriteLine(code.Text);
                    Assert.AreEqual(newcode == code.Text, "Test Passed");
                    /* if (code.Text == "modify")
                     {
                         Console.WriteLine("Test Passed, code found on table");
                         return;
                     }*/
                 }
                 driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
            }
         
         }
         catch (Exception e)
         {
             Console.WriteLine(e);
         }
                
            }
        
          internal void EditData()
            {
                driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();
                IWebElement code1 = driver.FindElement(By.Id("Code"));
                code1.Clear();
                code1.SendKeys(ExcelLibHelpers.ReadData(3, "code"));

                // Enter description
                IWebElement Description1 = driver.FindElement(By.Id("Description"));
                Description1.Clear();
                Description1.SendKeys(ExcelLibHelpers.ReadData(3, "Description"));
                driver.FindElement(By.XPath("//input[@type='submit']")).Click();
                   }
         internal void ValidateEditedData(String modifiedcode)
         {
          Wait.ElementIsVisible(driver, "//span[contains(.,'Go to the next page')]", "XPath");
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        //Identify the code element
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(code.Text);
                        Assert.AreEqual(modifiedcode == code.Text, "Test Passed");
                       
                    }
                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }

}
