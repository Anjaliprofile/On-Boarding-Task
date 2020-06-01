using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    class LoginSteps : GlobalDriver
    {
        [Given(@"I have login to website")]
        public void GivenIHaveLoginToWebsite()
        {
            // define driver
            driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");

            // page object for SignIn page
            SignIn signInObj = new SignIn();
            signInObj.SignInStep(driver);
            // Quit the driver
            //driver.Quit();
        }
    }
}
