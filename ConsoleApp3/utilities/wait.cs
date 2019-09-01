using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.utilities
{
    class Wait
    {
       
        public static void ElementIsVisible(IWebDriver driver, String value, String Key)
        {
            try
            {
                if(Key=="XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
                }
                if (Key == "ID")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
                }
                if (Key == "ClassName")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
                }

            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
