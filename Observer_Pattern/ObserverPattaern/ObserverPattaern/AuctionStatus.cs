using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattaern
{

    public enum AuctionState{
        Open,
        Closed,
    };
    public class AuctionStatus
    {
        private double _highestBid;
        private AuctionState _state;

        public AuctionStatus(double highestBid, AuctionState state)
        {
            _highestBid = highestBid;
            State = state;
        }

        public double HighestBid { get => _highestBid; set => _highestBid = value; }
        public AuctionState State { get => _state; set => _state = value; }
    }
}
