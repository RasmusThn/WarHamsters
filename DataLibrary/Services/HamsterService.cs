
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
    public async Task AddNewMatch(Hamster hamsterWin,Hamster hamsterLoss)
    {
        await _repo.AddNewMatch(hamsterWin, hamsterLoss);
    }
    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)
    {
        
        await _repo.AddWin(hamsterWin, hamsterLoss);
    }
    public bool AddHamster(Hamster hamster)
    {
        bool isOk = _repo.AddHamster(hamster);
        return isOk;
    }
    public async Task<Hamster> GetHamsterById(int id)
    {
        return await _repo.GetHamsterById(id);
    }
    public async Task<List<Hamster>> GetAllActiveHamsters()
    {
        var hamsters = _repo.GetAllActiveHamsters();
        return await hamsters;
    }
    public async Task<List<Hamster>> GetAllHamsters()
    {
        var hamsters = _repo.GetAllHamsters();
        return await hamsters;
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
    public async Task<List<Hamster>> GetTwoRandomHamsters()
    {
        return await _repo.GetTwoRandomHamsters();
    }
    public async Task<List<Hamster>> Get5Hamsters(bool isTop)
    {
       var hamsters = _repo.Get5Hamsters(isTop);
        return await hamsters;
    }
  
}
