using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
namespace MAPP_MOVIE_APP
{
    public class Orders
    {
        public ObservableCollection<Order> OrderList;

        public Orders()
        {
            OrderList = new ObservableCollection<Order>();
        }
    }
}

