using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models.VisitorLog
{
    public partial class VisitorLogContext : DbContext
    {
        public VisitorLogContext()
        {
        }

        public VisitorLogContext(DbContextOptions<VisitorLogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<PurposesOfVisit> PurposesOfVisits { get; set; }
        public virtual DbSet<SecurityOfficer> SecurityOfficers { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5QI9MSM; Database=visitor_log;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admins");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(100)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOrganization).HasColumnName("id_organization");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(100)
                    .HasColumnName("patronymic");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("surname");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdOrganization)
                    .HasConstraintName("FK__employees__id_or__286302EC");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("organizations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PurposesOfVisit>(entity =>
            {
                entity.ToTable("purposes_of_visit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SecurityOfficer>(entity =>
            {
                entity.ToTable("security_officers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(100)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.ToTable("visits");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DatetimeOfEntry)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("datetime_of_entry");

                entity.Property(e => e.DatetimeOfExit)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("datetime_of_exit");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(50)
                    .HasColumnName("document_number");

                entity.Property(e => e.IdEmployees).HasColumnName("id_employees");

                entity.Property(e => e.IdPurpose).HasColumnName("id_purpose");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .HasColumnName("note");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(100)
                    .HasColumnName("patronymic");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("surname");

                entity.HasOne(d => d.IdEmployeesNavigation)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.IdEmployees)
                    .HasConstraintName("FK__visits__id_emplo__2B3F6F97");

                entity.HasOne(d => d.IdPurposeNavigation)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.IdPurpose)
                    .HasConstraintName("FK__visits__id_purpo__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
