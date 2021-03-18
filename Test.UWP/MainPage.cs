using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace Test.UWP
{
    public class MainPage
    {
        protected RemoteWebDriver App => AppManager.App;
        private readonly By firstSideEntry;
        private readonly By secondSideEntry;
        private readonly By thirdSideEntry;
        private readonly By resultEntry;
        private readonly By runButton;

        public const string EquilateralText = "It's Equilateral Triangle!";
        public const string IsoscelesText = "It's Isosceles Triangle!";
        public const string ScaleneText = "It's Scalene Triangle!";
        public const string NotTriangleText = "Triangle doesn't exist!";
        public const string InvalidValues = "";

        public MainPage()
        {
            this.firstSideEntry = By.Name("firstSide");
            this.secondSideEntry = By.Name("secondSide");
            this.thirdSideEntry = By.Name("thirdSide");
            this.resultEntry = By.Name("txtResult");
            this.runButton = By.Name("buttonRun");
        }

        public MainPage SetFirstSide(string number)
        {
            var firstSide = this.App.FindElement(this.firstSideEntry);
            firstSide.SendKeys(number);
            return this;
        }

        public MainPage SetSecondSide(string number)
        {
            var secondSide = this.App.FindElement(this.secondSideEntry);
            secondSide.SendKeys(number);
            return this;
        }

        public MainPage SetThirdSide(string number)
        {
            var thirdSide = this.App.FindElement(this.thirdSideEntry);
            thirdSide.SendKeys(number);
            return this;
        }

        public MainPage ClearAllEntries()
        {
            var firstSide = this.App.FindElement(this.firstSideEntry);
            var secondSide = this.App.FindElement(this.secondSideEntry);
            var thirdSide = this.App.FindElement(this.thirdSideEntry);
            firstSide.Clear();
            secondSide.Clear();
            thirdSide.Clear();
            return this; 
        }

        public void ClickRunButton()
        {
            var run = this.App.FindElement(this.runButton);
            run.Click();
        }

        public string GetResult()
        {
            RemoteWebElement result = this.App.FindElement(this.resultEntry) as RemoteWebElement;
            return result.Text;
        }
    }
}
