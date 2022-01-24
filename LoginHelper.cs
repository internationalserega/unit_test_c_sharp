using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoriRemovalTest
{
    public class LoginHelper
    {
        private IWebDriver driver;

        public LoginHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AutorizationGit(AccountData account)
        {
            driver.Navigate().GoToUrl(baseURL); //переход на страницу гита
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username); //логин
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(account.Password); //пароль
            driver.FindElement(By.Name("commit")).Click(); //авторизоватся
        }

    }
}
