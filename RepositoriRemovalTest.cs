using System;
using RepositoriRemovalTest;
using Microsoft.VisualStudio.Services.Account;
using NUnit.Framework;

namespace RepositoriRemovalTest
{
    [TestFixture]
    public class RepositoriRemoves : TestBase
    {

    [Test]
        protected void RepositoriRemove()
        {
            LoginHelper.AutorizationGit(new AccountData("chtobinapisat222222222@gmail.com", "Z21nonStop21Z"));//страница атворизации);
            navigator.PageSetingsRepositori();
            DeleteRepositori();
        }
    }
}
