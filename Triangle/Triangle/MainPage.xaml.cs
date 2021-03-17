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
            Result.Text = GetTriangleType(Int32.Parse(A.Text), Int32.Parse(B.Text), Int32.Parse(C.Text));
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
