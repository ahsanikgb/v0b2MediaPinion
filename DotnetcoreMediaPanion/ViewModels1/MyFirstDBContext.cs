using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotnetcoreMediaPanion.ViewModels1
{
    public partial class MyFirstDBContext : DbContext
    {
        public MyFirstDBContext()
        {
        }

        public MyFirstDBContext(DbContextOptions<MyFirstDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Contect> Contect { get; set; }
        public virtual DbSet<Portfolio> Portfolio { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:ahsanikgb.database.windows.net,1433;Initial Catalog=MyFirstDB;Persist Security Info=True;User ID=ahsanikgb;Password=12Arid2791;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<About>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Service1)
                    .HasColumnName("service1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Service2)
                    .HasColumnName("service2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Service3)
                    .HasColumnName("service3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Service4)
                    .HasColumnName("service4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Service5)
                    .HasColumnName("service5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Service6)
                    .HasColumnName("service6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contect>(entity =>
            {
                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.CompaneyName)
                    .HasColumnName("companeyName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsJoined).HasColumnName("isJoined");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("jobTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("phonenumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("portfolio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Heading)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Src)
                    .HasColumnName("src")
                    .IsUnicode(false);

                entity.Property(e => e.SubHeading).IsUnicode(false);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Heading)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Slider1)
                    .HasColumnName("Slider")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });
        }
    }
}
