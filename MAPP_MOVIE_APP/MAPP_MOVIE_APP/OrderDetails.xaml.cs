using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class OrderDetails : ContentPage
    {
        // Make reference to the global class
        App globalref = (App)Application.Current;

        public int SelectedIndex;

        public Order SelectedOrder { get; set; }

        public OrderDetails(Order order, int selectedindex)
        {
            InitializeComponent();
            SelectedIndex = selectedindex;
            SelectedOrder = order;
            this.BindingContext = this;
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

        void UpdateBtn_Clicked(System.Object sender, System.EventArgs e)
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

                // remove the old Order
                globalref.MovieOrderList.OrderList.RemoveAt(SelectedIndex);


                // Add a new order to the collection
                globalref.MovieOrderList.OrderList.Insert(SelectedIndex, neworder);

                // Navigate to Cart Page
                this.Navigation.PopAsync();
            }
        }

        void DeleteBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            // Add a new order to the collection
            globalref.MovieOrderList.OrderList.Remove(SelectedOrder);

            // Navigate to Cart Page
            this.Navigation.PopAsync();
        }
    }
}

