namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GroupPage
    {
        [Key]
        public int GroupPagesID { get; set; }

        public int GroupID { get; set; }

        public int PageID { get; set; }

        public virtual Group Group { get; set; }

        public virtual Page Page { get; set; }
    }
}
