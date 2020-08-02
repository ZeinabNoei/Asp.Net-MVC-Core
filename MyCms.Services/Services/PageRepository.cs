using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MyCms.DomainClasses.Page;
using MyCms.Services.Repositories;
using MyCms.DataLayer.Contexts;

namespace MyCms.Services.Services
{
    public class PageRepository : IPageRepository
    {
        MyCmsDbContext _db;
        public PageRepository(MyCmsDbContext db)
        {
            _db = db;
        }
        public void DeletePage(Page page)
        {
            _db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
           
        }

        public void DeletePage(int pageId)
        {
           var page= GetPageById(pageId);
            DeletePage(page);
        }

        public IEnumerable<Page> GetAllPage()
        {
            return _db.Pages.AsEnumerable();
        }

        public IEnumerable<Page> GetLatesPage()
        {
            return _db.Pages.OrderByDescending(p => p.RecordDate).Take(4).ToList();
        }

        public Page GetPageById(int pageId)
        {
            return _db.Pages.Find(pageId);
        }

        public IEnumerable<Page> GetPageinSlider()
        {
            return _db.Pages.Where(p => p.PageShowInSlider).ToList();
        }

        public IEnumerable<Page> GetPagesByGroupId(int groupId)
        {
            return _db.Pages.Where(P=>P.GroupID==groupId).ToList();
        }

        public IEnumerable<Page> GetTopPage(int take = 4)
        {
            return _db.Pages.OrderByDescending(p => p.PageVisit).Take(take).ToList();
        }

        public void InsertPage(Page page)
        {
            _db.Pages.Add(page);
        }

        public bool PageExists(int id)
        {
            return _db.Pages.Any(p=>p.PageID==id);
        }

        public void Save()
        {
           _db.SaveChanges();
        }

        public IEnumerable<Page> Search(string q)
        {
            var list = _db.Pages.Where(p => p.PageTitle.Contains(q) || p.PageShortDesc.Contains(q) || p.PageText.Contains(q) || p.PageTags.Contains(q)).ToList();

            return list.Distinct().ToList();
        }

        public void UpdatePage(Page page)
        {
            _db.Entry(page).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
