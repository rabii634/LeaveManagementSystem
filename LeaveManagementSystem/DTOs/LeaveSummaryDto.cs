namespace LeaveManagementSystem.DTOs
{
    public class LeaveSummaryDto
    {
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public int TotalLeaves { get; set; }
        public int AnnualLeaves { get; set; }
        public int SickLeaves { get; set; }
    }
}
