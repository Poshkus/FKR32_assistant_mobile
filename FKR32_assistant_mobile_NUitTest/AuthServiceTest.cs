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
            //Arrange       //этап подготовки Подготовка

            var service = new AuthService();

            //Act           // этап выполнения логики

            var result = true;

            //Assert        // этап проверки логики

            Assert.IsFalse(result);
        }

        [Test]
        public void Login_ShouldReturnFalse()
        {
            //Arrange       //этап подготовки Подготовка

            var service = new AuthService();

            //Act           // этап выполнения логики

            var result = false;

            //Assert        // этап проверки логики

            Assert.IsTrue(result);
        }
    }
}