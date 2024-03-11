using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10.Data;

public partial class BowlerScore
{
    [Key]
    [Required]
    public int MatchId { get; set; }

    [Required]
    public short GameNumber { get; set; }

    [ForeignKey("BowlerId")]
    public int? BowlerId { get; set; }
    public Bowler Bowler { get; set; }

    public short? RawScore { get; set; }

    public short? HandiCapScore { get; set; }

    [Required]
    public bool WonGame { get; set; }
}
