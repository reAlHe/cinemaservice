using System;
using System.Collections;
using System.Collections.Generic;

namespace app.Domain
{
    public class Movie
    {
        private string v1;
        private string v2;

        public Movie(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public long Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public IEnumerable<Seat> Seats
        {
            get;
            set;
        }

        public List<Reservation> Reservations
        {
            get;
            set;
        }
    }
}
