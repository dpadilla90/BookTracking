using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using BookTracking.Data;

namespace BookTracking.Models
{
   public class Category
    {
        [Key]
        [Column(TypeName = "VARCHAR(255)")]
        public string NameToken { get; set; }

        [ForeignKey("CategoryTypeEntity")]
        [Column(TypeName = "VARCHAR(255)")]
        public string CategoryType { get; set; }
        public CategoryType CategoryTypeEntity { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Description { get; set; }

        // Navigation property to represent books in this category
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }

}