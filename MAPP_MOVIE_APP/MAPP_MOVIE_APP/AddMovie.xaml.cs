
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class AddMovie : ContentPage
    {
        //make global reference 
        App globalref = (App)Application.Current;

        public AddMovie()
        {
            InitializeComponent();
        }

        void AddNewMovieBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            // Set the updated records
            string movietitle = MovieNameIn.Text;
            string releasedate = ReleaseDateIn.Text;
            string showtime = TimeIn.Text;
            string image = ImageNameIn.Text;
            string tags = CategoriesIn.Text;
            string cast = CastIn.Text;
            string streamingprice = StreamingPriceIn.Text;
            string dvdprice = DVDPriceIn.Text;

            // Create an object of Ticket (Movie)
            Ticket newTicket = new Ticket(movietitle, releasedate, showtime, image, tags, cast, streamingprice, dvdprice);

            // Add new Ticket to collection
            globalref.MovieTicketList.TicketList.Add(newTicket);

            // Return to Edit Movie Page
            Navigation.PopAsync();
        }
    }
}

