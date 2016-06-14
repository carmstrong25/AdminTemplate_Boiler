namespace Sig_BoilerSystem.DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<GroupPage> GroupPages { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupPage>()
                .HasOptional(e => e.Group)
                .WithRequired(e => e.GroupPage);

            modelBuilder.Entity<Group>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.GroupUsers)
                .WithRequired(e => e.Group)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Page>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Page>()
                .HasMany(e => e.GroupPages)
                .WithRequired(e => e.Page)
                .HasForeignKey(e => e.PageID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Passhash)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.SecSalt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.CreatedByID);
        }
    }
}
