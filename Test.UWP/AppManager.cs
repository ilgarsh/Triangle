namespace Test.UWP
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Remote;

    internal static class AppManager
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

        private const string AppId = "7213b318-703e-4158-a947-12102e9cd5ab_t5em43z94cerc!App";

        private static RemoteWebDriver app;

        public static RemoteWebDriver App
        {
            get
            {
                if (app == null)
                {
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                }

                return app;
            }
        }

        public static void StartApp()
        {
            if (app != null)
            {
                return;
            }

            StopApp();

            var opts = new AppiumOptions();
            opts.AddAdditionalCapability("app", AppId);

            app = new RemoteWebDriver(new Uri(WindowsApplicationDriverUrl), opts);
            Assert.IsNotNull(app);
            Assert.IsNotNull(app.SessionId);

            // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
            app.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
        }

        public static void StopApp()
        {
            if (app == null)
            {
                return;
            }

            app.Quit();
            app = null;
        }
    }
}