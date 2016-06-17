namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group
    {
        public Group()
        {
            GroupPages = new HashSet<GroupPage>();
            GroupUsers = new HashSet<GroupUser>();
        }

        public int GroupID { get; set; }

        [Required]
        [StringLength(50)]
        public string GroupName { get; set; }

        public virtual ICollection<GroupPage> GroupPages { get; set; }

        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
