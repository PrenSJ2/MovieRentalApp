using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MAPP_MOVIE_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        // Rental Order Collection
        public Orders MovieOrderList = GenerateOrders();

        //order list data is generated here
        public static Orders GenerateOrders()
        {
            Orders generatedorders = new Orders();
            ImageSource testImg = ImageSource.FromFile("Tenet.jpg");
            // Test Order
            generatedorders.OrderList.Add(new Order("0.62", "4", "DVD", "test title", "01/01/01", "2hr10mins", testImg, "Test Category", "Test Cast", "2.32", "12.32"));

            return generatedorders;
        }



        // Ticket (Movie) Collection
        public Tickets MovieTicketList = GenerateTickets();

        //Ticket List data is generated here
        public static Tickets GenerateTickets()
        {
            Tickets generatetickets = new Tickets();
            generatetickets.TicketList.Add(new Ticket("Bad Boys for Life", "17/01/2020", "2h4m", "BadBoys.jpg", "Action, Comedy, Crime", "Will Smith, Martin Lawrence", "0.69", "4.20"));
            generatetickets.TicketList.Add(new Ticket("The Old Guard", "10/07/2020", "2h5m", "OldGuard.jpg", "Action, Thriller", "Charlize Theron, KiKi Layne", "0.23", "8.91"));
            generatetickets.TicketList.Add(new Ticket("Tenet", "03/09/2020", "2h30m", "Tenet.jpg", "Sci-Fi, Thriller", "John David Washington, Robert Pattinson", "1.48", "4.36"));
            generatetickets.TicketList.Add(new Ticket("No Time To Die", "08/10/2021", "2h43m", "TimeToDie.jpg", "Action, Adventure, Thriller", "Daniel Craig, Ana de Armas", "2.40", "14.34"));
            return generatetickets;
        }


        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

