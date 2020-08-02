using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCms.Services.Repositories;

namespace MyCms.Components
{
    public class ShowTopPageComponent:ViewComponent
    {
        private IPageRepository _pageRepository;
      
        public ShowTopPageComponent(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ShowTopPageComponent", _pageRepository.GetTopPage()));
        }
    }
}
