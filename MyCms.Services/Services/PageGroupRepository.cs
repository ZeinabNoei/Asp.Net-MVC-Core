using System;
using System.Collections.Generic;
using System.Text;
using MyCms.DomainClasses.PageGroup;
using MyCms.Services.Repositories;
using MyCms.DataLayer.Contexts;
using System.Linq;
using MyCms.ViewModels.Page;

namespace MyCms.Services.Services
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private MyCmsDbContext _db;
        public PageGroupRepository(MyCmsDbContext db)
        {
            _db = db;
        }
        public void DeletePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

        }

        public void DeletePageGroup(int groupId)
        {
            var group=GetPageGroupId(groupId);
            DeletePageGroup(group);
        }

        public List<PageGroup> GetAllPageGroups()
        {
            return _db.PageGroups.ToList();
        }

        public List<ShowGroupsViewModel> GetListGroupd()
        {
            return _db.PageGroups.Select(g => new ShowGroupsViewModel()
            { 
            GroupID=g.GroupID,
            GroupTitle=g.GroupTitle,
            PageCount=g.Pages.Count
            }).ToList();
        }

        public PageGroup GetPageGroupId(int groupId)
        {
            return _db.PageGroups.Find(groupId);
        }

        public void InsertPageGroup(PageGroup pageGroup)
        {
            _db.PageGroups.Add(pageGroup);
        }

        public bool PageGroupExists(int pageGroupId)
        {
            return _db.PageGroups.Any(p=>p.GroupID==pageGroupId);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void UpdatePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
