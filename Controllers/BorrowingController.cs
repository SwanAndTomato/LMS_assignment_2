using LMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    // BorrowingController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowingController : ControllerBase
    {
        private List<Borrowing> _borrowings;

        public BorrowingController()
        {
            // Initialize with some example data
            _borrowings = new List<Borrowing>
        {
            new Borrowing { Id = 1, BookId = 1, ReaderId = 1, BorrowDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(7) },
            new Borrowing { Id = 2, BookId = 2, ReaderId = 2, BorrowDate = DateTime.Now.AddDays(-7), ReturnDate = DateTime.Now }
        };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Borrowing>> GetBorrowings()
        {
            return _borrowings;
        }

    }

}
