namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GroupUser
    {
        public int GroupUserID { get; set; }

        public int GroupID { get; set; }

        public int UserID { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }
    }
}
