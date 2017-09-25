using StarWarsApi.ErrorHandler;
using System.Linq;
using System.Web.Http;

namespace api.Controllers
{
    [AiHandleError]
    public class MovieController : ApiController
    {
        (int id, string title)[] films = {
            (1, "The Phantom Menace"),
            (2, "Attack of the Clones"),
            (3, "Revenge of the Sith"),
            (4, "A New Hope"),
            (5, "Empire Strikes Back"),
            (6, "Revenge of the Jedi"),
            (7, "The Force Awakens"),
            (8, "The Last Jedi"),
            //(9, "TBA"),
            (10, "Rogue One")
        };

        [HttpGet]
        public (int id, string title)[] Get()
        {
            return films;
        }

        [HttpGet]
        public (int id, string title) Get(int id)
        {
            return films.Where(f => f.id == id).Single();
        }
    }
}