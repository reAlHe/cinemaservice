using System;
namespace app.Domain
{
    public class Ordermat
    {
        public event Action<Movie, Reservation> OnNewReservation;

        public async void NewReservation(Movie movie, OrderReservation order)
        {
            var reservation = await order
                .ValidateReservation()
                .NewSeatReservation();

            this.OnNewReservation(movie, reservation);
        }

    }
}
