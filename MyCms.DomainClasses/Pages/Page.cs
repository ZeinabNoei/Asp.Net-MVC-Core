using System;
using System.ComponentModel.DataAnnotations;

namespace MyCms.DomainClasses.Page
{
    public class Page
    {
        public Page()
        {

        }
        [Key]
        public int PageID { get; set; }

        [Display(Name = "GroupTitle")]
        public int GroupID { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(400)]
        public string PageTitle { get; set; }

        [Display(Name = "ShortDescription")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string PageShortDesc { get; set; }

        [Display(Name = "Text")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [DataType(DataType.MultilineText)]
        public string PageText { get; set; }

        [Display(Name = "Visit")]
        public int PageVisit { get; set; }

        [Display(Name = "ImageName")]
        public string PageImageName { get; set; }

        [Display(Name = "Tags")]
        public string PageTags { get; set; }

        [Display(Name = "ShowInSlider")]
        public bool PageShowInSlider { get; set; }

        [Display(Name = "CreateDate")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "MotificationDate")]
        public DateTime MotificationDate { get; set; }

        //Navigation Property
        public virtual PageGroup.PageGroup PageGroup { get; set; }
    }
}
