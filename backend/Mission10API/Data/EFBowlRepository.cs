
using Microsoft.EntityFrameworkCore;
using Mission10API.Data;

namespace Mission10API.Repositories
{
    public class EFBowlRepository : IBowlRepository
    {
        private readonly BowlersContext _context;

        public EFBowlRepository(BowlersContext context)
        {
            _context = context;
        }

        public IEnumerable<Bowlers> GetAllBowlers()
        {
            return _context.Bowlers.ToArray();
        }

        public IEnumerable<Bowlers> GetBowlersByTeamNames(params string[] teamNames)
        {
            return _context.Bowlers
                .Include(b => b.Team)
                .Where(b => teamNames.Contains(b.Team.TeamName))
                .ToList();
        }
    }
}