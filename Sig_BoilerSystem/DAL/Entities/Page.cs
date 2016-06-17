namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Page
    {
        public Page()
        {
            GroupPages = new HashSet<GroupPage>();
        }

        public int PageID { get; set; }

        [Required]
        [StringLength(50)]
        public string PageName { get; set; }

        public virtual ICollection<GroupPage> GroupPages { get; set; }
    }
}
