using GeopagosChallenge.Domain.Entities;
using GeopagosChallenge.Infraestructure.Database;
using GeopagosChallenge.Infraestructure.Interfaces;

namespace GeopagosChallenge.Infrastructure.Repositories
{
  public class TournamentRepository : ITournamentRepository
  {
    private readonly LiteDbContext _dbContext;

    public TournamentRepository(LiteDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public IEnumerable<Tournament> GetAll()
    {
      return _dbContext.Tournaments.FindAll();
    }

    public void Insert(Tournament tournament)
    {
      _dbContext.Tournaments.Insert(tournament);
    }
  }
}
