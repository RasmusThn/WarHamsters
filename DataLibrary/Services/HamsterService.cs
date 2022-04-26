
namespace DataLibrary.Services;
/// <summary>
/// Länk mellan Client och Server
/// </summary>
public class HamsterService
{
    private readonly HamsterRepository _repo;

    public HamsterService(HamsterRepository repo)
    {
        _repo = repo;
    }
   
    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)
    {
        
        await _repo.AddWin(hamsterWin, hamsterLoss);
    }
    public Task AddHamster(Hamster hamster)
    {
       return _repo.AddHamster(hamster);
        
    }
    public Hamster GetHamsterById(int id)
    {
        return _repo.GetHamsterById(id);
    }
    public List<Hamster> GetAllActiveHamsters()
    {
        var hamsters = _repo.GetAllActiveHamsters();
        return hamsters;
    }
    public List<Hamster> GetAllHamsters()
    {
        var hamsters = _repo.GetAllHamsters();
        return hamsters;
    }
    /// <summary>
    /// Returns true if there are any Hamsters in the Database
    /// </summary>
    /// <returns></returns>
    public bool CheckDatabaseForHamsters()
    {
        return _repo.CheckDatabaseForHamsters();
    }
    public void DeleteHamster(Hamster hamster)
    {
        _repo.DeleteHamster(hamster);
    }
    public List<Hamster> GetHamsterBySearch(string searchTerm)
    {
        return _repo.GetHamsterBySearch(searchTerm);
    }
    public List<Hamster> GetTwoRandomHamsters()
    {
        return _repo.GetTwoRandomHamsters();
    }
    public List<Hamster> Get5Hamsters(bool isTop)
    {
        var hamsters = _repo.Get5Hamsters(isTop);
        return hamsters;
    }

}
