using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10API.Data;

namespace Mission10API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly IBowlRepository _bowlRepository;

        public BowlerController(IBowlRepository bowlRepository)
        {
            _bowlRepository = bowlRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var bowlers = _bowlRepository.GetBowlersByTeamNames("Marlins", "Sharks")
                                          .Select(b => new {
                                              BowlerName = $"{b.BowlerFirstName} {b.BowlerLastName}",
                                              TeamName = b.Team.TeamName, 
                                              b.BowlerCity,
                                              b.BowlerState,
                                              b.BowlerZip,
                                              b.BowlerAddress,
                                              b.BowlerPhoneNumber
                                          })
                                          .ToList();

            return Ok(bowlers);
        }
    }
}