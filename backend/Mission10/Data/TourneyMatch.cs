using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10.Data;

public partial class TourneyMatch
{
    [Key]
    [Required]
    public int MatchId { get; set; }

    [ForeignKey("TourneyId")]
    public int? TourneyId { get; set; }
    public Tournament? Tourney { get; set; }

    public string? Lanes { get; set; }

    [ForeignKey("TeamId")]
    public int? OddLaneTeamId { get; set; }
    public Team? OddLaneTeam { get; set; }

    [ForeignKey("TeamId")]
    public int? EvenLaneTeamId { get; set; }
    public Team? EvenLaneTeam { get; set; }
}
