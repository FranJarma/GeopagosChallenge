using GeopagosChallenge.Domain.Entities;

namespace GeopagosChallenge.Interfaces
{
  public interface IMatch
  {
    Player Player1 { get; set; }
    Player Player2 { get; set; }
    Player Winner { get; set; }
  }
}
