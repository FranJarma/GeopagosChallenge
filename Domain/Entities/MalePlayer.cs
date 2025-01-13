namespace GeopagosChallenge.Domain.Entities
{
  public class MalePlayer : Player
  {
    public double Force { get; set; }
    public double Speed { get; set; }
    public MalePlayer(string name, string lastName, int skill, double luck, double force, double speed): base(name, lastName, skill, luck)
    {
      Force = force;
      Speed = speed;
    }
  }
}
