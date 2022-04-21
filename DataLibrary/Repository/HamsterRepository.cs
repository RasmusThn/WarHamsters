

namespace DataLibrary.Repository;

public class HamsterRepository
{
    
    private readonly IDbContextFactory<DataContext> _factory;
    public HamsterRepository(IDbContextFactory<DataContext> factory)
    {
        _factory = factory;
        //var ctx = _factory.CreateDbContext(); Testa om detta funkar nån gång
    }
    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            hamsterWin.Wins++;
            hamsterWin.Games++;
            hamsterLoss.Defeats++;
            hamsterLoss.Games++;
            ctx.UpdateRange(hamsterWin, hamsterLoss);
           
            await ctx.SaveChangesAsync();

        }
    }
    public async Task<Hamster> GetHamsterById(int id)
    {
        using (var ctx = _factory.CreateDbContext())
        {

            Hamster hamster = ctx.Hamsters.First(x => x.Id == id);
            return hamster;
        }
    }
    public List<Hamster> GetHamsterBySearch(string searchTerm)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            var hamsters = ctx.Hamsters.Where(p => string.IsNullOrEmpty(searchTerm)
               || p.Name.ToLower().Contains(searchTerm.ToLower()));
            return hamsters.ToList();
        }
    }
    public bool AddHamster(Hamster hamster)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            ctx.Hamsters.Add(hamster);
           ctx.SaveChangesAsync();
            return true;
        }
        return false;
    }
    public async void DeleteHamster(Hamster hamster)
    {
        using (var ctx = _factory.CreateDbContext())
        {
          ctx.Hamsters.Remove(hamster);
          await ctx.SaveChangesAsync();
        }
        
    }
    
    public async Task<List<Hamster>> GetTwoRandomHamsters()
    {
        using (var ctx = _factory.CreateDbContext())
        {
        Random rnd = new Random();  
        int n = ctx.Hamsters.Count();
        var list = ctx.Hamsters.ToList();

        // Plockat från Stackoverflow/google --https://blog.codinghorror.com/shuffling/ via Patrik S.
        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            Hamster value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
            List<Hamster> data = list
                    .Take(2)
                    .ToList();

        return data.ToList();
        }
    }
    public async Task<List<Hamster>> GetAllHamsters()
    {
        using (var ctx = _factory.CreateDbContext())
        {

            var hamsters = await ctx.Hamsters.ToListAsync();

            return hamsters;
        }

    }
    /// <summary>
    /// Returns true if there are any Hamsters in the Database
    /// </summary>
    /// <returns></returns>
    public bool CheckDatabaseForHamsters()
    {
        using (var ctx = _factory.CreateDbContext())
        {
            if (ctx.Hamsters.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public async Task AddMatch(Hamster hamster1, Hamster hamster2)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            Match match = new Match
            {
                Hamster1Id = hamster1.Id,
                Hamster2Id = hamster2.Id

            };
            ctx.Matches.Add(match);
            await ctx.SaveChangesAsync();
            //For loopa för varje som inte har samma id som sig själv
        }
    }
}

