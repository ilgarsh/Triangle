using NUnit.Framework;
using Xamarin.UITest;

namespace Test.Android
{
    [TestFixture(Platform.Android)]
    public class InvalidInputTests : BaseTest
    {

        public InvalidInputTests(Platform platform) : base(platform)
        {
        }

        [Test]
        public void ClickRunWithEmptyEntries()
        {
            this.mainPage.ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(result, MainPage.InvalidValues);
        }

        [Test]
        public void ClickRunWithOneEmptyEntry()
        {
            this.mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(result, MainPage.InvalidValues);
        }

        [Test]
        public void StringInEntries()
        {
            this.mainPage.SetFirstSide("first")
                .SetSecondSide("second")
                .SetThirdSide("third")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(result, MainPage.InvalidValues);
        }

        [Test]
        public void StringAndNumberInEntries()
        {
            this.mainPage.SetFirstSide("1f")
                .SetSecondSide("s2")
                .SetThirdSide("t3h")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(result, MainPage.InvalidValues);
        }

        [Test]
        public void NegativeNumbers()
        {
            this.mainPage.SetFirstSide("-1")
                .SetSecondSide("-1")
                .SetThirdSide("-1")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(result, MainPage.InvalidValues);
        }

        [Test]
        public void FloatNumbers()
        {
            this.mainPage.SetFirstSide("1.3")
                .SetSecondSide("1.3")
                .SetThirdSide("1.3")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(result, MainPage.InvalidValues);
        }

        [Test]
        public void InvalidTriangleWithZeroSides()
        {
            this.mainPage.SetFirstSide("0")
                .SetSecondSide("0")
                .SetThirdSide("0")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.InvalidValues, result);
        }


    }
}
