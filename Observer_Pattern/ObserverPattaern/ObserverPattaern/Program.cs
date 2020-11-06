using System;

namespace ObserverPattaern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Auction auction1 = new Auction("auction 1", new AuctionStatus(200, AuctionState.Open));
            Auction auction2 = new Auction("auction 2", new AuctionStatus(400, AuctionState.Closed));

            User user1 = new User("Jan kowalski");
            User user2 = new User("Marcin Nowak");

            auction1.Attach(user1);
            auction1.Attach(user2);

            auction2.Attach(user2);

            auction1.Status = new AuctionStatus(900, AuctionState.Open);
            auction2.Status = new AuctionStatus(400, AuctionState.Closed);

            auction1.Detach(user1);
            auction1.Status = new AuctionStatus(9000, AuctionState.Open);

        }
    }
}
