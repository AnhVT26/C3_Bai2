using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace C3_Bai2.Model.DomainClass;

[Table("MoiQuanHe")]
public partial class MoiQuanHe
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdMqhNavigation")]
    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();
}
