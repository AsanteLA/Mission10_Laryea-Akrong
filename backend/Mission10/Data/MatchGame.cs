using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10.Data;

public partial class MatchGame
{
    [ForeignKey("MatchId")]
    [Required]
    public int MatchId { get; set; }
    public TourneyMatch? TourneyMatch { get; set; }

    [Key]
    [Required]
    public short GameNumber { get; set; }

    public int? WinningTeamId { get; set; }
}
