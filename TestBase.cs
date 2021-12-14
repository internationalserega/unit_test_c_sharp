using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CreationRepositori;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace RepositoriRemovalTest
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected string baseURL;
        private readonly By _inputLoginButton = By.XPath("//input[@name='login']");
        private readonly By _inputPasswordButton = By.XPath("//input[@name='password']");
        private readonly By _InputEnterButton = By.XPath("//input[@name='commit']");

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://github.com/login";
            driver.Manage().Window.Maximize();
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
            }
        }



        protected void AutorizationGit(AccountData account)
        {
            driver.Navigate().GoToUrl(baseURL); //переход на страницу гита
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username); //логин
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(account.Password); //пароль
            driver.FindElement(By.Name("commit")).Click(); //авторизоватся
        }

        protected void CreateRepository(RepositoriName repositoriName)
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='/'])[3]/preceding::*[name()='svg'][1]")).Click();
            driver.FindElement(By.Id("repository_name")).Click();
            driver.FindElement(By.Id("repository_name")).Clear();
            driver.FindElement(By.Id("repository_name")).SendKeys(repositoriName.Name);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form[@id='new_repository']/div[4]/button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@id='code-tab']/span")).Click();
        }

        protected void PageSetingsRepositori()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("internationalserega/Example_C_Sharp_Test")).Click();//кликаем по ссылке репозитория
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='settings-tab']")).Click();//кликаем по настройке репозитория
        }

        protected void DeleteRepositori()
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
