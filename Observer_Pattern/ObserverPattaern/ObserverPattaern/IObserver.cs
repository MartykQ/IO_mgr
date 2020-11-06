using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattaern
{
    public interface IObserver
    {
        void Update(Auction auction);
        void Update(AuctionState state, double highestBid);
    }
}
