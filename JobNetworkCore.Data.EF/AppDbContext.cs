using JobNetworkCore.Data.EF.EntityConfigurations;
using JobNetworkCore.Data.Entities;
using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;

namespace JobNetworkCore.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().ToTable("AppRoles").HasKey(x => x.Id);

            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });

            //Config
            new AppUserConfig(modelBuilder.Entity<AppUser>());
        }

        public override int SaveChanges()
        {
            try
            {
                var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
                foreach (EntityEntry item in modified)
                {
                    var changedOrAddedItem = item.Entity as IDateTracking;
                    if (changedOrAddedItem != null)
                    {
                        if (item.State == EntityState.Added)
                        {
                            changedOrAddedItem.DateCreated = DateTime.Now;
                        }
                        changedOrAddedItem.DateModified = DateTime.Now;
                    }
                }
                return base.SaveChanges();
            }
            catch (DbUpdateException entityException)
            {
                var errors = entityException.Message;
                throw new ModelValidationException(entityException.Message);
            }
        }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<CandidateResume> CandidateResumes { get; set; }

        public DbSet<ConfigParam> ConfigParams { get; set; }
        public DbSet<Employer> Employers { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JobLocation> JobLocations { get; set; }
        public DbSet<JobTechnology> JobTechnologys { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }

        public DbSet<Technology> Technologies { get; set; }



    }
}