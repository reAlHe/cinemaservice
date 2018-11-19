using System;
using System.Linq;
using System.Threading.Tasks;

namespace app.Domain
{
    public static class OrderReservationExtensions
    {
        public static OrderReservation ValidateReservation(this OrderReservation order)
        {

            if (order.Movie.Reservations.Any(x => x.SeatNumber == order.SeatNumber))
                throw new InvalidOperationException("reservation is not possible");

            return order.AsValidated();
        }

        public async static Task<Reservation> NewSeatReservation(this OrderReservation order)
        {

            if (!order.IsReservationValidated)
            {
                throw new InvalidOperationException("order is not validated");
            }

            await Task.Run(() => {
                Console.WriteLine("Das ist ein ganz langer Task...");
            });

            return new Reservation
            {
                SeatNumber = order.SeatNumber,
                Name = order.Customer.Name
            };
        }
    }

}
