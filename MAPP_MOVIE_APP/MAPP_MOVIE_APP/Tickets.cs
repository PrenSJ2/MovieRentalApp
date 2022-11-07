using System;
using System.Collections.ObjectModel;

namespace MAPP_MOVIE_APP
{
    public class Tickets
    {
        public ObservableCollection<Ticket> TicketList;

        public Tickets()
        {
            TicketList = new ObservableCollection<Ticket>();
        }
    }
}

