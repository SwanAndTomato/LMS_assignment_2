using LMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    // ReaderController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class ReaderController : ControllerBase
    {
        private List<Reader> _readers;

        public ReaderController()
        {
            // Initialize with some example data
            _readers = new List<Reader>
        {
            new Reader { Id = 1, Name = "Reader 1" },
            new Reader { Id = 2, Name = "Reader 2" },
            new Reader { Id = 3, Name = "Reader 3" }
        };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Reader>> GetReaders()
        {
            return _readers;
        }

        // Other action methods for CRUD operations
    }

}
