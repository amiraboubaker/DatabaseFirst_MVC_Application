using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

[Keyless]
public partial class Dish
{
    public int Id { get; set; }

    [StringLength(10)]
    public string Name { get; set; } = null!;

    [StringLength(10)]
    public string ImageUrl { get; set; } = null!;

    public double Price { get; set; }
}
