using RepositoriRemovalTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RepositoriRemovalTest;

namespace RepositoriRemovalTest
{
    [TestClass]
    public class CreationRepos : TestBase
    {
        [Test]
        public void CreationRepositori()
        {
            LoginHelper.AutorizationGit(new AccountData("chtobinapisat222222222@gmail.com", "Z21nonStop21Z"));//страница атворизации
            CreateRepository(new ("Example_C_Sharp_Test"));//создание нового репозитория 
        }
    }
}
