
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
        var hamsters = _repo.GetAllHamsters();

        hamsters.Where(x => x.IsActive == true).ToList();

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
        var Allhamsters = _repo.GetAllHamsters();
        var searchHamsters = Allhamsters.Where(p => string.IsNullOrEmpty(searchTerm)
           || p.Name.ToLower().Contains(searchTerm.ToLower()));
        return searchHamsters.ToList();
        //return _repo.GetHamsterBySearch(searchTerm);
    }
    public List<Hamster> GetTwoRandomHamsters()
    {
        var hamsters = _repo.GetAllHamsters();
        //return _repo.GetTwoRandomHamsters();
        Random rnd = new Random();
        int n = hamsters.Count();
        hamsters.ToList();

        // Plockat från Stackoverflow/google --https://blog.codinghorror.com/shuffling/ via Patrik S.
        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            Hamster value = hamsters[k];
            hamsters[k] = hamsters[n];
            hamsters[n] = value;
        }
        List<Hamster> twoHamsters = hamsters
                .Where(h => h.IsActive == true)
                .Take(2)
                .ToList();

        return twoHamsters.ToList();
    }
    public List<Hamster> Get5Hamsters(bool isTop)
    {
        var hamsters = _repo.GetAllHamsters();
        if (isTop)
        {
          var hamstersOrdered = hamsters.Where(x => x.IsActive == true).OrderByDescending(x => x.Wins);
            List<Hamster> hamsters5 = hamstersOrdered.Take(5).ToList();
            return hamsters5;
        }
        else
        {
            var hamstersOrdered = hamsters.Where(x => x.IsActive == true).OrderByDescending(x => x.Defeats);
            List<Hamster> hamsters5 = hamstersOrdered.Take(5).ToList();
            return hamsters5;
        }
        
    }

}
