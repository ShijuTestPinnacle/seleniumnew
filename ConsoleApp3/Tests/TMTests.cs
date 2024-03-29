﻿using NUnit.Framework;
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

        }
        IWebDriver driver;
        [SetUp]
        public void BeforeEachTestCase()
        {
            // Browser initiate 
            driver = new ChromeDriver();

            //navigate to horse-dev
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //maximize t
            driver.Manage().Window.Maximize();

            //access loginsucess method 
            // an instance of class
            LoginPage loginInstance = new LoginPage(driver);
            loginInstance.LoginSuccess();
        }

        [TearDown]
        public void AfterEachTestCase()
        {
            //Close the driver
            driver.Quit();
        }


        [Test]
        public void CreateTMnValidate()
        {
            //Class for Home page,
            // method to verify the home 
            // method to click adminstration
            // method to click time n material

            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdminstration();
            homeInstance.ClickTimenMaterial();

            TimenMaterialPage tmPage = new TimenMaterialPage(driver);
            tmPage.ClickCreateNew();
            tmPage.EnterValidDataandSave();
            tmPage.ValidateData("modify");
          }

        [Test]
        public void EditnValidate()
        {
            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdminstration();
            homeInstance.ClickTimenMaterial();
            TimenMaterialPage tmPage = new TimenMaterialPage(driver);
            tmPage.EditData();
            tmPage.ValidateEditedData("validation");

        }
        [Test]
        public void DeletenValidate()
        {
            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdminstration();
            homeInstance.ClickTimenMaterial();
        }
    }
}

