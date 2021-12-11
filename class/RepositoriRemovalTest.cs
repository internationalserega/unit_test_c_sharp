using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace RepositoriRemovalTest
{
    [TestFixture]
    public class RepositoriRemoves
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {

            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
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
        public void RepositoriRemove()
        {
            GoToHomeMyRepositori();
            PageSetingsRepositori();
            DeleteRepositori();
            AutorizationGit();
        }

        private void AutorizationGit()
        {
            driver.Navigate().GoToUrl("https://github.com/"); //переход на страницу гита
            driver.FindElement(By.LinkText("Sign in")).Click(); //переход на страницу выторизации
            driver.FindElement(By.Id("login_field")).Clear();
            driver.FindElement(By.Id("login_field")).SendKeys("internationalserega"); //логин
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Z21nonStop21Z"); //пароль
            driver.FindElement(By.Name("commit")).Click(); //авторизоватся
        }

        private void GoToHomeMyRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='octicon octicon-mark-github v-align-middle']")).Click();//кликаем по логотипу
        }

        private void PageSetingsRepositori()
        {
            driver.FindElement(By.LinkText("internationalserega/Example_C_Sharp_Test")).Click();//кликаем по ссылке репозитория
            driver.FindElement(By.XPath("//span[text()='Settings']")).Click();//кликаем по настройке репозитория
        }
       
        private void DeleteRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='details-reset details-overlay details-overlay-dark flex-md-order-1 flex-order-2']")).Click();
            //кликаем по удалить реозиторий
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/p[2]/strong")).Click();
            //кликаем на названии репозитория
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input")).SendKeys("internationalserega/Example_C_Sharp_Test");
            //запоyяем поле ввода названием репозитория
            driver.FindElement(By.XPath("//span[text()='Delete this repository']")).Click();
            //нажимаем на кнопку удалить репозитория
            driver.FindElement(By.Id("sudo_password")).SendKeys("Z21nonStop21Z");//вводим пароль для удаления репозитория
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();//нажимаем на кнопку подтвердить
        }

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
    }
}