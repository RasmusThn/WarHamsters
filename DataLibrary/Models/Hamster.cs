using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models;

public class Hamster
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Must have a Name")]
    [StringLength(20)]
    public string? Name { get; set; }
    [Required(ErrorMessage = "If no age then no hamster")]
    [Range(1, 5)]
    public int Age { get; set; }

    [Required(ErrorMessage = "Hamster doesn't eat?")]
    [StringLength(20)]
    public string? FavFood { get; set; }
    [Required(ErrorMessage = "Your Hamster atleast Loves you?")]
    [StringLength(20)]
    public string? Loves { get; set; }
    public string? ImgName { get; set; }
    public int Wins { get; set; } = 0;
    public int Defeats { get; set; } = 0;
    public int Games { get; set; } = 0;
    public bool IsActive { get; set; } = true;
}
