using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Produces("application/json")]
    [Route("api/MovieQuote")]
    public class MovieQuoteController : Controller
    {
        string[] database = new[] {
            "What is this? A school for ants?",
            "My Mama always said, 'Life was like a box of chocolates; you never know what you're gonna get.",
            "I have come here to chew bubble gum and kick ass. And I'm all out of bubble gum.",
            "I love the smell of napalm in the morning...Smells like victory.",
            "Yippee-ki-yay, motherf.. *kuch*!",
        };

        // GET api/MovieQuote
        [HttpGet]
        public MovieQuote Get([FromQuery]string keywords)
        {
            Random random = new Random();
            return new MovieQuote
            {
                Quote = database[random.Next(database.Length)]
            };
        }

    }
}