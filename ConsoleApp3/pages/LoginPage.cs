using ConsoleApp3.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement firstName => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement loginbtn => driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        internal void LoginSuccess()
        {
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\Abishake Vipinan\source\repos\ConsoleApp3\ConsoleApp3\TestData\Book1.xlsx", "TMSheet");
            // Identfying the username 
            //IWebElement firstName = driver.FindElement(By.Id("UserName"));
            String username = "document.getElementById('UserName').value='hari'";
            JSExecutor.Script(driver, username);
            
            //firstName.SendKeys(ExcelLibHelpers.ReadData(2, "Username"));

            //Identify password 
            //IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys(ExcelLibHelpers.ReadData(2, "Password"));
            
            // Identify Login and click
            //IWebElement loginbtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbtn.Click();
        }
        internal void LoginFailure()
        {
            firstName.SendKeys("hari123");
            password.SendKeys("asdf");
            loginbtn.Click();
        }
    }
}
