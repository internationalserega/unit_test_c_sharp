using System;
using NUnit.Framework;

namespace RepositoriRemovalTest
{
    [TestFixture]
    public class RepositoriRemoves : TestBase
    {

        [SetUp]
        public void RemoveTest()
        {
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
            AutorizationGit(account);
            PageSetingsRepositori();
            DeleteRepositori();
        }
    }
}
