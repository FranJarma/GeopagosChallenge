using System.ComponentModel.DataAnnotations.Schema;
using GeopagosChallenge.Domain.Enums;
using LiteDB;

namespace GeopagosChallenge.Domain.Entities
{
  public class Tournament
  {
    [BsonId]
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string Name { get; set; }
    public GenderEnum Gender { get; set; }
    public List<Player> Players { get; set; }
    [NotMapped]
    public Player? Winner { get; private set; } = null;
    public Tournament(DateTime date, GenderEnum gender, string name, List<Player> players)
    {
      Date = date;
      Gender = gender;
      Name = name;
      Players = players;
    }

    public Player GetWinner()
    {
      List<Player> winners = Players.ToList();

      while (winners.Count > 1)
      {
        List<Player> roundWinners = new List<Player>();

        for (int i = 0; i < winners.Count; i += 2)
        {
          if (i + 1 >= winners.Count)
          {
            roundWinners.Add(winners[i]);
            break;
          }

          Player player1 = winners[i];
          Player player2 = winners[i + 1];
          Match match = new Match(player1, player2);
          Player winner = match.GetMatchWinner();

          roundWinners.Add(winner);
        }

        winners = roundWinners;
      }

      Winner = winners.First();

      return Winner;
    }
  }
}
