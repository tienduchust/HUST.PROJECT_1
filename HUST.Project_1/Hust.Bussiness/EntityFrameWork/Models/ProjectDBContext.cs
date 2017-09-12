namespace Hust.Bussiness.EntityFrameWork.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjectDBContext : DbContext
    {
        public ProjectDBContext()
            : base("name=ProjectDBContext")
        {
        }

        public virtual DbSet<StaffMember> StaffMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffMember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMember>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMember>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMember>()
                .Property(e => e.ProfilePhoto)
                .IsUnicode(false);
        }
    }
}
