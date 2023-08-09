using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
}