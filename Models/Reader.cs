using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    // Reader.cs
    public class Reader
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Other properties as needed
    }

}
