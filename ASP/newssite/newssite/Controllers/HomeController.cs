using Microsoft.AspNetCore.Mvc;
using newssite.DbData;
using newssite.Models;
using System.Diagnostics;

namespace newssite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<NewsItem> newsItems = new List<NewsItem>();

        public HomeController(ILogger<HomeController> logger, NewsDataContext newsDataContext)
        {
            _logger = logger;

            newsItems = newsDataContext.GetNews();
        }

        public IActionResult Index()
        {
            return View(newsItems);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Games()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
