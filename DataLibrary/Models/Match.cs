
namespace DataLibrary.Models;

public class Match
{
    public int Id { get; set; }
    public int WinnerId { get; set; }
    public int LoserId { get; set; }

    public virtual Hamster? Hamster { get; set; }
}
