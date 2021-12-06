using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Text;
using System.Threading;

namespace GitHubTests
{
    [TestClass]
    public class CreationRepos
    {
        private IWebDriver driver;
        private string baseURL;
        private readonly By _inputLoginButton = By.XPath("//input[@name='login']");
        private readonly By _inputPasswordButton = By.XPath("//input[@name='password']");
        private readonly By _InputEnterButton = By.XPath("//input[@name='commit']");

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
        public void CreationRepositori()
        {
            OpenAutorizationPage();//страница атворизации
            LoginPassword("internationalserega", "Z21nonStop21Z");//ввод логина и пароля 
            Thread.Sleep(4000);
            CreateRepository("Exampl_C_Sharp_Test");//создание нового репозитория 
        }

        private void CreateRepository(string _nameRopesitory)
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='/'])[3]/preceding::*[name()='svg'][1]")).Click();
            driver.FindElement(By.Id("repository_name")).Click();
            driver.FindElement(By.Id("repository_name")).Clear();
            driver.FindElement(By.Id("repository_name")).SendKeys(_nameRopesitory);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form[@id='new_repository']/div[4]/button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@id='code-tab']/span")).Click();
        }
        private void LoginPassword(string _login, string _password)
        {
            driver.FindElement(_inputLoginButton).SendKeys(_login);
            driver.FindElement(_inputPasswordButton).SendKeys(_password);
            driver.FindElement(_InputEnterButton).Click();
        }
        private void OpenAutorizationPage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
    }
}
