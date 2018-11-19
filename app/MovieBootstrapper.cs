using Nancy;
using Nancy.Bootstrapper;
using Nancy.Configuration;
using Nancy.TinyIoc;
using app.Domain;
using app.Provider;

namespace app
{
    public class MovieBootstrapper : DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            var config = new TraceConfiguration(enabled: true, displayErrorTraces: true);
            environment.AddValue(config);
        }
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            var movieProvider = new MovieProvider();
            var ordermat = new Ordermat();

            //dummy daten
            movieProvider.Save(new Movie("1", "Star Wars2"));

            ordermat.OnNewReservation += movieProvider.SaveWithReservation;

            container.Register<IMovieProvider>(movieProvider);
            container.Register<Ordermat>(ordermat);
        }

    }
}
