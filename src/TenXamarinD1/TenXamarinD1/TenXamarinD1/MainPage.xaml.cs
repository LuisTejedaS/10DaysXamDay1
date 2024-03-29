﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TenXamarinD1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var name = userNameEntry.Text;

            if ( string.IsNullOrWhiteSpace(name))
            {
                DisplayAlert("Error", "You should enter your name", "oh rigth");
            }
            else
            {
                helloLabel.Text = $"Hello {name} ";
            }
        }
    }
}
