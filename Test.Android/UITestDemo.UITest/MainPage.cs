using System;
using System.Linq;
using Xamarin.UITest;

namespace Test.Android
{
    public class MainPage
    {
        protected IApp App;

        public const string firstSideEntry = "firstSide";
        public const string secondSideEntry = "secondSide";
        public const string thirdSideEntry = "thirdSide";
        public const string resultEntry = "txtResult";
        public const string runButton = "buttonRun";

        public const string EquilateralText = "It's Equilateral Triangle!";
        public const string IsoscelesText = "It's Isosceles Triangle!";
        public const string ScaleneText = "It's Scalene Triangle!";
        public const string NotTriangleText = "Triangle doesn't exist!";
        public const string InvalidValues = "";

        public MainPage(IApp app)
        {
            this.App = app;
        }

        public MainPage SetFirstSide(string number)
        {
            this.App.EnterText(firstSideEntry, number);
            return this;
        }

        public MainPage SetSecondSide(string number)
        {
            this.App.EnterText(secondSideEntry, number);
            return this;
        }

        public MainPage SetThirdSide(string number)
        {
            this.App.EnterText(thirdSideEntry, number);
            return this;
        }

        public MainPage ClearAllEntries()
        {
            this.App.ClearText(firstSideEntry);
            this.App.ClearText(secondSideEntry);
            this.App.ClearText(thirdSideEntry);
            return this; 
        }

        public void ClickRunButton()
        {
            this.App.Tap(runButton);
        }

        public string GetResult()
        {
            return this.App.Query(resultEntry).First().Text;
        }
    }
}
