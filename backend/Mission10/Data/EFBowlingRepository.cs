
using Microsoft.EntityFrameworkCore;

namespace Mission10.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers.Include(x => x.Team);

        public IEnumerable<BowlerScore> BowlerScores => _bowlingContext.BowlerScores;

        public IEnumerable<MatchGame> MatchGames => _bowlingContext.MatchGames;

        public IEnumerable<Team> Teams => _bowlingContext.Teams;

        public IEnumerable<Tournament> Tournaments => _bowlingContext.Tournaments;

        public IEnumerable<TourneyMatch> TourneyMatches => _bowlingContext.TourneyMatches;

        public IEnumerable<ZtblBowlerRating> ZtblBowlerRatings => _bowlingContext.ZtblBowlerRatings;

        public IEnumerable<ZtblSkipLabel> ZtblSkipLabels => _bowlingContext.ZtblSkipLabels;

        public IEnumerable<ZtblWeek> ZtblWeeks => _bowlingContext.ZtblWeeks;
    }
}
