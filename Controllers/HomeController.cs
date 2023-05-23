using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Projecte_DAW.Models;

namespace Projecte_DAW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            const string apiUrl = "https://valorant-api.com/v1/agents";

            var client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            var model = JsonConvert.DeserializeObject<Root>(content);
            return View(model);
        }

        public IActionResult Privacy()
        {
            const string Url = "https://valorant-api.com/v1/agents";
            var client = new HttpClient();
            var response = client.GetAsync(Url).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            var model1 = JsonConvert.DeserializeObject<Root>(content);

            return View(model1);
        }

        public IActionResult Index1()
        {
            const string Url2 = "https://valorant-api.com/v1/agents";
            var client = new HttpClient();
            var response = client.GetAsync(Url2).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            var model2 = JsonConvert.DeserializeObject<Root>(content);

            return View(model2);
        }

    }
}
