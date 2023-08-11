using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using BookTracking.Data;

namespace BookTracking.Models
{
    public class CategoryType
    {
        [Key]
        [Column(TypeName = "VARCHAR(255)")]
        public string Type { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }

        // Navigation property to represent categories of this type
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }

}