using Microsoft.AspNetCore.Mvc;

namespace LoanManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLoans()
        {
            var loans = new[]
            {
                new { Id = 1, Borrower = "John Doe", Amount = 10000 },
                new { Id = 2, Borrower = "Jane Smith", Amount = 15000 }
            };

            return Ok(loans);
        }

        [HttpPost]
        public IActionResult CreateLoan()
        {
            return Ok("Loan created successfully");
        }
    }
}