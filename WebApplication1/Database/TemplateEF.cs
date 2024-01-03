using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public partial class TemplateEF: DbContext
    {
        private IConfiguration _connectionstring;
        public TemplateEF(IConfiguration configuration)
        {
            this._connectionstring = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this._connectionstring.GetConnectionString("connDev"));
            }
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Bst> Bsts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employee1s { get; set; }
        public virtual DbSet<Employee2> Employees1 { get; set; }
        public virtual DbSet<Employees1> Employees1s { get; set; }
        public virtual DbSet<Employees2> Employees2s { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account");

                entity.Property(e => e.AccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("account_id");

                entity.Property(e => e.Dt)
                    .HasColumnType("datetime")
                    .HasColumnName("dt");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Bst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BST");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee1");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("company_code");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .HasColumnName("employee_code");

                entity.Property(e => e.LeadManagerCode)
                    .HasMaxLength(50)
                    .HasColumnName("lead_manager_code");

                entity.Property(e => e.ManagerCode)
                    .HasMaxLength(50)
                    .HasColumnName("manager_code");

                entity.Property(e => e.SeniorManagerCode)
                    .HasMaxLength(50)
                    .HasColumnName("senior_manager_code");
            });

            modelBuilder.Entity<Employee2>(entity =>
            {
                entity.ToTable("Employees");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Employees1>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF17FB97AE9");

                entity.ToTable("Employees1");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Employees__Manag__5CD6CB2B");
            });

            modelBuilder.Entity<Employees2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employees2");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
