using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.UWP
{
    [TestClass]
    public class ValidTriangleTypesTests
    {

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            AppManager.StartApp();
        }

        [ClassCleanup]
        public static void TestCleanup()
        {
            AppManager.StopApp();
        }

        [TestCleanup]
        public void ClearEntries()
        {
            var mainPage = new MainPage();
            mainPage.ClearAllEntries();
        }

        [TestMethod]
        public void MinimalEquilateralTriangle()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .SetThirdSide("1")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);
        }

        [TestMethod]
        public void EquilateralTrianglesWithSide100()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("100")
                .SetSecondSide("100")
                .SetThirdSide("100")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);
        }

        [TestMethod]
        public void MinimalIsoscelesTriangle()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("1")
                .SetSecondSide("2")
                .SetThirdSide("2")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.IsoscelesText, result);
        }

        [TestMethod]
        public void IsoscelesTriangleWithSides100()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("100")
                .SetSecondSide("100")
                .SetThirdSide("99")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.IsoscelesText, result);
        }

        [TestMethod]
        public void MinimalScaleneTriangle()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("2")
                .SetSecondSide("3")
                .SetThirdSide("4")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.ScaleneText, result);
        }

        [TestMethod]
        public void ScaleneTriangleWithSide100()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("100")
                .SetSecondSide("101")
                .SetThirdSide("102")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.ScaleneText, result);
        }

        [TestMethod]
        public void DifferentTriangles()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("100")
                .SetSecondSide("101")
                .SetThirdSide("102")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.ScaleneText, result);

            mainPage.ClearAllEntries();
            mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .SetThirdSide("1")
                .ClickRunButton();
            result = mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);

            mainPage.ClearAllEntries();
            mainPage.SetFirstSide("2")
                .SetSecondSide("2")
                .SetThirdSide("1")
                .ClickRunButton();
            result = mainPage.GetResult();
            Assert.AreEqual(MainPage.IsoscelesText, result);
        }

    }
}
