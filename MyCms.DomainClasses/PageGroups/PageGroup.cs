using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCms.DomainClasses.PageGroup
{
    public class PageGroup
    {
        public PageGroup()
        {

        }
        [Key]
        public int GroupID { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(200)]
        public string GroupTitle { get; set; }
        [Display(Name = "CreateDate")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "MotificationDate")]
        public DateTime MotificationDate { get; set; }

        //Navigation Property
        public virtual List<Page.Page> Pages { get; set; }
    }
}
