using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace C3_Bai2.Model.DomainClass;

[Table("NXB")]
public partial class Nxb
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdNxbNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
