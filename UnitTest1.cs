using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Text;


namespace git_web_tests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        //private readonly StringBuilder verificationErrors;
        private string baseURL;
        //private bool acceptNextAlert = true;
        private readonly By _inputLoginButton = By.XPath("//input[@name='login']");
        private readonly By _inputPasswordButton = By.XPath("//input[@name='password']");
        private readonly By _InputEnterButton = By.XPath("//input[@name='commit']");
        private readonly By _InputAvatarButton = By.XPath("//*[@class='Header-link']");
      //private readonly By _InputLogoutButton = By.XPath("");//найти кнопку выйти

        private const string _login = "internationalserega";
        private const string _password = "Z21nonStop21Z";

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://github.com/login";
            driver.Manage().Window.Maximize();
            //verificationErrors = new StringBuilder();
        } 
        public void TestOpnBrowes()
            {
         Console.WriteLine(baseURL);
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
            //Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TestCaseTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(_inputLoginButton).SendKeys(_login);
            driver.FindElement(_inputPasswordButton).SendKeys(_password);
            driver.FindElement(_InputEnterButton).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='/'])[3]/preceding::*[name()='svg'][1]")).Click();
            driver.FindElement(By.Id("repository_name")).Click();
            driver.FindElement(By.Id("repository_name")).Clear();
            driver.FindElement(By.Id("repository_name")).SendKeys("tests_csharp");
            driver.FindElement(By.XPath("//form[@id='new_repository']/div[4]/button")).Click();
            driver.FindElement(By.XPath("//a[@id='code-tab']/span")).Click();
            driver.FindElement(By.XPath("//summary/img")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Settings'])[2]/following::button[1]")).Click();
            driver.FindElement(_InputAvatarButton).Click();
          //driver.FindElement(_InputLogoutButton).Click();
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
