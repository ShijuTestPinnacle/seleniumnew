using System;
using TechTalk.SpecFlow;

namespace ConsoleApp3.hookup
{
    [Binding]
    public class EditvalidationSteps
    {
        [Given(@"I have logged in to the portal")]
        public void GivenIHaveLoggedInToThePortal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have navigated to the Time and Material Page")]
        public void GivenIHaveNavigatedToTheTimeAndMaterialPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to edit data on the table")]
        public void ThenIShouldBeAbleToEditDataOnTheTable()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
