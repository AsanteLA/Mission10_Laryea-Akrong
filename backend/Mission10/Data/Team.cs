using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10.Data;

public partial class Team
{
    [Key]
    [Required]
    public int TeamId { get; set; }

    [Required]
    public string TeamName { get; set; }

    [ForeignKey("CaptainId")]
    public int? CaptainId { get; set; }
}
