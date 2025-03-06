using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Locations.Domain.Models;

public partial class City
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int IdCountry { get; set; }

    public bool Active { get; set; }

    [ForeignKey("IdCountry")]
    [InverseProperty("Cities")]
    public virtual Country IdCountryNavigation { get; set; } = null!;

    [InverseProperty("IdCityNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
