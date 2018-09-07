using System;
using TechTalk.SpecFlow;

namespace kpmg
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user selects login on the homepage")]
        public void WhenTheUserSelectsLoginOnTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user enters the login details (.*), (.*)")]
        public void WhenTheUserEntersTheLoginDetails(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user can see the dashboard")]
        public void ThenTheUserCanSeeTheDashboard()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
