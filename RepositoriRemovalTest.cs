using System;
using CreationRepositori;
using NUnit.Framework;

namespace RepositoriRemovalTest
{
    [TestFixture]
    public class RepositoriRemoves : TestBase
    {

    [Test]
        protected void RepositoriRemove()
        {
            AutorizationGit(account);
            PageSetingsRepositori();
            DeleteRepositori();
        }
    }
}
