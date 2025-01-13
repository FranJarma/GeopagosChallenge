namespace GeopagosChallenge.Interfaces
{
  public interface IPlayer
  {
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set; }
    int Skill { get; set; }
    string GetFullName();
  }
}
