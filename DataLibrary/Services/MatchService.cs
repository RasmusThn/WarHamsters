using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Services
{
    public class MatchService
    {
        private readonly MatchRepository _repo;

        public MatchService(MatchRepository repo)
        {
            _repo = repo;
        }
        public List<Match> GetAllMatchesByHamsterId(int hamsterId)
        {
            return _repo.GetAllMatchesByHamsterId(hamsterId);
        }
        public async Task AddNewMatch(Hamster hamsterWin, Hamster hamsterLoss)
        {
            await _repo.AddNewMatch(hamsterWin, hamsterLoss);
        }
    }
}
