using NUnit.Framework;
using System.Linq;
using Xamarin.UITest;

namespace FKR32_assistant_mobile_UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class UITest_CalcPage
    {
        IApp app;
        Platform platform;

        public UITest_CalcPage(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Sum_5_To_7_Return_12_UITest()
        {

            //Arrange       //этап подготовки Подготовка

            app.Tap("OpenCalculatorPage");
            app.Screenshot("OpenCalculatorPage");

            app.EnterText("ValueAEntry", "5");
            app.EnterText("ValueAEntry", "7");


            //Act           // этап выполнения логики

            app.Tap("ButtonSumm");

            //Assert        // этап проверки логики

            var sumResult = app.Query("ResultLabel").First(result => result.Text == "12");
            Assert.IsTrue(sumResult != null, "Label is not displaying the right result!");
        }
    }
}
