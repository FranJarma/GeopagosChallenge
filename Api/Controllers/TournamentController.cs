using GeopagosChallenge.Api.DTO;
using GeopagosChallenge.Application.Interfaces;
using GeopagosChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GeopagosChallenge.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TournamentController : ControllerBase
  {
    private readonly ITournamentService _tournamentService;
    public TournamentController(ITournamentService tournamentService)
    {
      _tournamentService = tournamentService;
    }

    [HttpGet("GetTournaments")]
    public IActionResult GetTournaments([FromQuery] TournamentRequestQuery query)
    {
      var tournaments = _tournamentService.GetTournaments(query.Date, query.Gender);
      return Ok(tournaments);
    }

    [HttpPost("SimulateTournament")]
    public IActionResult SimulateTournament([FromBody] Tournament tournament)
    {
      var result = _tournamentService.SimulateTournament(tournament);
      return Ok($"The winner of the tournament is: {result.GetFullName()}");
    }
  }
}
