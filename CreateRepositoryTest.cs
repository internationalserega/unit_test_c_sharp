using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace RepositoriRemovalTest
{
    [TestClass]
    public class CreationRepos : TestBase
    {
        [Test]
        public void CreationRepositori()
        {
            GoToHoMeGit(LoginHelper);
            CreateRepository.AutorizationGit();

            CreateRepository(new ("Example_C_Sharp_Test"));//создание нового репозитория 
        }
    }
}
