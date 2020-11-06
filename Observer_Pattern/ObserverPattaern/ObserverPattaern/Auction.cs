using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ObserverPattaern
{
    public class Auction : Subject
    {
        private string _name;
        private AuctionStatus _status;
        private Product _product;

        public Auction(string name, AuctionStatus status)
        {
            _name = name;
            _status = status;
        }

        public string Name { get => _name; set => _name = value; }
        public AuctionStatus Status { 
            get { return this._status; }
            set
            {
                if (this.Status.HighestBid < value.HighestBid || this.Status.State != value.State)
                {
                    this._status = value;
                    if (this._status.HighestBid < value.HighestBid);
                    Notify();
                }
            }
        }
        public Product Product { get => _product; set => _product = value; }

        protected override void Notify()
        {
            foreach (IObserver obs in this._observers)
            {
                //Wersja PULL
                obs.Update(this);

                //Wersja PUSH
                //obs.Update(this._status.State, this._status.HighestBid);
            }


        }
    }
}
