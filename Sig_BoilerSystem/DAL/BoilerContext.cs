using Sig_BoilerSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sig_BoilerSystem.DAL
{
    class BoilerContext : DbContext
    {
        public BoilerContext()
            : base("name=lsdb")
        {

        }
        public DbSet<GroupPage> GroupPages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }

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
