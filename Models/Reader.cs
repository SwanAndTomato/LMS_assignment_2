using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    // Reader.cs
    public class Reader
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

 
    }

}
