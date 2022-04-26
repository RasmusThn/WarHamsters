

namespace DataLibrary.Repository;

public class MatchRepository
{
    private readonly IDbContextFactory<DataContext> _factory;
    public MatchRepository(IDbContextFactory<DataContext> factory)
    {
        _factory = factory;
    }
    public List<Match> GetAllMatchesByHamsterId(int hamsterId)
    {

        using (var ctx = _factory.CreateDbContext())
        {
            List<Match> matches = ctx.Matches.Where(x => x.WinnerId == hamsterId || x.LoserId == hamsterId).ToList();

            return matches;
        }
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
}
