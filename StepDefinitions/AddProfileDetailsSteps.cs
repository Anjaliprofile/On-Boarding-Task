using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System.Threading;
using TechTalk.SpecFlow;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    class AddProfileDetailsSteps : GlobalDriver
    {
        [Given(@"Seller has signed in to the Mars Portal")]
        public void GivenSellerHasSignedInToTheMarsPortal()
        {

            LoginSteps login = new LoginSteps();
            login.GivenIHaveLoginToWebsite();
        }


        [Then(@"Seller should be able to add profile details")]
        public void ThenSellerShouldBeAbleToAddProfileDetails()
        {

            // page object for Add seller profile
            AddSellerProfile addProObj = new AddSellerProfile();
            addProObj.AddProfile(driver);
            // quit driver
            driver.Close();
        }

        [Then(@"Seller should be able to Edit profile details")]
        public void ThenSellerShouldBeAbleToEditProfileDetails()
        {
            // page object for Edit seller profile
            EditSellerProfile editProObj = new EditSellerProfile();
            editProObj.EditProfile(driver);
            // quit driver
            driver.Close();
        }

        [Then(@"Seller should be able to Delete profile details")]
        public void ThenSellerShouldBeAbleToDeleteProfileDetails()
        {
            // page object for Delete seller profile
            DeleteSellerProfile delProObj = new DeleteSellerProfile();
            delProObj.DeleteProfile(driver);
            // quit driver
            driver.Close();
        }
    
    
    }
}
