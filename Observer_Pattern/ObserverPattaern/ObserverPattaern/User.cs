using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattaern
{
    class User : IObserver
    {
        private string _userName;

        public User(string userName)
        {
            _userName = userName;
        }

        public string UserName { get => _userName; set => _userName = value; }

        //Wersja PULL
        public void Update(Auction auction)
        {
            Console.WriteLine($"Auction observed by {this._userName}" +
                $" has been updated. Highest bid is now {auction.Status.HighestBid}, state is {auction.Status.State}");
        }

        //wersja PUSH
        public void Update(AuctionState state, double highestBid)
        {
            Console.WriteLine($"Auction observed by {this._userName}" +
                $" has been updated. Highest bid is now {state}, state is {highestBid}");
        }
    }
}
