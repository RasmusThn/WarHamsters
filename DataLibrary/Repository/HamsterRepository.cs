

namespace DataLibrary.Repository;

public class HamsterRepository
{

    private readonly IDbContextFactory<DataContext> _factory;
    public HamsterRepository(IDbContextFactory<DataContext> factory)
    {
        _factory = factory;
        //var ctx = _factory.CreateDbContext(); Testa om detta funkar nån gång/ fråga om det är rätt att göra så
    }
    public async Task AddNewMatch(Hamster hamsterWin, Hamster hamsterLoss)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            Match match = new Match
            {
                WinnerId = hamsterWin.Id,
                LoserId = hamsterLoss.Id
            };
            ctx.Matches.Add(match);
            await ctx.SaveChangesAsync();
        }
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
    public async Task AddHamster(Hamster hamster)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            ctx.Hamsters.Add(hamster);
           await ctx.SaveChangesAsync();
           
        }
        
    }
    public async void DeleteHamster(Hamster hamster)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            //ctx.Hamsters.Remove(hamster);
            hamster.IsActive = false;
            ctx.Update(hamster);
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
                    .Where(h => h.IsActive == true)
                    .Take(2)
                    .ToList();

            return data.ToList();
        }
    }
    public async Task<List<Hamster>> GetAllActiveHamsters()
    {
        using (var ctx = _factory.CreateDbContext())
        {

            List<Hamster> hamsters = ctx.Hamsters.Where(x => x.IsActive == true).ToList();

            return hamsters.ToList();
        }

    }
    public async Task<List<Hamster>> GetAllHamsters()
    {
        using (var ctx = _factory.CreateDbContext())
        {

            List<Hamster> hamsters = ctx.Hamsters.ToList();

            return hamsters.ToList();
        }

    }
    public async Task<List<Hamster>> Get5Hamsters(bool isTop)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            if (isTop)
            {
                var hamsters = ctx.Hamsters.Where(x => x.IsActive == true).OrderByDescending(x => x.Wins);
                List<Hamster> hamsters5 = hamsters.Take(5).ToList();
                return hamsters5;
            }
            else
            {
                var hamsters = ctx.Hamsters.Where(x => x.IsActive == true).OrderByDescending(x => x.Defeats);
                List<Hamster> hamsters5 = hamsters.Take(5).ToList();
                return hamsters5;
            }

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


}

