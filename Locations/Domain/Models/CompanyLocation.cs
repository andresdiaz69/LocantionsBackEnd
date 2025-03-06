using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Locations.Domain.Models;

public partial class CompanyLocation
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(150)]
    public string Addres { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("IdCompanyLocationNavigation")]
    public virtual ICollection<UserLocationSchedule> UserLocationSchedules { get; set; } = new List<UserLocationSchedule>();
}
