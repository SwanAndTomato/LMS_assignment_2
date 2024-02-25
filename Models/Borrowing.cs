using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class Borrowing
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "BookId is required")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "ReaderId is required")]
        public int ReaderId { get; set; }

        [Required(ErrorMessage = "BorrowDate is required")]
        public DateTime BorrowDate { get; set; }

        [Required(ErrorMessage = "ReturnDate is required")]
        public DateTime ReturnDate { get; set; }

 
    }
}
