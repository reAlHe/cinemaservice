using app.Provider;
using Nancy;

namespace app.Adapter
{
    public class MovieModule : NancyModule
    {
        public MovieModule(IMovieProvider provider)
        {
            Get("/movies/{id}", args =>
            {
            int id = int.Parse(args.id);
                return Response.AsJson(provider.GetById((id)));
            });
        }
    }
}
