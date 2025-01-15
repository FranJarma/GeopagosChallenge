using GeopagosChallenge.Application.Interfaces;
using GeopagosChallenge.Domain.Entities;
using GeopagosChallenge.Domain.Enums;
using GeopagosChallenge.Infraestructure.Interfaces;

namespace GeopagosChallenge.Application.Services
{
  public class TournamentService : ITournamentService
  {
    private readonly ITournamentRepository _tournamentRepository;

    public TournamentService(ITournamentRepository tournamentRepository)
    {
      _tournamentRepository = tournamentRepository;
    }

    public IEnumerable<Tournament> GetTournaments(DateTime? date, GenderEnum? gender)
    {
      var tournaments = _tournamentRepository.GetAll();

      if (tournaments.Count() > 0)
      {
        if (gender.HasValue)
        {
          tournaments = tournaments.Where(t => t.Gender == gender);
        }

        if (date.HasValue)
        {
          tournaments = tournaments.Where(t => t.Date == date.Value);
        }
      }

      return tournaments;
    }

    public Player SimulateTournament(Tournament tournament)
    {
      _tournamentRepository.Insert(tournament);

      var winner = tournament.GetWinner();

      return winner;
    }
  }
}
