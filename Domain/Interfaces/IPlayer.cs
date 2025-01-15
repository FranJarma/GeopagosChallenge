namespace GeopagosChallenge.Domain.Interfaces
{
  public interface IPlayer
  {
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set; }
    int Skill { get; set; }
    int? Strength { get; set; }
    int? Speed { get; set; }
    int? ReactionTime { get; set; }
    string GetFullName();
  }
}
