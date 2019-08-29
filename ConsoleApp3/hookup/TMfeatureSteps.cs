using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp3.hookup
{
    [Binding]
    public class TMfeatureSteps
    {
        IWebDriver driver;
        [Given(@"I have logged in to the turnup portal sucessfully")]
        public void GivenIHaveLoggedInToTheTurnupPortalSucessfully()
        {
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
        
        [Given(@"I have navigated to the Time and Material page")]
        public void GivenIHaveNavigatedToTheTimeAndMaterialPage()
        {
            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdminstration();
            homeInstance.ClickTimenMaterial();
        }
        
        [Then(@"I should be able to create Time and Material record sucessfully")]
        public void ThenIShouldBeAbleToCreateTimeAndMaterialRecordSucessfully()
        {
            TimenMaterialPage tmPage = new TimenMaterialPage(driver);
            tmPage.ClickCreateNew();
            tmPage.EnterValidDataandSave();
            tmPage.ValidateData();
            driver.Quit();
        }
    }
}
