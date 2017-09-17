using Hust.Models.Domain;

namespace Hust.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppHustContext : DbContext
    {
        // Your context has been configured to use a 'AppHustContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hust.Models.AppHustContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AppHustContext' 
        // connection string in the application configuration file.
        public AppHustContext()
            : base("name=Hust_Project_1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<JobInformation> JobInformations { get; set; }
        public virtual DbSet<JobPosition> JobPositions { get; set; }
        public virtual DbSet<PaymentConfirmation> PaymentConfirmations { get; set; }
        public virtual DbSet<ProcessManager> ProcessManagers { get; set; }
        public virtual DbSet<ProcessManagerUser> ProcessManagerUsers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobInformation>()
                .Property(e => e.JobInformationID)
                .IsUnicode(false);

            modelBuilder.Entity<JobInformation>()
                .Property(e => e.JobDoneBy)
                .IsUnicode(false);

            modelBuilder.Entity<JobInformation>()
                .Property(e => e.JobStatus)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosition>()
                .Property(e => e.JobPositionID)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosition>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentConfirmation>()
                .Property(e => e.PaymentID)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentConfirmation>()
                .Property(e => e.ProjectID)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentConfirmation>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentConfirmation>()
                .Property(e => e.AmountOfPayment)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentConfirmation>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessManager>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessManager>()
                .Property(e => e.JobPositionID)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessManager>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessManagerUser>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessManagerUser>()
                .Property(e => e.ProjectID)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessManagerUser>()
                .Property(e => e.JobPositionID)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectID)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.ProfilePhoto)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.LogUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.StatusID)
                .IsUnicode(false);

            modelBuilder.Entity<UserCompany>()
                .Property(e => e.JobPositionID)
                .IsUnicode(false);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}