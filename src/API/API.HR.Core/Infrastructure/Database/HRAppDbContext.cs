﻿using API.HR.Core.Feature.Domain;
using API.HR.Core.Feature.Domain.Exemple;
using API.HR.Core.Infrastructure.Database.Mappings;
using Microsoft.EntityFrameworkCore;

namespace API.HR.Core.Infrastructure.Database;

/// <summary>
/// Represents the database context for the Exemple application.
/// Provides access to database entities and configurations.
/// </summary>
public class HRAppDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HRAppDbContext"/> class.
    /// Default constructor required for design-time tools.
    /// </summary>
    public HRAppDbContext()
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="HRAppDbContext"/> class with the specified options.
    /// </summary>
    /// <param name="options">The database context options.</param>
    public HRAppDbContext(DbContextOptions<HRAppDbContext> options) : base(options)
    { }

    /// <summary>
    /// Gets or sets the database set for Exemple entities.
    /// </summary>
    public virtual DbSet<ExempleEntity> Exemple { get; set; }


    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Benefit> Benefits { get; set; }
    public DbSet<PerformanceReview> PerformanceReviews { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<Attendance> Attendances { get; set; }

    /// <summary>
    /// Configures the entity models and applies configurations when the database schema is created.
    /// </summary>
    /// <param name="modelBuilder">The model builder used to configure entity models.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ExempleConfiguration());

        modelBuilder.ApplyConfiguration(new EmployeeMap());
        modelBuilder.ApplyConfiguration(new DepartmentMap());
        modelBuilder.ApplyConfiguration(new PositionMap());
        modelBuilder.ApplyConfiguration(new BenefitMap());
        modelBuilder.ApplyConfiguration(new PerformanceReviewMap());
        modelBuilder.ApplyConfiguration(new PayrollMap());
        modelBuilder.ApplyConfiguration(new LeaveRequestMap());
        modelBuilder.ApplyConfiguration(new AttendanceMap());
    }

    /// <summary>
    /// Configures the database options, including logging settings.
    /// </summary>
    /// <param name="optionsBuilder">The options builder used to configure the database context.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLoggerFactory(_loggerFactory);
        base.OnConfiguring(optionsBuilder);
    }

    /// <summary>
    /// Logger factory for debugging database queries.
    /// </summary>
    public static readonly LoggerFactory _loggerFactory = new LoggerFactory(new[] {
        new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()
    });
}
