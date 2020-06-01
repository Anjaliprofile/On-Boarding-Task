using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMars.Pages
{
    class EditSellerProfile
    {
        public void EditProfile(IWebDriver driver)
        {
            // wait for element visibility
            Sync.WaitForVisiblitity(driver, "XPath", "// h3[contains(text(),'Description')]/span/i", 30);
            // click on Description
            driver.FindElement(By.XPath("//h3[contains(text(),'Description')]/span/i")).Click();
            //clear Existing detail
            driver.FindElement(By.XPath("//textarea[@name='value']")).Clear();
            Thread.Sleep(2000);
            // Populate Login page test data collection
            ExcelLibHelpers.PopulateInCollection(@"A:\Docker\ProjectMars\TestData\TestData.xls", "UpdatedProfileDetails");

            // update Description 
            driver.FindElement(By.XPath("//textarea[@name='value']")).SendKeys(ExcelLibHelpers.ReadData(2, "Description"));
            // click on save
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            Thread.Sleep(3000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Description has been saved successfully");

            //click on Language
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[1]")).Click();
            // Click on Edit button for language
            driver.FindElement(By.XPath("//td[contains(text(),'Hindi')]//following-sibling::td[@class='right aligned']/span[1]")).Click();
            // Clear existed laguage
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();
            // Add updated language
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(ExcelLibHelpers.ReadData(2, "Language"));
            // select language level
            driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            driver.FindElement(By.XPath("//select[@class='ui dropdown']//option[@value='Basic']")).Click();
            // click on update
            driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Update']")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "English has been updated to your languages");
           

            // Click on Skills
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[2]")).Click();
            // Click on Update Exist Skill
            driver.FindElement(By.XPath("//td[contains(text(),'Selenium')]//following-sibling::td[@class='right aligned']/span[1]")).Click();
            // clear existed result
            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).Clear();
            // Update Skills
            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys(ExcelLibHelpers.ReadData(2, "Skills"));
             // wait for the element is clikable
             Sync.WaitForVisiblitity(driver, "XPath", "//select[@class='ui fluid dropdown' and @name='level']/option[@value='Beginner']", 20);
            // Update Skill level
            driver.FindElement(By.XPath("//select[@class='ui fluid dropdown' and @name='level']/option[@value='Beginner']")).Click();
             // click on Update button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Selenium Web Driver has been updated to your skills");


            // click on Education
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[3]")).Click();
            // click on edit button
            driver.FindElement(By.XPath("//td[contains(text(),'India')]//following-sibling::td[@class='right aligned']/span[1]")).Click();
            // clear existance value
            driver.FindElement(By.XPath("//input[@name='instituteName']")).Clear();
            // write updated value
            driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys(ExcelLibHelpers.ReadData(2, "CollegeName"));
            // click on update
           driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Education as been updated");


            // click on Certificate
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[4]")).Click();
            // click on edit button
            driver.FindElement(By.XPath("//td[contains(text(),'.Net')]//following-sibling::td[@class='right aligned']/span[1]")).Click();
            // clear 
            driver.FindElement(By.XPath("//input[@name='certificationName']")).Clear();
            driver.FindElement(By.XPath("//input[@name='certificationName']")).SendKeys(ExcelLibHelpers.ReadData(2, "CertificateName"));

            driver.FindElement(By.XPath("//input[@name='certificationFrom']")).Clear();
            driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys(ExcelLibHelpers.ReadData(2, "CertifiedFrom"));

            driver.FindElement(By.XPath("//select[@name='certificationYear']")).Click();
            driver.FindElement(By.XPath("//select[@name='certificationYear']/option[@value='2017']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "JavaScript has been updated to your certification");

        }
    }
}
