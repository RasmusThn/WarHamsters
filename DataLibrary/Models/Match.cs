
namespace DataLibrary.Models;

public class Match
{
    public int Id { get; set; }
    public int Hamster1Id { get; set; }
    public int Hamster2Id { get; set; }
    public int Hamster1Win { get; set; }
    public int Hamster2Win { get; set; }

    public virtual Hamster? Hamster { get; set; }
}
