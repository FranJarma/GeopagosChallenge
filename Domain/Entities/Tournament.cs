using GeopagosChallenge.Enums;
using GeopagosChallenge.Interfaces;

namespace GeopagosChallenge.Domain.Entities
{
  public class Tournament : ITournament
  {
    private readonly Player[] _players;
    private readonly Match _match;
    public int Id { get; set; }
    public string Name { get; set; }
    public TournamentGenderEnum Gender { get; set; }

    public Tournament(int id, string name, TournamentGenderEnum gender, Player[] players, Match match)
    {
      Id = id;
      Name = name;
      Gender = gender;
      _players = players;
      _match = new Match();
    }

    public Player GetWinner()
    {
      List<Player> winners = _players.ToList();

      int round = 0;

      while (winners.Count() > 1)
      {
        Player player1 = _players[round];
        Player player2 = _players[round++];
        Player winner = _match.GetMatchWinner(player1, player2);

        if (player1 == winner)
        {
          winners.Remove(player2);
        }
        else
        {
          winners.Remove(player1);
        }

        round=+2;
      }

      return winners.First();
    }
  }
}
