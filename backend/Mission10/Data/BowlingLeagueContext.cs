using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission10.Data;

public partial class BowlingLeagueContext : DbContext
{
    public BowlingLeagueContext()
    {
    }

    public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bowler> Bowlers { get; set; }

    public virtual DbSet<BowlerScore> BowlerScores { get; set; }

    public virtual DbSet<MatchGame> MatchGames { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    public virtual DbSet<TourneyMatch> TourneyMatches { get; set; }

    public virtual DbSet<ZtblBowlerRating> ZtblBowlerRatings { get; set; }

    public virtual DbSet<ZtblSkipLabel> ZtblSkipLabels { get; set; }

    public virtual DbSet<ZtblWeek> ZtblWeeks { get; set; }
}
