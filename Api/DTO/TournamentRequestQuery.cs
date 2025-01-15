using GeopagosChallenge.Domain.Enums;

namespace GeopagosChallenge.Api.DTO
{
  public class TournamentRequestQuery
  {
    public DateTime? Date { get; set; } = null;
    public GenderEnum Gender { get; set; }
  }
}
