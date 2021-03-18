using NUnit.Framework;
using Xamarin.UITest;

namespace Test.Android
{
    public abstract class BaseTest
    {
        private IApp app;
        protected MainPage mainPage;
        protected Platform platform;

        public BaseTest(Platform platform)
        {
            this.platform = platform;
            this.app = AppInitializer.StartApp(this.platform);
            this.mainPage = new MainPage(this.app);
        }

        [SetUp]
        public void BeforeEachTest()
        {
            try // ugly catching the crash app
            {
                this.mainPage.GetResult();
            }
            catch (System.Net.WebException)
            {
                this.app = AppInitializer.StartApp(this.platform); // restart app if crashed
            }
            this.mainPage.ClearAllEntries();
        }

    }
}
