using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TMTests
    {
        static void Main(string[] args)
        {
            // Browser initiate 
            IWebDriver driver = new ChromeDriver();

            //navigate to horse-dev
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //maximize t
            driver.Manage().Window.Maximize();

            //access loginsucess method 

            // an instance of class
            var loginInstance = new LoginPage();
            loginInstance.LoginSuccess(driver);

            //Class for Home page,
            // method to verify the home 
            // method to click adminstration
            // method to click time n material

            HomePage homeInstance = new HomePage();
            homeInstance.VerifyHomePage(driver);
            homeInstance.ClickAdminstration(driver);
            homeInstance.ClickTimenMaterial(driver);


            TimenMaterialPage tmPage = new TimenMaterialPage();
            tmPage.ClickCreateNew(driver);
            tmPage.EnterValidDataandSave(driver);
            tmPage.ValidateData(driver);
            tmPage.EditData(driver);

            //to stop console from closing. 
            Console.ReadLine();

            //Close the driver
            driver.Quit();

            //static class 
            //StaticClass.StaticMethod(); 
            //comment a line ctrl +k + c
            //uncomment a line ctrl +k + u

        }
    }
}
