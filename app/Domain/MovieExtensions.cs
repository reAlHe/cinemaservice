using System;
using System.Collections.Generic;
using System.Linq;

namespace app.Domain
{
    public static class MovieExtensions
    {
        public static IEnumerable<Seat> getAllReservedSeats(this Movie movie)
        {
            return (from seat in movie.Seats
                    join res in movie.Reservations on seat.Number equals res.SeatNumber
                    select seat);
        }

        public static IEnumerable<Seat> getAllReservedSeats2(this Movie movie)
        {
            return movie.Seats.Where(x => x.Number == 1);
        }
    }

}
