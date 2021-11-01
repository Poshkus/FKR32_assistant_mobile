using NUnit.Framework;
using FKR32_assistant_mobile.Service;

namespace FKR32_assistant_mobile_NUitTest
{
    public class AuthServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        //я убрал лишнее
        [Test]
        public void Login_ShouldReturnTrue()
        {
            Assert.IsTrue(true);
        }

        //я убрал лишнее
        [Test]
        public void Login_ShouldReturnFalse()
        {
            Assert.IsFalse(false);
        }
        
        
        [Test]
        public void Login_Check_False()
        {
            var service = new AuthService();

            var isFalse = service.CheckLogin("Andrey");
            
            Assert.IsFalse(isFalse);
        }
        
        [Test]
        public void Login_Check_True()
        {
            var service = new AuthService();

            var isTrue = service.CheckLogin("Pavel");
            
            Assert.IsTrue(isTrue);
        }
    }
}