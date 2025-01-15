using GeopagosChallenge.Domain.Entities;
using GeopagosChallenge.Domain.Enums;

namespace GeopagosChallenge.Application.Interfaces
{
  public interface ITournamentService
  {
    IEnumerable<Tournament> GetTournaments(DateTime? date, GenderEnum? gender);
    Player SimulateTournament(Tournament tournament);
  }
}
