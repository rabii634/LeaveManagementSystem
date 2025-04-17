namespace LeaveManagementSystem.DTOs
{
    public class LeaveRequestQueryDto
    {
        public int? EmployeeId { get; set; }
        public string? Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SortBy { get; set; } = "StartDate";
        public string? SortDirection { get; set; } = "asc";
    }
}
