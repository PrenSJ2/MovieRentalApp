using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class Checkout : ContentPage
    {
        public double FinalTotal;

        public Checkout(double finaltotal)
        {
            InitializeComponent();
            FinalTotal = finaltotal;
            this.BindingContext = this;
        }

        async void PayBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Payment", "Processing", "OK");
        }
    }
}

