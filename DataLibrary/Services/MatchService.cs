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
        public async Task<List<Match>> GetAllMatchesByHamsterId(int hamsterId)
        {
           return await _repo.GetAllMatchesByHamsterId(hamsterId);
        }
    }
}
