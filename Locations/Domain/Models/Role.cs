using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Locations.Domain.Models;

public partial class Role
{
    [Key]
    public short Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
