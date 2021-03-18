using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonRunClicked(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.A.Text, out int a)
                && Int32.TryParse(this.B.Text, out int b)
                && Int32.TryParse(this.C.Text, out int c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    this.Result.Text = GetTriangleType(a, b, c);
                    return;
                }
            }

            this.Result.Text = "";
        }

        private string GetTriangleType(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "Triangle doesn't exist!";
            }
            else if (a != b && a != c && b != c)
            {
                return "It's Scalene Triangle!";
            }
            else if (a == b && b == c && c == a)
            {
                return "It's Equilateral Triangle!";
            }
            else
            {
                return "It's Isosceles Triangle!";
            }
        }

    }
}
