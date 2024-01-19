using System;
using TechTalk.SpecFlow;
using UserLoginLib;

namespace BankProjectLogin.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private string username;
        private string password;
        private string loginresult;
        private readonly ScenarioContext scenarioContext;
        private readonly UserLogin userLogin;

        public LoginStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            userLogin = new UserLogin();
        }
        [Given(@"a user with valid user name ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithValidUserNameAndValidPassword(string abc, string p1)
        {
            username=abc;
            password=p1;
        }

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            loginresult=userLogin.Login(username, password);
        }

        [Then(@"the result should  Login Successful")]
        public void ThenTheResultShouldLoginSuccessful()
        {
            loginresult.Should().Be(loginresult);
        }

        [Given(@"a user with invalid user name ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUserNameAndValidPassword(string p0, string invalid)
        {
            username = p0;
            password=invalid;
        }

        [Then(@"the result should  Login Failed")]
        public void ThenTheResultShouldLoginFailed()
        {
            loginresult.Should().Be(loginresult);
        }
    }
}
