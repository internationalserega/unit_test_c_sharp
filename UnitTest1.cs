using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Text;


namespace git_web_tests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        //private bool acceptNextAlert = true;
        

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://github.com/login";
            verificationErrors = new StringBuilder();

            
        } 
        
        public void TestOpnBrowes()
        {
            Console.WriteLine(value: baseURL);
            Console.ReadKey();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TestCaseTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("//ul[@id='search-result']/li[2]/div/h2/a/div[2]/span/b[2]")).Click();
            driver.Navigate().GoToUrl("baseTest");
            driver.FindElement(By.Name("commit")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='/'])[3]/preceding::*[name()='svg'][1]")).Click();
            driver.FindElement(By.Id("repository_name")).Click();
            driver.FindElement(By.Id("repository_name")).Clear();
            driver.FindElement(By.Id("repository_name")).SendKeys("tests_csharp");
            driver.FindElement(By.XPath("//form[@id='new_repository']/div[4]/button")).Click();
            driver.FindElement(By.XPath("//a[@id='code-tab']/span")).Click();
            driver.FindElement(By.XPath("//summary/img")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Settings'])[2]/following::button[1]")).Click();
        }
        /*
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
       */ 
    }
}
