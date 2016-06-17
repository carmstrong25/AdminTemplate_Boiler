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
            : base("name=sigdb")
        {

        }
        public DbSet<GroupPage> GroupPages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.GroupPages)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.GroupUsers)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Page>()
                .Property(e => e.PageName)
                .IsUnicode(false);

            modelBuilder.Entity<Page>()
                .HasMany(e => e.GroupPages)
                .WithRequired(e => e.Page)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PassHash)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.SecSal)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GroupUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.CreatedBy);
        }
    }
}
