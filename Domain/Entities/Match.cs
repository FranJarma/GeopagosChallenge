using GeopagosChallenge.Domain.Enums;

namespace GeopagosChallenge.Domain.Entities
{
  public class Match
  {
    private readonly Random random = new Random();
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }

    public Match (Player player1, Player player2)
    {
      Player1 = player1;
      Player2 = player2;
    }

    public Player GetMatchWinner()
    {
      double player1WinProbability = GetMatchWinProbability(Player1);
      double player2WinProbability = GetMatchWinProbability(Player2);

      return player1WinProbability >= player2WinProbability ? Player1 : Player2;
    }

    private double GetMatchWinProbability(Player player)
    {
      double playerLuck = random.NextDouble();
      double winProbability = 0.0;

      if (player.Gender == GenderEnum.Male)
      {
        double maxMaleValue = player.Skill + player.Strength.Value + player.Speed.Value;
        winProbability = (player.Skill + player.Strength.Value + player.Speed.Value) * playerLuck / maxMaleValue;
      }
      else if (player.Gender == GenderEnum.Female)
      {
        double maxFemaleValue = player.Skill + player.ReactionTime.Value;
        winProbability = (player.Skill + player.ReactionTime.Value) * playerLuck / maxFemaleValue;
      }

      return Math.Clamp(winProbability, 0.0, 1.0);
    }
  }
}
