using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hisabware.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required(ErrorMessage ="Category Title is Required.")]
    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string Title { get; set; }

    //[Required(ErrorMessage = "Category Icon is Required.")]
    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]

    public string Icon { get; set; }

    //[Required(ErrorMessage = "Category type is Required.")]
    [Column(TypeName = "nvarchar(50)")]
    public string Type { get; set; } = "Expense";

    [NotMapped]
    public string? TitleWithIcon{
        get
        {
            return this.Icon + " " + this.Title;
        }
    }
}
