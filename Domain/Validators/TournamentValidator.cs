using GeopagosChallenge.Domain.Entities;
using GeopagosChallenge.Domain.Interfaces;

namespace GeopagosChallenge.Domain.Validators
{
  public class TournamentValidator : IValidator<Tournament>
  {
    public void Validate(Tournament tournament)
    {
      if (!tournament.Players.Any())
      {
        throw new ArgumentException("The tournament must have at least one player.");
      }

      if (tournament.Players.Any(player => player.Gender != tournament.Gender))
      {
        throw new ArgumentException("All players must have the same gender as the tournament.");
      }
    }
  }

}
