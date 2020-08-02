using Microsoft.AspNetCore.Mvc;
using MyCms.Services.Repositories;

namespace MyCms.Controllers
{
    public class HomeController : Controller
    {
        private IPageRepository _pageRepository;
        public HomeController(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }
        public IActionResult Index()
        {
            ViewData["Slider"] = _pageRepository.GetPageinSlider();

            return View(_pageRepository.GetLatesPage());
        }
    }
}