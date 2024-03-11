using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10.Data;

public partial class ZtblBowlerRating
{
    [Key]
    [Required]
    public string BowlerRating { get; set; }

    public short? BowlerLowAvg { get; set; }

    public short? BowlerHighAvg { get; set; }
}
