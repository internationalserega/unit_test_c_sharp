using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoriRemovalTest
{
    public class NavigationHelper
    {

        private IWebDriver driver;
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL)
        {
            this.driver = driver;
            this.baseURL = baseURL;
        }

        public void PageSetingsRepositori()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("internationalserega/Example_C_Sharp_Test")).Click();//кликаем по ссылке репозитория
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='settings-tab']")).Click();//кликаем по настройке репозитория
        }
    }
}
