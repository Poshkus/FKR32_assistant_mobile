using NUnit.Framework;

namespace FKR32_assistant_mobile_NUitTest
{
    public class AuthServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Login_ShouldReturnTrue()
        {
            //Arrange       //���� ���������� ����������

            var service = new AuthService();

            //Act           // ���� ���������� ������

            var result = true;

            //Assert        // ���� �������� ������

            Assert.IsFalse(result);
        }

        [Test]
        public void Login_ShouldReturnFalse()
        {
            //Arrange       //���� ���������� ����������

            var service = new AuthService();

            //Act           // ���� ���������� ������

            var result = false;

            //Assert        // ���� �������� ������

            Assert.IsTrue(result);
        }
    }
}