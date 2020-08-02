using System;
using System.Collections.Generic;
using System.Text;
using MyCms.DomainClasses.PageGroup;
using MyCms.ViewModels.Page;

namespace MyCms.Services.Repositories
{
    public interface IPageGroupRepository
    {
        //self document
        List<PageGroup> GetAllPageGroups();
        PageGroup GetPageGroupId(int groupId);
        void InsertPageGroup(PageGroup pageGroup);
        void UpdatePageGroup(PageGroup pageGroup);
        void DeletePageGroup(PageGroup pageGroup);
        void DeletePageGroup(int groupId);
        bool PageGroupExists(int pageGroupId);
        List<ShowGroupsViewModel> GetListGroupd();
        void Save();
    }
}
