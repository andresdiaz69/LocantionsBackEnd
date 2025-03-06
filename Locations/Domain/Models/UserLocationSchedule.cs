using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Locations.Domain.Models;

[Table("UserLocationSchedule")]
public partial class UserLocationSchedule
{
    [Key]
    public long Id { get; set; }

    public long IdUser { get; set; }

    public long IdCompanyLocation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InitialTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FinalTime { get; set; }

    [ForeignKey("IdCompanyLocation")]
    [InverseProperty("UserLocationSchedules")]
    public virtual CompanyLocation IdCompanyLocationNavigation { get; set; } = null!;

    [ForeignKey("IdUser")]
    [InverseProperty("UserLocationSchedules")]
    public virtual User IdUserNavigation { get; set; } = null!;
}
