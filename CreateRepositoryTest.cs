using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RepositoriRemovalTest;

namespace CreateRepositoryTest
{
    [TestClass]
    public class CreationRepos : TestBase
    {
        [Test]
        public void CreationRepositori()
        {
            AutorizationGit();//страница атворизации
            CreateRepository(new RepositoriName("Example_C_Sharp_Test"));//создание нового репозитория 
        }
    }
}
