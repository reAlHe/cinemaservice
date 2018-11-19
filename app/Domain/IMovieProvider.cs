using app.Domain;

namespace app.Provider
{
    public interface IMovieProvider
    {
        Movie GetById(int id);

        void Save(Movie movie);

        void SaveWithReservation(Movie movie, Reservation reservation);
    }
}
