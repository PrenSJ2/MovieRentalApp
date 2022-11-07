using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class Details : ContentPage
    {
        // Make reference to the global class
        App globalref = (App)Application.Current;
        public Details(Ticket ticket)
        {
            InitializeComponent();
            SelectedTicket = ticket;
            this.BindingContext = this;
        }

        
        public Ticket SelectedTicket { get; set; }

        void CheckoutBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            if (NumDays.Text != "0")
            {
                // Rental Detials 
                string costperday;
                string ordertype;

                // Check which button is selected by checking border color
                if (StreamingBtn.BorderColor == Color.FromHex("#00B7FC"))
                {
                    costperday = StreamingCost.Text;
                    ordertype = "Streaming";
                }
                else
                {
                    costperday = DVDCost.Text;
                    ordertype = "DVD";
                }

                string numofdays = NumDays.Text;

                // Movie Details
                string movietitle = MovieL.Text;
                string releasedate = DateL.Text;
                string showtime = TimeList.Text;
                ImageSource image = MovieP.Source;
                string tags = TagList.Text;
                string cast = CastList.Text;
                string dvdprice = DVDCost.Text;
                string streamingprice = StreamingCost.Text;
                // Create instance of a Order
                Order neworder = new Order(costperday, numofdays, ordertype, movietitle, releasedate, showtime, image, tags, cast, streamingprice, dvdprice);

                // Add a new order to the collection
                globalref.MovieOrderList.OrderList.Add(neworder);

                // Navigate to Cart Page
                this.Navigation.PushAsync(new Cart());
            }
        }

        void StreamingBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => {
                // On Streaming Button Presses

                // Hide DVD cost
                DVDCost.IsVisible = false;
                // Show Streaming cost
                StreamingCost.IsVisible = true;

                // Change button border colors to indicate selected button
                StreamingBtn.BorderColor = Color.FromHex("#00B7FC");
                StreamingBtn.TextColor = Color.FromHex("#00B7FC");
                DVDBtn.BorderColor = Color.FromHex("#FFFFFF");
                DVDBtn.TextColor = Color.FromHex("#FFFFFF");
            });
        }

        void DVDBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => {
                // On Streaming Button Presses

                // Show DVD cost
                DVDCost.IsVisible = true;
                // Hide Streaming cost
                StreamingCost.IsVisible = false;

                // Change button border colors to indicate selected button
                StreamingBtn.BorderColor = Color.FromHex("#FFFFFF");
                StreamingBtn.TextColor = Color.FromHex("#FFFFFF");
                DVDBtn.BorderColor = Color.FromHex("#00B7FC");
                DVDBtn.TextColor = Color.FromHex("#00B7FC");
            });
        }
    }
}

