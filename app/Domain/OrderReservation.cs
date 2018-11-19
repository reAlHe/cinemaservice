using System;
namespace app.Domain
{
    public class OrderReservation
    {
        public Movie Movie
        {
            get;
            set;
        }

        public bool IsReservationValidated
        {
            get;
            private set;
        }

        public Customer Customer
        {
            get;
            set;
        }

        public int SeatNumber
        {
            get;
            set;
        }

        public OrderReservation AsValidated() {
            return new OrderReservation{ Movie = this.Movie, IsReservationValidated = true, Customer = this.Customer, SeatNumber = this.SeatNumber };
        }
    }
}
