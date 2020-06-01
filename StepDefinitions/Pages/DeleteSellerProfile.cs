using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMars.Pages
{
    class DeleteSellerProfile
    {
        public void DeleteProfile(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // click on language
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[1]")).Click();
            
            // Delete Language
            driver.FindElement(By.XPath("//td[contains(text(),'English')]//following-sibling::td[@class='right aligned']/span[2]/i")).Click();

            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "English has been deleted from your languages");

            // Click on Skills
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[2]")).Click();

            // Delete Skills
            driver.FindElement(By.XPath("//td[contains(text(),'Selenium Web')]//following-sibling::td[@class='right aligned']/span[2]/i")).Click();

            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Selenium Web Driver has been deleted");

            // Click on Education
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[3]")).Click();

            // Delete Education
            driver.FindElement(By.XPath("//td[contains(text(),'2016' )]//following-sibling::td[@class='right aligned']/span[2]/i")).Click();

            Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "Education entry successfully removed");

            // Click on Certificate
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']/a[4]")).Click();

            // Delete Certificates
            driver.FindElement(By.XPath("//td[contains(text(),'JavaScript' )]//following-sibling::td[@class='right aligned']/span[2]/i")).Click();

             Thread.Sleep(1000);
            // Verify Sucessfull message
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[1]/div")).Text, "JavaScript has been deleted from your certification");

        }
    }
}
