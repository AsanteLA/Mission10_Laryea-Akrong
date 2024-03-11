using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Data;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var teams = new List<string> {"Marlins", "Sharks"};

            var BowlerData = _bowlingRepository.Bowlers
                .Where(x => teams.Contains(x.Team.TeamName))
                .ToArray();

            return BowlerData;
        }
    }
}
