using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCms.Services.Repositories;

namespace MyCms.Controllers
{
    public class NewsController : Controller
    {
        private IPageRepository pageRepository;
        public NewsController(IPageRepository pageRepository)
        {
            this.pageRepository = pageRepository;
        }
        [Route("News/{newId}")]
        public IActionResult ShowNews(int newId)
        {
            var page = pageRepository.GetPageById(newId);
            if (page!= null)
            {
                page.PageVisit += 1;
                pageRepository.UpdatePage(page);
                pageRepository.Save();
            }
            return View(page);
        }
        [Route("Group/{groupId}/{title}")]
        public IActionResult ShowNewsByGroupId(int groupId,string title)
        {
            ViewData["GroupTitle"] = title;
            return View(pageRepository.GetPagesByGroupId(groupId));
        }
        [Route("Search")]
        public IActionResult Search(string q)
        {
            return View(pageRepository.Search(q));
        }
    }
}