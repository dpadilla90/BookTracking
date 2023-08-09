using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    [Key]
    [Column(TypeName = "VARCHAR(255)")]
    public string ISBN { get; set; }

    [Required]
    [Column(TypeName = "VARCHAR(255)")]
    public string Title { get; set; }

    [ForeignKey("Category")]
    [Column(TypeName = "VARCHAR(255)")]
    public string Category_NameToken { get; set; }
    public Category Category { get; set; }

    [Required]
    [Column(TypeName = "VARCHAR(255)")]
    public string Author { get; set; }
}
