using System.ComponentModel.DataAnnotations;

namespace Book_Library.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int displayOrder { get; set; }
        public DateTime creationTime { get; set; } = DateTime.Now;
    }
}
