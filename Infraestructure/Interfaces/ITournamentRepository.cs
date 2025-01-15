using GeopagosChallenge.Domain.Entities;

namespace GeopagosChallenge.Infraestructure.Interfaces
{
  public interface ITournamentRepository
  {
    IEnumerable<Tournament> GetAll();
    void Insert(Tournament tournament);
  }
}
