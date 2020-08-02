using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCms.DomainClasses.Page;
using MyCms.Services.Repositories;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MyCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        private IPageRepository _pageRepository;
        private IPageGroupRepository _pageGroupRepository;

        public PagesController(IPageRepository pageRepository, IPageGroupRepository pageGroupRepository)
        {
            _pageRepository = pageRepository;
            _pageGroupRepository = pageGroupRepository;
        }

        // GET: Admin/Pages
        public async Task<IActionResult> Index()
        {
            var myCmsDbContext = _pageRepository.GetAllPage();
            return View(myCmsDbContext);
        }

        // GET: Admin/Pages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = _pageRepository.GetPageById(id.Value);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // GET: Admin/Pages/Create
        public IActionResult Create()
        {
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");
            return View();
        }

        // POST: Admin/Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageID,GroupID,PageTitle,PageShortDesc,PageText,PageVisit,PageImageName,PageTags,PageShowInSlider,RecordDate,MotificationDate")] Page page, IFormFile imgUp)
        {
            if (ModelState.IsValid)
            {
                page.PageVisit = 0;
                page.RecordDate = DateTime.Now;
                page.MotificationDate = DateTime.Now;
                if (imgUp != null)
                {
                    page.PageImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                    string savePath = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/PageImages", page.PageImageName);
                    using (var stream = new FileStream(savePath, FileMode.Create))
                    {
                        await imgUp.CopyToAsync(stream);
                    }
                }
                _pageRepository.InsertPage(page);
                _pageRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle", page.GroupID);
            return View(page);
        }

        // GET: Admin/Pages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = _pageRepository.GetPageById(id.Value);
            if (page == null)
            {
                return NotFound();
            }
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle", page.GroupID);
            return View(page);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageID,GroupID,PageTitle,PageShortDesc,PageText,PageVisit,PageImageName,PageTags,PageShowInSlider,RecordDate,MotificationDate")] Page page, IFormFile imgUp)
        {
            if (id != page.PageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (imgUp != null)
                    {
                        if (page.PageImageName == null)
                        {
                            page.PageImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                        }
                        page.PageImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                        string savePath = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/PageImages", page.PageImageName);
                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                           await imgUp.CopyToAsync(stream);
                        }
                    }

                    _pageRepository.UpdatePage(page);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageExists(page.PageID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle", page.GroupID);
            return View(page);
        }

        // GET: Admin/Pages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = _pageRepository.GetPageById(id.Value);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _pageRepository.DeletePage(id);
            _pageRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageExists(int id)
        {
            return _pageRepository.PageExists(id);
        }
    }
}
