using Microsoft.AspNetCore.Mvc;
using newssite.DbData;
using newssite.Models;

namespace newssite.Controllers
{
    public class EditorController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewsDataContext context;

        public EditorController(ILogger<HomeController> logger, NewsDataContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [HttpGet]
        public IActionResult index()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] NewsItem item)
        {
            PostEditViewModel model = new PostEditViewModel()
            {
                Error = ""
            };
            if (String.IsNullOrEmpty(item.Title))
            {
                model.Error = "Title null or empty";
                return View(model);
            }
            if (String.IsNullOrEmpty(item.Content))
            {
                model.Error = "Content null or empty";
                return View(model);
            }
            if (String.IsNullOrEmpty(item.ImageUrl))
            {
                model.Error = "ImageUrl null or empty";
                return View(model);
            }

            context.AddNews(item);
            model.Result = item;
            return View(model);
        }
    }
}
