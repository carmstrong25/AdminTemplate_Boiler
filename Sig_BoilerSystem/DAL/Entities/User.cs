namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public User()
        {
            Users1 = new HashSet<User>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountType { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Passhash { get; set; }

        [Required]
        [StringLength(50)]
        public string SecSalt { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        public int CreatedByID { get; set; }

        public virtual ICollection<User> Users1 { get; set; }

        public virtual User User1 { get; set; }
    }
}
