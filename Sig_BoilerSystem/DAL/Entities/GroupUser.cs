namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupUser")]
    public partial class GroupUser
    {
        public int UserID { get; set; }

        public int GroupID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupUserID { get; set; }

        public virtual Group Group { get; set; }
    }
}
