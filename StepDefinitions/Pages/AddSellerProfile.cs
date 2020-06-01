using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMars.Pages
{
    class AddSellerProfile
    {
        public void AddProfile(IWebDriver driver)
        {
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            // click on Description
            driver.FindElement(By.XPath("// h3[contains(text(),'Description')]/span/i")).Click();

            // Populate Login page test data collection
            ExcelLibHelpers.PopulateInCollection(@"A:\Docker\ProjectMars\TestData\TestData.xls", "ProfileDetails");

            // Tell us more about yourself. 
            driver.FindElement(By.XPath("//div[@class='field  ']/textarea")).SendKeys(ExcelLibHelpers.ReadData(2, "Description"));

            // click on save
            driver.FindElement(By.XPath("//button[@class='ui teal button'][@type='button']")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Description has been saved successfully");


            // Click on languages
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
            // Click on Add new Languages
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            // Add langauge
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(ExcelLibHelpers.ReadData(2, "Language"));
            // select language level
            driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            driver.FindElement(By.XPath("//option[@value='Conversational']")).Click();
            // click on Add button
            driver.FindElement(By.XPath("//input[@type='button']")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Hindi has been added to your languages");


            // Click on Skills
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[2]")).Click();
            // Click on Add new Skill
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            // Write your skills
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(ExcelLibHelpers.ReadData(2, "Skills"));
            // click on Skills level
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            // Choose Skill level
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]")).Click();
            // click on ADD button
            driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/input[1]")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Selenium has been added to your skills");

            // Click on Education
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[3]")).Click();
            // Click on Add new Education
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            // Write your Education details
            driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys(ExcelLibHelpers.ReadData(2, "CollegeName"));
            // choose country of college
            driver.FindElement(By.XPath("//select[@name='country']")).Click();
            driver.FindElement(By.XPath("//option[@value='India']")).Click();
            // choose Degree
            driver.FindElement(By.XPath("//select[@name='title']")).Click();
            driver.FindElement(By.XPath("//select[@name='title']/option[7]")).Click();
            // Add Degree name
            driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys(ExcelLibHelpers.ReadData(2, "DegreeName"));
            // choose year of graduation
            driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")).Click();
            driver.FindElement(By.XPath("//select[@name='yearOfGraduation']/option[6]")).Click();
            // click on ADD button
            driver.FindElement(By.XPath("//div[@class='sixteen wide field']/input[1]")).Click();
            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Education has been added");


            // Click on Certification
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[4]")).Click();
            // click on Add New button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
            // Add any certifications if u have
            driver.FindElement(By.XPath("//input[@name='certificationName']")).SendKeys(ExcelLibHelpers.ReadData(2, "CertificateName"));
            // Add ceritied from
            driver.FindElement(By.XPath("//div[@class='eight wide field']/input")).SendKeys(ExcelLibHelpers.ReadData(2, "CertifiedFrom"));
            // Click on year of completion
            driver.FindElement(By.XPath("//select[@name='certificationYear']")).Click();
            // Select on year of completion
            driver.FindElement(By.XPath("//div[@class='three wide field']//option[@value='2016']")).Click();
            // click on Add button
            driver.FindElement(By.XPath("//div[@class='five wide field']//input[@value='Add']")).Click();
            Thread.Sleep(1000);
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, ".Net has been added to your certification");
        }

    }
}
