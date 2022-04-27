

namespace DataLibrary.Repository;

public class HamsterRepository
{

    private readonly IDbContextFactory<DataContext> _factory;
    public HamsterRepository(IDbContextFactory<DataContext> factory)
    {
        _factory = factory;
        //var ctx = _factory.CreateDbContext(); Testa om detta funkar nån gång/ fråga om det är rätt att göra så
    }
   
    public async Task UpdateHamster(Hamster hamster)
    {
        using (var ctx = _factory.CreateDbContext())
        {
            var DbHamster = await ctx.Hamsters.FindAsync(hamster.Id);


            DbHamster.Name = hamster.Name;
            DbHamster.Age = hamster.Age;
            DbHamster.FavFood = hamster.FavFood;
            DbHamster.Loves = hamster.Loves;
            DbHamster.ImgName = hamster.ImgName;
            DbHamster.Wins = hamster.Wins;
            DbHamster.Defeats = hamster.Defeats;
            DbHamster.Games = hamster.Games;
            DbHamster.IsActive = hamster.IsActive;

            await ctx.SaveChangesAsync();
            }
        
    }
    public Hamster GetHamsterById(int id)
    {
        using (var ctx = _factory.CreateDbContext())
        {

            Hamster hamster = ctx.Hamsters.First(x => x.Id == id);
            return hamster;
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
    public List<Hamster> GetAllHamsters()
    {
        using (var ctx = _factory.CreateDbContext())
        {

            List<Hamster> hamsters = ctx.Hamsters.ToList();

            return hamsters.ToList();
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

