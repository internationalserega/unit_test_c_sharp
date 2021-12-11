using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace RepositoriRemovalTest
{
    [TestFixture]
    public class RepositoriRemoves
    {
        private IWebDriver driver;
        private string baseURL;

        [SetUp]
        public void SetupTest()
        {

            driver = new ChromeDriver();
            baseURL = "https://github.com/login";
            driver.Manage().Window.Maximize();

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

            }

        }

        [Test]
        public void RepositoriRemove()
        {
            AutorizationGit();
            GoToHomeMyRepositori();
            PageSetingsRepositori();
            DeleteRepositori();
        }

        private void AutorizationGit()
        {
            driver.Navigate().GoToUrl(baseURL); //переход на страницу гита
            Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("Sign in")).Click(); //переход на страницу выторизации
            //driver.FindElement(By.Id("login_field")).Clear();
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
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("internationalserega/Example_C_Sharp_Test")).Click();//кликаем по ссылке репозитория
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='settings-tab']")).Click();//кликаем по настройке репозитория
        }

        private void DeleteRepositori()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@class='details-reset details-overlay details-overlay-dark flex-md-order-1 flex-order-2']")).Click();
            //кликаем по удалить реозиторий
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/p[2]/strong")).Click();
            //кликаем на названии репозитория
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input")).SendKeys("internationalserega/Example_C_Sharp_Test");
            //запоyяем поле ввода названием репозитория
            //Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='I understand the consequences, delete this repository']")).Click();
            //нажимаем на кнопку удалить репозитория
        }
    }
}