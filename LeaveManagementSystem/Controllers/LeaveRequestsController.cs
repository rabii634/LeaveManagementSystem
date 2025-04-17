using LeaveManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.DTOs;
using LeaveManagementSystem.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeaveManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LeaveRequestsController(AppDbContext context)
        {
            _context = context;
        }

        /*[HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.LeaveRequests.Include(l => l.Employee).ToListAsync();
            return Ok(data);
        }*/
        // GET: api/<LeaveRequestsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
          //  return new string[] { "value1", "value2" };
        //}

        // GET api/<LeaveRequestsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        

        // PUT api/<LeaveRequestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LeaveRequestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("report")]
        public async Task<ActionResult<IEnumerable<LeaveSummaryDto>>> GetLeaveReport([FromQuery] int year)
        {
            var result = await _context.LeaveRequests
                .Include(l => l.Employee)
                .Where(l => l.StartDate.Year == year)
                .GroupBy(l => new { l.EmployeeId, l.Employee.FullName, l.Employee.Department })
                .Select(g => new LeaveSummaryDto
                {
                    EmployeeName = g.Key.FullName,
                    Department = g.Key.Department,
                    TotalLeaves = g.Count(),
                    AnnualLeaves = g.Count(l => l.LeaveType == LeaveType.Annual),
                    SickLeaves = g.Count(l => l.LeaveType == LeaveType.Sick)
                })
                .ToListAsync();

            return Ok(result);
        }
        [HttpPost("{id}/approve")]
        public async Task<IActionResult> ApproveLeaveRequest(int id)
        {
            var request = await _context.LeaveRequests.FindAsync(id);
            if (request == null)
                return NotFound();

            if (request.Status != LeaveStatus.Pending)
                return BadRequest("Only pending requests can be approved.");

            request.Status = LeaveStatus.Approved;
            await _context.SaveChangesAsync();

            return Ok("Leave request approved.");
        }

        [HttpGet]
        public async Task<IActionResult> GetLeaveRequests([FromQuery] LeaveRequestQueryDto query)
        {
            var leaveRequests = _context.LeaveRequests.AsQueryable();

            // Filtering
            if (!string.IsNullOrEmpty(query.Status) &&
                Enum.TryParse<LeaveStatus>(query.Status, true, out var parsedStatus))
            {
                leaveRequests = leaveRequests.Where(lr => lr.Status == parsedStatus);
            }

            if (query.FromDate.HasValue)
            {
                leaveRequests = leaveRequests.Where(lr => lr.StartDate >= query.FromDate.Value);
            }

            if (query.ToDate.HasValue)
            {
                leaveRequests = leaveRequests.Where(lr => lr.EndDate <= query.ToDate.Value);
            }

            // Count total before pagination
            var totalItems = await leaveRequests.CountAsync();

            // Apply pagination
            var skip = (query.Page - 1) * query.PageSize;
            var data = await leaveRequests.Skip(skip).Take(query.PageSize).ToListAsync();

            // Return paginated result
            return Ok(new PaginatedResult<LeaveRequest>
            {
                TotalCount = totalItems,
                Page = query.Page,
                PageSize = query.PageSize,
                Data = data
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeaveRequest([FromBody] LeaveRequest request)
        {
            var overlap = await _context.LeaveRequests.AnyAsync(lr =>
                lr.EmployeeId == request.EmployeeId &&
                lr.StartDate <= request.EndDate &&
                lr.EndDate >= request.StartDate
            );

            if (overlap)
            {
                return BadRequest("Overlapping leave request exists for this employee.");
            }

            _context.LeaveRequests.Add(request);
            await _context.SaveChangesAsync();

            return Created("/api/LeaveRequests/" + request.Id, request);
        }


    }
}
