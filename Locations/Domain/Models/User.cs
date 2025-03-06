using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Locations.Domain.Models;

public partial class User
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(20)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    public int IdCity { get; set; }

    public short IdRol { get; set; }

    public bool Active { get; set; }

    [StringLength(100)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [ForeignKey("IdCity")]
    [InverseProperty("Users")]
    public virtual City IdCityNavigation { get; set; } = null!;

    [ForeignKey("IdRol")]
    [InverseProperty("Users")]
    public virtual Role IdRolNavigation { get; set; } = null!;

    [InverseProperty("IdUserNavigation")]
    public virtual ICollection<UserLocationSchedule> UserLocationSchedules { get; set; } = new List<UserLocationSchedule>();
}
