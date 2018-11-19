using System.Linq;
using app.Domain;
using MongoDB.Driver;

namespace app.Provider
{
    public class MovieProvider : IMovieProvider
    {
        private IMongoClient _client;

        private IMongoDatabase _database;

        private static readonly string _collectionname = "movies";

        private static readonly string _dbname = "movies";

        public MovieProvider()
        {
            _client = new MongoClient("mongodb://mongodb:27017");
            _database = _client.GetDatabase(_dbname);
        }

        public Movie GetById(int id)
        {
            var collection = _database.GetCollection<Movie>(_collectionname);
            return collection.AsQueryable()
                    .Where(x => x.Id.Equals(id))
                    .FirstOrDefault();
        }

        public async void Save(Movie movie)
        {
            var collection = _database.GetCollection<Movie>(_collectionname);
            await collection.InsertOneAsync(movie);
        }

        public void SaveWithReservation(Movie movie, Reservation reservation)
        {
            //implement this!
        }

    }
}
