namespace GeopagosChallenge.Domain.Entities
{
  public class FemalePlayer : Player
  {
    public double ReactionTime { get; set; }
    public FemalePlayer(string name, string lastName, int skill, double luck, double reactionTime):base(name, lastName, skill, luck)
    {
      ReactionTime = reactionTime;
    }
  }
}
