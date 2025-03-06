using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Locations.Domain.Models;

public partial class Country
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("IdCountryNavigation")]
    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
