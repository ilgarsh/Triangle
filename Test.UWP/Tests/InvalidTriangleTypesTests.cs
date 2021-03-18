using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.UWP
{
    [TestClass]
    public class InvalidTriangleTypesTests
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
        public void InvalidTriangle()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("1")
                .SetSecondSide("2")
                .SetThirdSide("3")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.NotTriangleText, result);
        }

        [TestMethod]
        public void InvalidTriangleAndValidTriangle()
        {
            var mainPage = new MainPage();
            mainPage.SetFirstSide("0")
                .SetSecondSide("0")
                .SetThirdSide("0")
                .ClickRunButton();
            var result = mainPage.GetResult();
            Assert.AreEqual(MainPage.InvalidValues, result);

            mainPage.ClearAllEntries();
            mainPage.SetFirstSide("1")
                .SetSecondSide("1")
                .SetThirdSide("1")
                .ClickRunButton();
            result = mainPage.GetResult();
            Assert.AreEqual(MainPage.EquilateralText, result);
        }

    }
}
