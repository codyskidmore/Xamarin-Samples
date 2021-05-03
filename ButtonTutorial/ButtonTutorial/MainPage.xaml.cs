using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonTutorial
{
    public partial class MainPage : ContentPage
    {
        private readonly Random _randomGen = new Random();
        public MainPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            ((Button) sender).Text = $"Click me again! {_randomGen.Next(1,100)}";
        }
    }
}
