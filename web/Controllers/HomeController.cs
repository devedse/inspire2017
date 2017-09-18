using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using api.Models;
using web.Configuration;
using Microsoft.Extensions.Options;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private MyAppSettings myAppSettings;

        public HomeController(IOptions<MyAppSettings> options)
        {
            myAppSettings = options.Value;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(myAppSettings.Api_Url);
            var movieQuote = JsonConvert.DeserializeObject<MovieQuote>(response);

            ViewData["Message"] = movieQuote.Quote;
            ViewData["OSInfo"] = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
