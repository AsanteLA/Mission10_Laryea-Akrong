using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10.Data;

public partial class Tournament
{
    [Key]
    [Required]
    public int TourneyId { get; set; }

    public DateOnly? TourneyDate { get; set; }

    public string? TourneyLocation { get; set; }
}
