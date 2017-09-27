using StarWarsApi.ErrorHandler;
using System.Linq;
using System.Web.Http;

namespace api.Controllers
{
    public struct Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class MovieController : ApiController
    {
        Movie[] movies = {
            new Movie{ Id = 1, Title = "The Phantom Menace" },
            new Movie{ Id = 2, Title = "Attack of the Clones" },
            new Movie{ Id = 3, Title = "Revenge of the Sith" },
            new Movie{ Id = 4, Title = "A New Hope" },
            new Movie{ Id = 5, Title = "The Empire Strikes Back" },
            new Movie{ Id = 6, Title = "Return of the Jedi" },
            new Movie{ Id = 7, Title = "The Force Awakens" },
            new Movie{ Id = 8, Title = "The Last Jedi" },
            //new Movie{ Id = 9, Title = "TBA" },
            new Movie{ Id = 10, Title = "Rogue One" }
        };

        public Movie Get(int id)
        {
            return movies.Where(f => f.Id == id).Single();
        }
    }
}