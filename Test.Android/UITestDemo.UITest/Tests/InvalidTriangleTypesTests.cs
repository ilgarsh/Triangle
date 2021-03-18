using NUnit.Framework;
using Xamarin.UITest;

namespace Test.Android
{
    [TestFixture(Platform.Android)]
    public class InvalidTriangleTypesTests : BaseTest
    {

        public InvalidTriangleTypesTests(Platform platform) : base(platform)
        {
        }

        [Test]
        public void InvalidTriangle()
        {
            this.mainPage.SetFirstSide("1")
                .SetSecondSide("2")
                .SetThirdSide("3")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.NotTriangleText, result);
        }

        [Test]
        public void InvalidTriangleAndValidTriangle()
        {
            this.mainPage.SetFirstSide("0")
                .SetSecondSide("0")
                .SetThirdSide("0")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.InvalidValues, result);

            this.mainPage.ClearAllEntries();
            this.mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .SetThirdSide("1")
                .ClickRunButton();
            result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);
        }

    }
}
