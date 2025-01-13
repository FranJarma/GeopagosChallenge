using GeopagosChallenge.Interfaces;

namespace GeopagosChallenge.Domain.Entities
{
  public class Player : IPlayer
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Skill { get; set; }
    public string GetFullName()
    {
      return $"{Name} {LastName}";
    }
    public Player(string name, string lastName, int skill)
    {
      Name = name;
      LastName = lastName;
      Skill = skill;
    }
  }
}
