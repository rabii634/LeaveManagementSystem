using LeaveManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace LeaveManagementSystem.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, FullName = "rabii boughariou", Department = "HR", JoiningDate = DateTime.Now.AddYears(-3) },
            new Employee { Id = 2, FullName = "ahmed rebai", Department = "IT", JoiningDate = DateTime.Now.AddYears(-2) },
            new Employee { Id = 3, FullName = "ala kammoun", Department = "Finance", JoiningDate = DateTime.Now.AddYears(-1) },
            new Employee { Id = 4, FullName = "yasmine abed", Department = "Marketing", JoiningDate = DateTime.Now.AddYears(-4) }

        );
        modelBuilder.Entity<LeaveRequest>().HasData(
       new LeaveRequest { Id = 1, EmployeeId = 1, LeaveType = LeaveType.Annual, StartDate = new DateTime(2025, 4, 10), EndDate = new DateTime(2025, 4, 12), Status = LeaveStatus.Approved, Reason = "Vacation", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 2, EmployeeId = 1, LeaveType = LeaveType.Sick, StartDate = new DateTime(2025, 4, 15), EndDate = new DateTime(2025, 4, 16), Status = LeaveStatus.Pending, Reason = "Flu", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 3, EmployeeId = 2, LeaveType = LeaveType.Other, StartDate = new DateTime(2025, 5, 1), EndDate = new DateTime(2025, 5, 3), Status = LeaveStatus.Rejected, Reason = "Conference", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 4, EmployeeId = 2, LeaveType = LeaveType.Annual, StartDate = new DateTime(2025, 6, 5), EndDate = new DateTime(2025, 6, 10), Status = LeaveStatus.Approved, Reason = "Family trip", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 5, EmployeeId = 3, LeaveType = LeaveType.Sick, StartDate = new DateTime(2025, 4, 20), EndDate = new DateTime(2025, 4, 22), Status = LeaveStatus.Pending, Reason = "Flu symptoms", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 6, EmployeeId = 4, LeaveType = LeaveType.Other, StartDate = new DateTime(2025, 5, 15), EndDate = new DateTime(2025, 5, 16), Status = LeaveStatus.Approved, Reason = "Workshop", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 7, EmployeeId = 3, LeaveType = LeaveType.Annual, StartDate = new DateTime(2025, 7, 10), EndDate = new DateTime(2025, 7, 15), Status = LeaveStatus.Approved, Reason = "Holiday", CreatedAt = DateTime.Now },
       new LeaveRequest { Id = 8, EmployeeId = 4, LeaveType = LeaveType.Sick, StartDate = new DateTime(2025, 4, 2), EndDate = new DateTime(2025, 4, 4), Status = LeaveStatus.Rejected, Reason = "Flu", CreatedAt = DateTime.Now }
     );
    }
}

