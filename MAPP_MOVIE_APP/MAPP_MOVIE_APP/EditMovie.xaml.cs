using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MAPP_MOVIE_APP
{
    public partial class EditMovie : ContentPage
    {
        //Make reference to the global class
        App globalref = (App)Application.Current;

        public EditMovie()
        {
            InitializeComponent();
            //Generate the data
            EditMovieView.ItemsSource = globalref.MovieTicketList.TicketList;
            this.BindingContext = this;
        }

        public Ticket SelectedTicket { get; set; }

        //private async void TicketSelected(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        //{
        //    if (e.CurrentSelection != null)
        //    {
        //        //this.Navigation.PushAsync(new Details(SelectedTicket));
        //    }
        //}

        private async void MainMovieView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            
            if (e.CurrentSelection != null)
            {
                // Take the selected Movie as an object
                Ticket selectedticket = SelectedTicket;
                //get selected movie's item idex from list
                int selectedindex = globalref.MovieTicketList.TicketList.IndexOf(selectedticket);

                //Navigate to MovieDetails page
                await Navigation.PushAsync(new MovieDetails(selectedticket,selectedindex));
            }
        }

        void AddMovieBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddMovie());
        }
    }
}

