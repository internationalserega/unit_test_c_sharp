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
            AutorizationGit();//�������� �����������
            CreateRepository(new RepositoriName("Example_C_Sharp_Test"));//�������� ������ ����������� 
        }
    }
}
