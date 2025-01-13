using GeopagosChallenge.Enums;

namespace GeopagosChallenge.Interfaces
{
  public interface ITournament
  {
    int Id { get; set; }
    string Name { get; set; }
    TournamentGenderEnum Gender { get; set; }
  }
}
