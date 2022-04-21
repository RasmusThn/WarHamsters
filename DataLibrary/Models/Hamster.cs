using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models;

public class Hamster
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Must have a Name")]
    public string? Name { get; set; }
    [Required(ErrorMessage ="If no age then no hamster")]
    public int Age { get; set; }
    public string? FavFood { get; set; }
    public string? Loves { get; set; }
    [Required(ErrorMessage ="Can't add Hamster without image")]
    public string? ImgName { get; set; }
    public int Wins { get; set; } = 0;
    public int Defeats { get; set; } = 0;
    public int Games { get; set; } = 0;
}
