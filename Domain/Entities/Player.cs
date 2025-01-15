using GeopagosChallenge.Domain.Enums;
using GeopagosChallenge.Domain.Interfaces;

namespace GeopagosChallenge.Domain.Entities
{
  public class Player : IPlayer
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public GenderEnum Gender { get; set; }
    public int Skill { get; set; }
    public int? Strength { get; set; }
    public int? Speed { get; set; }
    public int? ReactionTime { get; set; }
    public string GetFullName()
    {
      return $"{Name} {LastName}";
    }
    public Player(string name, string lastName, int skill, GenderEnum gender, int? strength, int? speed, int? reactionTime)
    {
      Name = name;
      LastName = lastName;
      Skill = skill;
      Gender = gender;
      Strength = strength;
      Speed = speed;
      ReactionTime = reactionTime;
    }
  }
}
