using System;
using GeopagosChallenge.Interfaces;

namespace GeopagosChallenge.Domain.Entities
{
  public class Match
  {
    private readonly Random random = new Random();

    public Player GetMatchWinner(Player player1, Player player2)
    {
      double player1WinProbability = GetMatchWinProbability(player1);
      double player2WinProbability = GetMatchWinProbability(player2);

      return player1WinProbability >= player2WinProbability ? player1 : player2;
    }

    private double GetMatchWinProbability(Player player)
    {
      double playerLuck = random.NextDouble();
      double winProbability = player.Skill * playerLuck;

      if (player is MalePlayer manPlayer)
      {
        return winProbability * manPlayer.Force * manPlayer.Speed;
      }

      else if (player is FemalePlayer womanPlayer)
      {
        return winProbability / womanPlayer.ReactionTime;
      }

      return winProbability;
    }
  }
}
