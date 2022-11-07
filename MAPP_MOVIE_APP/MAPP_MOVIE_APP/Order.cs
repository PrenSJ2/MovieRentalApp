using System; 
using System.Collections.Generic;
using Xamarin.Forms;
namespace MAPP_MOVIE_APP
{
    public class Order
    {
        // Movie Details
        public string MovieTitle { get; set; }

        public string ReleaseDate { get; set; }

        public string ShowTime { get; set; }

        public ImageSource Image { get; set; }

        public string Tags { get; set; }

        public string Cast { get; set; }

        public string StreamingPrice { get; set; }

        public string DVDPrice { get; set; }

        // Specific detail of movie rental
        public float CostPerDay { get; set; }

        public float NumOfDays { get; set; }

        public float TotalCost { get; set; }

        public string OrderType { get; set; }

        public string Symbol { get; set; }

        public Order(string costperday, string numofdays, string ordertype, string movietitle, string releasedate, string showtime, ImageSource image, string tags, string cast, string streamingprice, string dvdprice)
        {
            // Details of movie
            MovieTitle = movietitle;
            ReleaseDate = releasedate;
            ShowTime = showtime;
            Image = image;
            Tags = tags;
            Cast = cast;
            StreamingPrice = streamingprice;
            DVDPrice = dvdprice;
            // Details of movie rental
            OrderType = ordertype;
            CostPerDay = float.Parse(costperday);
            NumOfDays = float.Parse(numofdays);
            TotalCost = CostPerDay * NumOfDays;
            Symbol = "£";
        }
    }
}

