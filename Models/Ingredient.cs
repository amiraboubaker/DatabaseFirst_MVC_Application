using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

[Keyless]
public partial class Ingredient
{
    [Column("id")]
    public int? Id { get; set; }

    [StringLength(10)]
    public string? Name { get; set; }
}
