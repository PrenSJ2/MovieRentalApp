using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MAPP_MOVIE_APP
{
    public partial class MainPage : ContentPage
    {
        //Make reference to the global class
        App globalref = (App)Application.Current;

        public MainPage()
        {
            InitializeComponent();

            //Generate the data
            MainMovieView.ItemsSource = globalref.MovieTicketList.TicketList;
            this.BindingContext = this;
        }

        public Ticket SelectedTicket { get; set; }

        void CartBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Cart());
        }

        void EditBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EditMovie());
        }

        void MainMovieView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                this.Navigation.PushAsync(new Details(SelectedTicket));
            }
        }
    }


}

