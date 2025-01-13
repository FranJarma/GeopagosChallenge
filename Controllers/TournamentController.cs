using GeopagosChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GeopagosChallenge.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TournamentController: ControllerBase
  {
    private readonly Player[] players = new Player[8];

    [HttpGet(Name = "GetTournament")]

    [HttpPost(Name = "CreateTournament")]

    [HttpGet(Name = "GetTournamentWinner")]
  }
}
