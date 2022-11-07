using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class MovieDetails : ContentPage
    {
        //make global reference 
        App globalref = (App)Application.Current;

        public int SelectedIndex;

        public Ticket SelectedTicket;

        public MovieDetails(Ticket selectedticket, int selectedindex)
        {
            InitializeComponent();
            SelectedIndex = selectedindex;
            SelectedTicket = selectedticket;
            this.BindingContext = selectedticket;
        }

        void UpdateBtn_Clicked(System.Object sender, System.EventArgs e)
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
            Ticket updatedTicket = new Ticket(movietitle, releasedate, showtime, image, tags, cast, streamingprice, dvdprice);

            // Remove the old Ticket from the collection
            globalref.MovieTicketList.TicketList.RemoveAt(SelectedIndex);

            // Get the collection and Insert new Ticket object at index
            globalref.MovieTicketList.TicketList.Insert(SelectedIndex, updatedTicket);

        }

        void DeleteBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            // Remove a Movie (Ticket) passed
            globalref.MovieTicketList.TicketList.Remove(SelectedTicket);
            // Return To Edit Movie page
            Navigation.PopAsync();
        }
    }
}

