using NUnit.Framework;
using Xamarin.UITest;

namespace Test.Android
{
    [TestFixture(Platform.Android)]
    public class ValidTriangleTypesTests : BaseTest
    {

        public ValidTriangleTypesTests(Platform platform) : base(platform)
        {
        }

        [Test]
        public void MinimalEquilateralTriangle()
        {
            this.mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .SetThirdSide("1")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);
        }

        [Test]
        public void EquilateralTrianglesWithSide100()
        {
            this.mainPage.SetFirstSide("100")
                .SetSecondSide("100")
                .SetThirdSide("100")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);
        }

        [Test]
        public void MinimalIsoscelesTriangle()
        {
            this.mainPage.SetFirstSide("1")
                .SetSecondSide("2")
                .SetThirdSide("2")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.IsoscelesText, result);
        }

        [Test]
        public void IsoscelesTriangleWithSides100()
        {
            this.mainPage.SetFirstSide("100")
                .SetSecondSide("100")
                .SetThirdSide("99")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.IsoscelesText, result);
        }

        [Test]
        public void MinimalScaleneTriangle()
        {
            this.mainPage.SetFirstSide("2")
                .SetSecondSide("3")
                .SetThirdSide("4")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.ScaleneText, result);
        }

        [Test]
        public void ScaleneTriangleWithSide100()
        {
            this.mainPage.SetFirstSide("100")
                .SetSecondSide("101")
                .SetThirdSide("102")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.ScaleneText, result);
        }

        [Test]
        public void DifferentTriangles()
        {
            this.mainPage.SetFirstSide("100")
                .SetSecondSide("101")
                .SetThirdSide("102")
                .ClickRunButton();
            var result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.ScaleneText, result);

            this.mainPage.ClearAllEntries();
            this.mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .SetThirdSide("1")
                .ClickRunButton();
            result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);

            this.mainPage.ClearAllEntries();
            this.mainPage.SetFirstSide("2")
                .SetSecondSide("2")
                .SetThirdSide("1")
                .ClickRunButton();
            result = this.mainPage.GetResult();
            Assert.AreEqual(MainPage.IsoscelesText, result);
        }
    }
}
