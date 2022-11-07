using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class Cart : ContentPage
    {

        //Make reference to the global class
        App globalref = (App)Application.Current;


        // Running Total Variables
        public double Subtotal { get; set; }
        public double Discount { get; set; }
        public double FinalTotal { get; set; }
        public double VAT { get; set; }

        public Cart()
        {
            InitializeComponent();
            RunningTotalCalculator();
            CartList.ItemsSource = globalref.MovieOrderList.OrderList;
            this.BindingContext = this;
        }


        public Order SelectedOrder { get; set; }


        // Function to calculate the running total
        void RunningTotalCalculator()
        {
            for (int i = 0; i < globalref.MovieOrderList.OrderList.Count; i++)
            {
                Subtotal += globalref.MovieOrderList.OrderList[i].TotalCost;
            }
            VAT = (Subtotal - Discount) * (double)0.2;
            FinalTotal = Subtotal - VAT;

            Subtotal = Math.Round(Subtotal, 2);
            FinalTotal = Math.Round(FinalTotal, 2);
            VAT = Math.Round(VAT, 2);
            
        }



        void CartList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            int selectedindex = e.SelectedItemIndex;
            if (e.SelectedItem != null)
            {
                //Take the select item as the object (Order)
                Order selectedorder = e.SelectedItem as Order;
                
                //Navigate to Edit Selected Order Details page
                Navigation.PushAsync(new OrderDetails(selectedorder, selectedindex));
            }
        }

        void CheckoutBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Checkout(FinalTotal));
        }


        void CheckCode_Clicked(System.Object sender, System.EventArgs e)
        {
            if (DiscountCodeIn.Text == "10PERCENT")
            {
                Discount = Subtotal * 0.1;
            }
            else if (DiscountCodeIn.Text == "HACKS")
            {
                Discount = Subtotal * 0.99;
            }
            else
            {
                Discount = 0;
            }
            Discount = Math.Round(Discount, 2);
        }
    }
}

