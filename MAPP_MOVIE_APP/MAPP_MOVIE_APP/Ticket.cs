using System;
namespace MAPP_MOVIE_APP
{
    public class Ticket
    {
        public string MovieTitle { get; set; }

        public string ReleaseDate { get; set; }

        public string ShowTime { get; set; }

        public string Image { get; set; }

        public string Tags { get; set; }

        public string Cast { get; set; }

        public string StreamingPrice { get; set; }

        public string DVDPrice { get; set; }

        public Ticket(string movietitle, string releasedate, string showtime, string image, string tags, string cast, string streamingprice, string dvdprice)
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
        }
    }
}

